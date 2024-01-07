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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            Con = new Functions();
            ShowCustomers();
        }
        Functions Con;
        private void ShowCustomers()
        {
            string Query = "select * from CustomerTbl";
            Customerlist.DataSource = Con.GetData(Query);

        }

        int Key = 0;

        private void Customerlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = Customerlist.SelectedRows[0].Cells[1].Value.ToString();
            GenderCb.Text = Customerlist.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = Customerlist.SelectedRows[0].Cells[3].Value.ToString();

            if (NameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(Customerlist.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || GenderCb.SelectedIndex == -1 || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    string Gender = GenderCb.SelectedItem.ToString();
                    string Phone = PhoneTb.Text;
                    string Query = "Delete from CustomerTbl where CutCode = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowCustomers();
                    MessageBox.Show("Customer Deleted!!");
                    NameTb.Text = "";
                    PhoneTb.Text = "";
                    GenderCb.SelectedIndex = -1;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || GenderCb.SelectedIndex == -1 || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    string Gender = GenderCb.SelectedItem.ToString();
                    string Phone = PhoneTb.Text;
                    string Query = "insert into CustomerTbl values('{0}','{1}','{2}')";
                    Query = string.Format(Query, Name, Gender, Phone);
                    Con.SetData(Query);
                    ShowCustomers();
                    MessageBox.Show("Customer Added!!");
                    NameTb.Text = "";
                    PhoneTb.Text = "";
                    GenderCb.SelectedIndex = -1;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            if (NameTb.Text == "" || GenderCb.SelectedIndex == -1 || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    string Gender = GenderCb.SelectedItem.ToString();
                    string Phone = PhoneTb.Text;
                    string Query = "update CustomerTbl set Name = '{0}',Gender = '{1}',Phone = '{2}' where CutCode = {3}";
                    Query = string.Format(Query, Name, Gender, Phone, Key);
                    Con.SetData(Query);
                    ShowCustomers();
                    MessageBox.Show("Customer Updated!!");
                    NameTb.Text = "";
                    PhoneTb.Text = "";
                    GenderCb.SelectedIndex = -1;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void logoutLbl_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void itemLbl_Click_1(object sender, EventArgs e)
        {
            item Obj = new item();
            Obj.Show();
            this.Hide();
        }

        private void categoryLbl_Click_1(object sender, EventArgs e)
        {
            Category Obj = new Category();
            Obj.Show();
            this.Hide();
        }

        private void CustomerLbl_Click_1(object sender, EventArgs e)
        {
            Customer Obj = new Customer();
            Obj.Show();
            this.Hide();
        }

        private void BillLbl_Click_1(object sender, EventArgs e)
        {
            Billing Obj = new Billing();
            Obj.Show();
            this.Hide();
        }

       
    }
}
