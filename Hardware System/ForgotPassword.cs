using System;
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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void RestBtn_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || NewpasswordTb.Text == "" || conformTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else if (UNameTb.Text == "Admin" && NewpasswordTb.Text == conformTb.Text)
            {
                MessageBox.Show("Password Updated!!");

                Login Obj = new Login();
                Obj.Show();
                this.Hide();

            }
            else 
            {
                MessageBox.Show("Wrong username or Doesn't match enter new password!!");
            }
        }
    }
}
