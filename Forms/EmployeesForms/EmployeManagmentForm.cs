using System;
using System.Windows.Forms;

namespace AIS_ComputerBYTE
{
    public partial class EmployeManagmentForm : Form
    {
        DataGridViewControll gridViewControll;
        private int SelectRow { get; set; }

        public EmployeManagmentForm()
        {
            InitializeComponent();

            gridViewControll = new DataGridViewControll();
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string request = $@"Delete * From Employees WHERE код = {employeesDataGridView[0, SelectRow].Value}";
                new TableMenager().ExecuteRequest(request);

                gridViewControll.Update(employeesDataGridView, "Employees");
            }
            catch (Exception)
            {
                MessageBox.Show("Нельзя удалить", "Внимание!");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void employeesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow = e.RowIndex;
        }
    }
}
