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

        public int[] SelectInDB(string request)
        {
            OleDbConnect.Open();
            OleDbCommand cmd = new OleDbCommand(request, OleDbConnect);
            OleDbDataReader reader = cmd.ExecuteReader();

            int[] getsStat = new int[reader.FieldCount];
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    getsStat[i] = reader.GetInt32(i);
                }
            }

            OleDbConnect.Close();
            return getsStat;
        }
    }
}
