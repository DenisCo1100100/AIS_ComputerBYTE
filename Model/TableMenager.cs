using System.Data.OleDb;

namespace AIS_ComputerBYTE
{
    class TableMenager
    {
        private OleDbConnection OleDbConnect { get; set; }

        public TableMenager()
        {
            string strConnection = $@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = ComputerByteDataBase.mdb";
            OleDbConnect = new OleDbConnection(strConnection);
        }

        public void ExecuteRequest(string request)
        {
            OleDbCommand cmd = new OleDbCommand(request, OleDbConnect);

            OleDbConnect.Open();
            cmd.ExecuteNonQuery();
            OleDbConnect.Close();
        }

        public string[] SelectInDB(string request)
        {
            OleDbConnect.Open();
            OleDbCommand cmd = new OleDbCommand(request, OleDbConnect);
            OleDbDataReader reader = cmd.ExecuteReader();

            string[] getsStat = new string[reader.FieldCount];
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    getsStat[i] = reader.GetValue(i).ToString();
                }
            }

            OleDbConnect.Close();
            return getsStat;
        }
    }
}
