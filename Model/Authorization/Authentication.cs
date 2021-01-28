using System.Data.OleDb;
using System.Windows.Forms;

namespace AIS_ComputerBYTE
{
    class Authentication : BaseConection
    {
        private string loadLogin;
        private int lvlAccses;

        public Authentication(string login, string password)
            : base(login, password) { }

        public void Execute()
        {
            OleDbConnect.Open();

            string query = $"SELECT * FROM Employees WHERE Логин = '{Login}' AND Пароль = '{Password}'";
            OleDbCommand command = new OleDbCommand(query, OleDbConnect);

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                loadLogin = reader.GetString(1);
                Position = reader.GetString(3);
                FullName = reader.GetString(4);
                lvlAccses = reader.GetInt32(8);
            }

            OleDbConnect.Close();
            reader.Close();
        }

        public void RunAuthentication()
        {
            if (Login != null && Login == loadLogin)
            {
                MainMenuForm cinema = new MainMenuForm(Login, FullName, Position, lvlAccses);
                cinema.Show();
            }
            else
            {
                MessageBox.Show("Аккаунт не зарегистрирован!", "Внимание!");
            }
        }
    }
}
