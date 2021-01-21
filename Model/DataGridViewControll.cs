using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AIS_ComputerBYTE
{
    class DataGridViewControll
    {
        private OleDbDataAdapter adapter;
        private DataTable dataTable;
        private OleDbConnection connection;

        public DataGridViewControll()
        {
            adapter = new OleDbDataAdapter();
            dataTable = new DataTable();
            connection = new OleDbConnection($@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = ComputerByteDataBase.mdb");
        }

        public void Update(DataGridView dataGridView, string tableName)
        {
            DataSet dataSet = new DataSet();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = $"Select * from {tableName}";
            connection.Open();
            adapter.SelectCommand = command;
            adapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];
            dataGridView.DataSource = dataTable;
            connection.Close();
        }
    }
}
