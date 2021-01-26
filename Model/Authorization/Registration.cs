using System.Data.OleDb;

namespace AIS_ComputerBYTE
{
    class Registration : BaseConection
    {
        public Registration(string login, string password, string fullName, string position)
            : base(login, password, fullName, position) { }

        public void Execute(int pasportNumber, int age, string adres, int accsesLevel, int expiriance, string education)
        {
            string cmdText = $"INSERT INTO Employees ([Логин], [Пароль], [Должность], [Полное имя], [Номер паспорта], [Возраст], [Адрес], [Уровень доступа], [Стаж], [Образование]) " +
                $"VALUES ('" + Login + "'," +
                " '" + Password + "'," +
                " '" + Position + "'," +
                " '" + FullName + "'," +
                " '" + pasportNumber + "'," +
                " '" + age + "'," +
                " '" + adres + "'," +
                " '" + accsesLevel + "'," +
                " '" + expiriance + "'," +
                " '" + education + "')";
            OleDbCommand cmd = new OleDbCommand(cmdText, OleDbConnect);

            OleDbConnect.Open();
            cmd.ExecuteNonQuery();
            OleDbConnect.Close();
        }
    }
}
