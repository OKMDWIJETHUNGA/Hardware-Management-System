﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");

            }
            else if (UNameTb.Text == "Admin" && PasswordTb.Text == "Admin")
            {
                Customer Obj = new Customer();
                Obj.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }

        private void ForgotLbl_Click(object sender, EventArgs e)
        {
            ForgotPassword Obj = new ForgotPassword();
            Obj.Show();
            this.Hide();
        }
    }
}
