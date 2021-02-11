using System;
using System.Windows.Forms;

namespace AIS_ComputerBYTE
{
    public partial class SaleComputersForm : Form
    {
        #region computerDataPrivateVariables
        public string Monufacterer { get; private set; }
        public string Motherboard { get; private set; }
        public string PowerSupply { get; private set; }
        public string VideoCard { get; private set; }
        public string CPU { get; private set; }
        public string OZU { get; private set; }
        public string PZU { get; private set; }
        public string Price { get; private set; }
        public string Guarante { get; private set; }
        #endregion

        #region clientsDataPrivateVariables
        public string FIO { get; private set; }
        public string Pasport { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Discount { get; private set; }
        public int ToPay { get; private set; }
        #endregion

        public static SaleComputersForm saleComputers;

        public SaleComputersForm()
        {
            InitializeComponent();

            saleComputers = this;
        }

        private void SaleComputers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerByteDataBaseDataSet4.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.computerByteDataBaseDataSet4.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerByteDataBaseDataSet3.Computers". При необходимости она может быть перемещена или удалена.
            this.computersTableAdapter.Fill(this.computerByteDataBaseDataSet3.Computers);
        }

        private void computersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (computersDataGridView[0, e.RowIndex].Value.ToString() == "")
                {
                    throw new Exception();
                }

                Monufacterer = computersDataGridView[0, e.RowIndex].Value.ToString();
                Motherboard = computersDataGridView[1, e.RowIndex].Value.ToString();
                PowerSupply = computersDataGridView[4, e.RowIndex].Value.ToString();
                VideoCard = computersDataGridView[5, e.RowIndex].Value.ToString();
                CPU = computersDataGridView[6, e.RowIndex].Value.ToString();
                OZU = computersDataGridView[2, e.RowIndex].Value.ToString();
                PZU = computersDataGridView[3, e.RowIndex].Value.ToString();
                Price = computersDataGridView[7, e.RowIndex].Value.ToString();
                Guarante = computersDataGridView[8, e.RowIndex].Value.ToString();
                
                selectCompLabel.Text = $"Выбор компьютера: {Monufacterer}";
            }
            catch (Exception)
            {
                MessageBox.Show("Нельзя выбрать!", "Внимание!");
            }
        }

        private void clientsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (clientsDataGridView[0, e.RowIndex].Value.ToString() == "")
                {
                    throw new Exception();
                }

                FIO = $"{clientsDataGridView[0, e.RowIndex].Value} {clientsDataGridView[1, e.RowIndex].Value} {clientsDataGridView[2, e.RowIndex].Value}";
                Pasport = clientsDataGridView[4, e.RowIndex].Value.ToString();
                PhoneNumber = clientsDataGridView[5, e.RowIndex].Value.ToString();
                Discount = clientsDataGridView[6, e.RowIndex].Value.ToString();

                selectClientLabel.Text = $"Выбор клиента: {FIO}";
            }
            catch (Exception)
            {
                MessageBox.Show("Нельзя выбрать!", "Внимание!");
            }
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            ColculateStatistick statistick = new ColculateStatistick();
            ToPay = int.Parse(Price) - int.Parse(Discount);
            statistick.AddSoldItem(ToPay);

            OutputToExcel outputToExcel = new OutputToExcel("ШаблонЧека");
            outputToExcel.PrintCheck(saleComputers);
        }
    }
}
