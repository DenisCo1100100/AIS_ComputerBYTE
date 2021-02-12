using System;
using System.Windows.Forms;

namespace AIS_ComputerBYTE
{
    public partial class AddingClientsForm : Form
    {
        private DataGridView DataGrid { get; set; }

        public AddingClientsForm(DataGridView gridView)
        {
            InitializeComponent();

            DataGrid = gridView;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            try
            {
                int discount = Convert.ToInt32(discountTextBox.Text);

                string cmdText = $"INSERT INTO Clients ([Фамилия], [Имя], [Отчество], [Адрес], [Паспорт], [Дата регистрации], [Мобильный телефон], [Предоставить скидку], [Предпологаемый месяц], [Средняя зарплата]) VALUES (" +
                    $"'" + lastNameTextBox.Text + "'," +
                    " '" + firstNameTextBox.Text + "'," +
                    " '" + patronymicTextBox.Text + "'," +
                    " '" + adressTextBox.Text + "'," +
                    " '" + pasportTextBox.Text + "'," +
                    " '" + DateTime.Now + "'," +
                    " '" + phoneTextBox.Text + "'," +
                    " '" + discount + "'," +
                    " '" + monthСomboBox.Text + "'," +
                    " '" + profitTextBox.Text + "')";

                new ColculateStatistick().AddClient(int.Parse(profitTextBox.Text));

                TableMenager tableMenager = new TableMenager();
                tableMenager.ExecuteRequest(cmdText);

                DataGridViewControll gridViewControll = new DataGridViewControll();
                gridViewControll.Update(DataGrid, "Clients");

                MessageBox.Show("Готово!", "Внимание!");
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте введенные данные", "Ошибка");
            }
        }
    }
}
