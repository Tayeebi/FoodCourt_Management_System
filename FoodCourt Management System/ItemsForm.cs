using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodCourt_Management_System
{
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\OOP 2\FoodCourt Management System\FoodCourt.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        //void populate()
        //{
        //    con.Open();
        //    string query = "select * from ItemTb1";
        //    SqlDataAdapter sda = new SqlDataAdapter(query, con);
        //    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
        //    var ds = new DataSet();
        //    sda.Fill(ds);
        //    ItemGV.DataSource = ds.Tables[0];
        //    con.Close();
        //}

        private void populate()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close(); // Close the connection if it's already open
                }

                con.Open(); // Open a fresh connection

                string query = "SELECT * FROM ItemTb1";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ItemGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close(); // Ensure the connection is always closed
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Login = new Form1();
            Login.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder uorder = new UserOrder();
            uorder.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm user = new UserForm();
            user.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection
                con.Open();

                // Use parameterized query to prevent SQL Injection
                string query = "INSERT INTO Itemtb1 (ItemName, ItemNum, Itemcat, ItemPrice) VALUES (@ItemName, @ItemNum, @ItemCat, @ItemPrice)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Adding parameters safely
                    cmd.Parameters.AddWithValue("@ItemName", ItemNameTb.Text);
                    cmd.Parameters.AddWithValue("@ItemNum", ItemNumTb.Text);
                    cmd.Parameters.AddWithValue("@ItemCat", CatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ItemPrice", ItemPriceTb.Text);

                    // Execute query
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Item Successfully Entered");

                // Refresh data and reset fields
                populate();
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Ensure connection is closed properly
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void ItemGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ItemGV.Rows[e.RowIndex];

                // Retrieve values from the cells
                ItemNumTb.Text = selectedRow.Cells[0].Value?.ToString();
                ItemNameTb.Text = selectedRow.Cells[1].Value?.ToString();
                CatCb.SelectedItem = selectedRow.Cells[2].Value?.ToString();
                ItemPriceTb.Text = selectedRow.Cells[3].Value?.ToString();

            }
            else
            {
                ItemNumTb.Text = "";
                ItemNameTb.Text = "";
                CatCb.SelectedItem = "";
                ItemPriceTb.Text = "";
            }
        }

        //private void DeleteBtn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        con.Open();
        //        string query = "Deleted from Itemtb1 where ItemNum = '" + ItemNumTb.Text + "'";
        //        SqlCommand cmd = new SqlCommand(query, con);
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Item Succesfully Deleted");
        //        con.Close();
        //        populate();
        //        reset();
        //    }
        //    catch (Exception Ex)
        //    {
        //        MessageBox.Show(Ex.Message);
        //    }
        //}

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ItemNumTb.Text))
            {
                MessageBox.Show("Please enter an Item Number to delete.");
                return;
            }

            try
            {
                // Ensure connection is open only if needed
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string query = "DELETE FROM Itemtb1 WHERE ItemNum = @ItemNum";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Use parameterized queries to prevent SQL Injection
                    cmd.Parameters.AddWithValue("@ItemNum", int.Parse(ItemNumTb.Text));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item successfully deleted.");
                    }
                    else
                    {
                        MessageBox.Show("No item found with the given number.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection if it's open
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            populate();
            reset();
        }


        //private void EditBtn_Click(object sender, EventArgs e)
        //{
        //    if (ItemNumTb.Text == "" || ItemNameTb.Text == "" || ItemPriceTb.Text == "")
        //    {
        //        MessageBox.Show("Fill all the data");
        //    }
        //    else
        //    {
        //        con.Open();
        //        string query = "update ItemTb1 set ItemName= '" + ItemNameTb.Text + "',ItemCat='" + CatCb.SelectedItem.ToString() + "'ItemPrice= " + ItemPriceTb.Text + "where ItemNum ="+ItemNumTb.Text+"";
        //        SqlCommand cmd = new SqlCommand(query, con);
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Item successfully updated");
        //        con.Close();
        //        populate();
        //        reset();
        //    }
        //}

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ItemNumTb.Text) ||
                string.IsNullOrWhiteSpace(ItemNameTb.Text) ||
                string.IsNullOrWhiteSpace(ItemPriceTb.Text))
            {
                MessageBox.Show("Fill all the data");
                return;
            }

            try
            {
                // Open the connection only if it's not already open
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string query = "UPDATE ItemTb1 SET ItemName = @ItemName, ItemCat = @ItemCat, [ItemPrice] = @ItemPrice WHERE ItemNum = @ItemNum";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Using parameters to prevent SQL Injection
                    cmd.Parameters.AddWithValue("@ItemName", ItemNameTb.Text);
                    cmd.Parameters.AddWithValue("@ItemCat", CatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ItemPrice", decimal.Parse(ItemPriceTb.Text)); // Convert price to decimal
                    cmd.Parameters.AddWithValue("@ItemNum", int.Parse(ItemNumTb.Text)); // Convert item number to integer

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item successfully updated");
                    }
                    else
                    {
                        MessageBox.Show("No item found with the given number");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection only if it's still open
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            populate();
            reset();
        }


        public void reset()
        {
            ItemNumTb.Text = "";
            ItemNameTb.Text = "";
            CatCb.SelectedItem = "";
            ItemPriceTb.Text = "";
        }
    }
}
