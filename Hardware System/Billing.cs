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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            Con = new Functions();
            ShowItems();
            ShowPrintBill();
            
           
        }
        Functions Con;
        private void ShowItems()
        {
            string Query = "select * from ItemTbl";
            Itemlist.DataSource = Con.GetData(Query);
        }
        private void ShowPrintBill() 
        {
            string Query = "select * from PrintBillTbl";
            ClientBill.DataSource = Con.GetData(Query);
        }
        private void UpdateStock()
        {
            try
            {
                int NewStock = Stock - Convert.ToInt32(QtyTb.Text);
                string Query = "Update ItemTbl set ItStock = {0} where ItCode = {1})";
                Query = string.Format(Query, NewStock, Key);
                Con.SetData(Query);
                ShowItems();
                MessageBox.Show("Stock Updated!!");

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int Key = 0;
        int Stock;
        int total;

        private void Itemlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = Itemlist.SelectedRows[0].Cells[1].Value.ToString();
            PriceTb.Text = Itemlist.SelectedRows[0].Cells[3].Value.ToString();
            Stock = Convert.ToInt32(Itemlist.SelectedRows[0].Cells[5].Value.ToString());       

            if (NameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(Itemlist.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        string PMethod = "";       
        int GrdTotal = 0;

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (CustTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                try
                {
                    if (MobileRadio.Checked == true)
                    {
                        PMethod = "Mobile";
                    }
                    else if (CardRadio.Checked == true)
                    {
                        PMethod = "Card";
                    }
                    else
                    {
                        PMethod = "Cash";
                    }
                    string Name = CustTb.Text;
                    string Query = "insert into BillTbl values('{0}','{1}','{2}')";
                    Query = string.Format(Query, Name, GrdTotal, PMethod);
                    Con.SetData(Query);
                    ShowItems();
                    MessageBox.Show("Bill Printed!!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            PriceTb.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(PriceTb.Text == "" ||QtyTb.Text == "" ||NameTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else if (Stock < Convert.ToInt32(QtyTb.Text))
            {
                MessageBox.Show("Not Enough Stock!!");
            }
            else
            {
                try
                {
                    int Qte = Convert.ToInt32(QtyTb.Text);
                    total = Convert.ToInt32(PriceTb.Text) * Qte;

                    string Name = NameTb.Text;
                    string Price = PriceTb.Text;
                    string Qty = QtyTb.Text;
                    string Query = "insert into PrintBillTbl values('{0}','{1}','{2}','{3}')";
                    Query = string.Format(Query, Name, Price, Qty, total);
                    Con.SetData(Query);                  
                    MessageBox.Show("Bill Added!!");
                    NameTb.Text = "";
                    PriceTb.Text = "";
                    QtyTb.Text = "";                    
                    ShowItems();                                
                    ShowPrintBill();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                                                                      
            }
            
            GrdTotal = GrdTotal + total;
            GdrTotalLbl.Text = "Rs " + GrdTotal;
            UpdateStock();
            ShowItems();
        }


        private void Billing_Load(object sender, EventArgs e)
        {

        }

        private void logoutLbl_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            item Obj = new item();
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

        private void ClientBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = ClientBill.SelectedRows[0].Cells[1].Value.ToString();
            PriceTb.Text = ClientBill.SelectedRows[0].Cells[2].Value.ToString();
            QtyTb.Text = ClientBill.SelectedRows[0].Cells[3].Value.ToString();
            total = Convert.ToInt32(ClientBill.SelectedRows[0].Cells[4].Value.ToString());
            
            if (NameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(Itemlist.SelectedRows[0].Cells[0].Value.ToString());
            }
                      
        }

       
    }
}
