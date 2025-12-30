using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FoodCourt_Management_System
{
    public partial class UserOrder : Form
    {
        public UserOrder()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\OOP 2\FoodCourt Management System\FoodCourt.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        void populate()
        {
            con.Open();
            string query = "select * from ItemTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemGV.DataSource = ds.Tables[0];
            con.Close();
        }

        void Filterbycategory()
        {
            con.Open();
            string query = "select * from ItemTb1 where Itemcat ='" + CatCb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Login = new Form1();
            Login.Show();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm Item = new ItemsForm();
            Item.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm uform = new UserForm();
            uform.Show();
        }

        DataTable table1 = new DataTable();
        int flag = 0;
        int sum = 0;

        private void UserOrder_Load(object sender, EventArgs e)
        {
            populate();
            table1.Columns.Add("Num", typeof(int));
            table1.Columns.Add("Item", typeof(String));
            table1.Columns.Add("Category", typeof(String));
            table1.Columns.Add("UnitPrice", typeof(int));
            table1.Columns.Add("Total", typeof(int));
            OrderGV.DataSource = table1;
            Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            SellerNameTb.Text = Form1.User;
        }

        int num = 0;
        int total, price, qty;
        string item, cat;
        private void ItemGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ItemGV.Rows[e.RowIndex];

                // Retrieve values from the cells
                Name = selectedRow.Cells[0].Value?.ToString() ?? "";
                cat = selectedRow.Cells[1].Value?.ToString() ?? "";

                // Correctly retrieve price from column 3
                if (int.TryParse(selectedRow.Cells[3].Value?.ToString(), out int parsedPrice))
                {
                    price = parsedPrice;
                }
                else
                {
                    price = 0; // Default or fallback value for invalid price
                }

                flag = 1; // Set the flag if a row is selected
            }
            else
            {
                Name = "";
                cat = "";
                price = 0; // Reset price
                flag = 0;  // Reset the flag
            }
        }


       

        private void AddToCartbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(QtyTb.Text))
            {
                MessageBox.Show("What is the quantity?");
                return;
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the order to be ordered");
                return;
            }

            num++;

            if (!int.TryParse(QtyTb.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid numeric quantity.");
                return;
            }

            total = price * quantity;
            table1.Rows.Add(num, item, cat, price, total);
            OrderGV.DataSource = table1;
            flag = 0;

            // Store numeric sum in OrderAmtlbl.Tag
            sum += total;
            OrderAmtlbl.Tag = sum;  // Store actual number
            OrderAmtlbl.Text = $"TK : {sum}";  // Display formatted text
        }



        private void OrderAmtlbl_Click(object sender, EventArgs e)
        {

        }

        private void CatCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filterbycategory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }

      

        private void PlaceOrderBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            // Debugging step: Show the actual value of OrderAmtlbl.Text
            MessageBox.Show($"OrderAmtlbl.Text: {OrderAmtlbl.Text}");

            // Ensure "TK : " is removed and only the number remains
            string amountText = OrderAmtlbl.Text.Replace("TK :", "").Trim();

            if (!decimal.TryParse(amountText, out decimal orderAmount))
            {
                MessageBox.Show($"Invalid order amount format: {amountText}");
                con.Close();
                return;
            }

            string query = $"INSERT INTO OrdersTb1 VALUES({OrderNumTb.Text}, '{Datelbl.Text}', '{SellerNameTb.Text}', {orderAmount})";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Order Successfully Created");

            con.Close();
        }




        private void button3_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }
    }
}
