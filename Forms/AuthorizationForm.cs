using System;
using System.Windows.Forms;

namespace AIS_ComputerBYTE
{
    public partial class AuthorizationForm : Form
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            Login = loginTextBox.Text;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            Password = passwordTextBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Authentication authentication = new Authentication(Login, Password);
            Authentication authentication = new Authentication("Admin2", "2222");
            authentication.Execute();
            authentication.RunAuthentication();
        }
    }
}