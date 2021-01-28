using System;
using System.Windows.Forms;

namespace AIS_ComputerBYTE
{
    public partial class RegistrationEmployeesForm : Form
    {
        private DataGridView DataGridView { get; set; }

        public RegistrationEmployeesForm(DataGridView dataGridView)
        {
            InitializeComponent();

            DataGridView = dataGridView;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            string fullName = $"{lastNameTextBox.Text} {firstNameLabel.Text} {patronymicTextBox.Text}";
            Registration registration = new Registration(loginTextBox.Text, passwordTextBox.Text, fullName, positionComboBox.Text);
            registration.Execute(Int32.Parse(pasportNumberTextBox.Text), Int32.Parse(ageTextBox.Text), addressTextBox.Text, Int32.Parse(accsesLvlComboBox.Text), Int32.Parse(expirianceTextBox.Text), educationTextBox.Text);
            new DataGridViewControll().Update(DataGridView, "Employees");
            
            MessageBox.Show("Сотрудник зарегистрирован", "Готово!");
        }
    }
}
