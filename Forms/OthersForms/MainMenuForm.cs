using System;
using System.Windows.Forms;

namespace AIS_ComputerBYTE
{
    public partial class MainMenuForm : Form
    {
        public string Login { get; private set; }
        private string FullName { get; set; }
        private string Positions { get; set; }
        private int LvlAccses { get; set; }

        public static MainMenuForm mainMenu;

        public MainMenuForm(string login, string fullName, string position, int lvlAccses)
        {
            InitializeComponent();

            Login = login;
            FullName = fullName;
            Positions = position;
            LvlAccses = lvlAccses;
            mainMenu = this;

            FillUserDate();
            ProvidingAccses();
            Application.OpenForms[0].Hide();
        }

        private void FillUserDate()
        {
            groupBox1.Text = Login;

            string[] fullNameSplit = FullName.Split();
            userNameLable.Text = $"Фамилия: {fullNameSplit[0]}\n" +
                $"Имя: {fullNameSplit[1]}\n" +
                $"Отчество: {fullNameSplit[2]}\n" +
                $"Должность: {Positions}";
        }

        private void ProvidingAccses()
        {
            if (LvlAccses == 2)
            {
                registrationButton.Visible = false;
                statistickButton.Visible = false;
            }
        }
        private void assortmentButton_Click(object sender, EventArgs e)
        {
            new AssortmentForm().ShowDialog();
        }

        private void changeEmployee_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Close();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            new EmployeManagmentForm().ShowDialog();
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            new ClientsForm().ShowDialog();
        }

        private void statistickButton_Click(object sender, EventArgs e)
        {
            new StatisticksForm().ShowDialog();
        }

        private void saleComputersButton_Click(object sender, EventArgs e)
        {
            new SaleComputersForm().ShowDialog();
        }

        private void salesForecastsButton_Click(object sender, EventArgs e)
        {
            new SalesForecastsForm().ShowDialog();
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
