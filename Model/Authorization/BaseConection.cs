using System.Data.OleDb;

namespace AIS_ComputerBYTE
{
    abstract class BaseConection
    {
        internal string Login { get; set; }
        internal string Password { get; set; }
        internal string FullName { get; set; }
        internal string Position { get; set; }
        internal OleDbConnection OleDbConnect { get; set; }

        public BaseConection(string login, string password, string fullName = null, string position = null)
        {
            Login = login;
            Password = password;
            FullName = fullName;
            Position = position;

            string StrConnection = $"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = ComputerByteDataBase.mdb";
            OleDbConnect = new OleDbConnection(StrConnection);
        }
    }
}
