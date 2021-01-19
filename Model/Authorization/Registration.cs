using System.Data.OleDb;

namespace AIS_ComputerBYTE
{
    class Registration : BaseConection
    {
        public Registration(string login, string password, string fullName, string position)
            : base(login, password, fullName, position) { }

        public void Execute(int pasportNumber, int age, string adres, int accsesLevel)
        {
            string cmdText = $"INSERT INTO Employees ([Логин], [Пароль], [Должность], [Полное имя], [Номер паспорта], [Возраст], [Адрес], [Уровень доступа]) VALUES ('" + Login + "', '" + Password + "', '" + Position + "', '" + FullName + "', '" + pasportNumber + "', '" + age + "','" + adres + "','" + accsesLevel + "')";
            OleDbCommand cmd = new OleDbCommand(cmdText, OleDbConnect);

            OleDbConnect.Open();
            cmd.ExecuteNonQuery();
            OleDbConnect.Close();
        }
    }
}
