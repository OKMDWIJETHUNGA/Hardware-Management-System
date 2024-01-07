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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            Con = new Functions();
            ShowCategories();
        }
        Functions Con;
        private void ShowCategories()
        {
            string Query = "select * from CategoryTbl";
            CategoriesList.DataSource = Con.GetData(Query);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    string Query = "insert into CategoryTbl values('{0}')";
                    Query = string.Format(Query, Name);
                    Con.SetData(Query);
                    ShowCategories();
                    MessageBox.Show("Category Added!!");
                    NameTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void CategoriesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = CategoriesList.SelectedRows[0].Cells[1].Value.ToString();

            if (NameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CategoriesList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    string Query = "Update  CategoryTbl set catName = '{0}' where CatCode = {1}";
                    Query = string.Format(Query, Name, Key);
                    Con.SetData(Query);
                    ShowCategories();
                    MessageBox.Show("Category Updated!!");
                    NameTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                try
                {
                    string Name = NameTb.Text;
                    string Query = "Delete from CategoryTbl where CatCode = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowCategories();
                    MessageBox.Show("Category Deleted!!");
                    NameTb.Text = "";
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
            Customer Obj = new Customer();
            Obj.Show();
            this.Hide();
        }

        private void itemLbl_Click(object sender, EventArgs e)
        {
            item Obj = new item();
            Obj.Show();
            this.Hide();
        }

        private void categoryLbl_Click(object sender, EventArgs e)
        {
            Category Obj = new Category();
            Obj.Show();
            this.Hide();
        }

        private void CustomerLbl_Click(object sender, EventArgs e)
        {
            Customer Obj = new Customer();
            Obj.Show();
            this.Hide();
        }

        private void BillLbl_Click(object sender, EventArgs e)
        {
            Billing Obj = new Billing();
            Obj.Show();
            this.Hide();
        }
    }
}
