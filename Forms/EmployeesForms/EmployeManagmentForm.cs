using System;
using System.Windows.Forms;

namespace AIS_ComputerBYTE
{
    public partial class EmployeManagmentForm : Form
    {
        public EmployeManagmentForm()
        {
            InitializeComponent();
        }

        private void EmployeManagmentForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerByteDataBaseDataSet1.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.computerByteDataBaseDataSet1.Employees);
            new DataGridViewControll().Update(employeesDataGridView, "Employees");
        }

        private void assortmentButton_Click(object sender, EventArgs e)
        {
            new RegistrationEmployeesForm(employeesDataGridView).ShowDialog();
        }
    }
}
