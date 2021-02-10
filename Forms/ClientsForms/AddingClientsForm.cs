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
            int discount = Convert.ToInt32(discountTextBox.Text);

            string cmdText = $"INSERT INTO Clients ([Фамилия], [Имя], [Отчество], [Адрес], [Паспорт], [Дата регистрации], [Мобильный телефон], [Предоставить скидку], [Предпологаемый месяц]) VALUES (" +
                $"'" + lastNameTextBox.Text + "'," +
                " '" + firstNameTextBox.Text + "'," +
                " '" + patronymicTextBox.Text + "'," +
                " '" + adressTextBox.Text + "'," +
                " '" + pasportTextBox.Text + "'," +
                " '" + DateTime.Now + "'," +
                " '" + phoneTextBox.Text + "'," +
                " '" + discount + "'," +
                " '" + monthСomboBox.Text + "')";

            TableMenager tableMenager = new TableMenager();
            tableMenager.ExecuteRequest(cmdText);

            MessageBox.Show("Готво!", "Внимание!");
        }

        private void AddingClientsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new ColculateStatistick().AddClient();
            DataGridViewControll gridViewControll = new DataGridViewControll();
            gridViewControll.Update(DataGrid, "Clients");
        }
    }
}
