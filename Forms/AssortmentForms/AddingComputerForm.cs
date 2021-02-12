using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AIS_ComputerBYTE
{
    public partial class AddingComputerForm : Form
    {
        private int ImageName { get; set; }
        private DataGridView AssortmentDataGrid { get; set; }

        public AddingComputerForm(int indexImage, DataGridView assortmentDataGrid)
        {
            InitializeComponent();

            ImageName = indexImage + 1;
            AssortmentDataGrid = assortmentDataGrid;

            openFileDialog1.Filter = "Image Files(*.JPG)|*.JPG";
            openFileDialog1.Filter = "Image Files(*.JPG)|*.JPG";
            openFileDialog1.FileOk += OpenFileDialog1_FileOk;
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Image = Image.FromStream(openFileDialog1.OpenFile());
        }

        private void addImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
        }

        private void complite_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save($@"{Application.StartupPath}\ComputerImages\{ImageName}.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else
                {
                    MessageBox.Show("Добавте изображение", "Ошибка");
                }
            
                string imageIndex = ImageName.ToString();
                int price = Convert.ToInt32(priceTextBox.Text);
                int guarante = Convert.ToInt32(guaranteTextBox.Text);

                string request = $"INSERT INTO Computers ([Код], [Производитель], [Материнская плата], [ОЗУ], [ПЗУ], [Блок питания], [Видеокарта], [Процессор], [Цена], [Гарантия]) VALUES (" +
                    $"'" + imageIndex + "'," +
                    " '" + manufacturTextBox.Text + "'," +
                    " '" + motherboardTextBox.Text + "'," +
                    " '" + OZUtextBox.Text + "'," +
                    " '" + PZUtextBox.Text + "'," +
                    " '" + powerSupplyTextBox.Text + "'," +
                    " '" + graphicsCardTextBox.Text + "'," +
                    " '" + CPUTextBox.Text + "'," +
                    " '" + price + "'," +
                    " '" + guarante + "')";

                TableMenager computersTable = new TableMenager();
                computersTable.ExecuteRequest(request);

                MessageBox.Show("Компьютер добавлен!", "Готово");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте введенные данные", "Ошибка");
            }
        }

        private void AddingComputerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataGridViewControll gridViewControll = new DataGridViewControll();
            gridViewControll.Update(AssortmentDataGrid, "Computers");
        }
    }
}