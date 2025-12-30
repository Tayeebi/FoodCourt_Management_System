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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\OOP 2\FoodCourt Management System\FoodCourt.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        

        private void populate()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close(); // Close the connection if it's already open
                }

                con.Open(); // Open a fresh connection

                string query = "SELECT * FROM UserTb1";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                UsersGV.DataSource = dt;
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



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
            ItemsForm item = new ItemsForm();
            item.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Login = new Form1();
            Login.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into UserTb1 values('" + unameTb.Text + "','" + uphoneTb.Text + "','" + upassTb.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Customer Seccesfully Created");
            con.Close();
            populate();
            reset();

        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = UsersGV.Rows[e.RowIndex];

                // Retrieve values from the cells
                unameTb.Text = selectedRow.Cells[0].Value?.ToString();
                uphoneTb.Text = selectedRow.Cells[1].Value?.ToString();
                upassTb.Text = selectedRow.Cells[2].Value?.ToString();
            }
            else
            {
                unameTb.Text = "";
                uphoneTb.Text = "";
                upassTb.Text = "";
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            populate();
        }

    
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Ensure connection string is properly defined
            string query = "DELETE FROM Usertb1 WHERE Uphone = @Uphone";

            
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Use parameterized query to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Uphone", uphoneTb.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer Successfully Deleted");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given phone number.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            

            // Refresh data and reset fields
            populate();
            reset();
        }


        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(unameTb.Text) ||
                string.IsNullOrWhiteSpace(uphoneTb.Text) ||
                string.IsNullOrWhiteSpace(upassTb.Text))
            {
                MessageBox.Show("Fill all the fields");
                return;
            }

            try
            {
                con.Open();
                string query = "UPDATE UserTb1 SET Uname = @Uname, Upassword = @Upassword WHERE Uphone = @Uphone";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Uname", unameTb.Text);
                    cmd.Parameters.AddWithValue("@Upassword", upassTb.Text);
                    cmd.Parameters.AddWithValue("@Uphone", uphoneTb.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item successfully updated");
                        populate();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("No matching record found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void reset()
        {
            unameTb.Text = "";
            upassTb.Text = "";
            uphoneTb.Text = "";
        }
    }
}
