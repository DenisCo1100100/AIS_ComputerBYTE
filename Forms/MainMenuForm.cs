﻿using System;
using System.Windows.Forms;

namespace AIS_ComputerBYTE
{
    public partial class MainMenuForm : Form
    {
        private string Login { get; set; }
        private string FullName { get; set; }
        private string Positions { get; set; }
        private int LvlAccses { get; set; }

        public MainMenuForm(string login, string fullName, string position, int lvlAccses)
        {
            InitializeComponent();

            Login = login;
            FullName = fullName;
            Positions = position;
            LvlAccses = lvlAccses;

            FillUserDate();
            ProvidingAccses();
        }

        private void FillUserDate()
        {
            groupBox1.Text = Login;

            string[] fullNameSplit = FullName.Split();
            userNameLable.Text = $"Фамилия: {fullNameSplit[0]}\n" +
                $"Имя: {fullNameSplit[1]}\n" +
                $"Отчество: {fullNameSplit[2]}\n" +
                $"Должность: {Positions}";
        }

        private void ProvidingAccses()
        {
            if (LvlAccses == 2)
            {
                registrationButton.Visible = false;
            }
        }

        private void changeEmployee_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
