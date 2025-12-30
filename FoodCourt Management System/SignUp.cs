using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodCourt_Management_System
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {

            // Retrieve input values
            string userId = UidTb.Text.Trim();
            string username = unameTb.Text.Trim();
            string password = PasswordTb.Text.Trim();
            string email = EmailTb.Text.Trim();
            string firstName = FirstnameTb.Text.Trim();
            string lastName = LastnameTb.Text.Trim();

            // Input validation
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

           
            string hashedPassword = HashPassword(password);

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"F:\\OOP 2\\FoodCourt Management System\\FoodCourt.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=True"))
                {
                    con.Open();

                    // Check if the UserId or Username already exists
                    string checkQuery = "SELECT COUNT(*) FROM [User] WHERE UserId = @UserId OR Username = @Username OR Email = @Email";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@UserId", userId);
                    checkCmd.Parameters.AddWithValue("@Username", username);
                    checkCmd.Parameters.AddWithValue("@Email", email);

                    int userExists = (int)checkCmd.ExecuteScalar();
                    if (userExists > 0)
                    {
                        MessageBox.Show("User ID, Username, or Email already exists. Please choose another.");
                        con.Close();
                        return;
                    }

                    // Insert new user
                    string insertQuery = "SET IDENTITY_INSERT [User] ON; " +
                     "INSERT INTO [User] (UserId, Username, Password, Email, FirstName, LastName) " +
                     "VALUES (@UserId, @Username, @Password, @Email, @FirstName, @LastName); " +
                     "SET IDENTITY_INSERT [User] OFF;";
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sign-up successful!");

                    con.Close();

                    // Redirect to login page
                    this.Hide();
                    Form1 Login = new Form1();
                    Login.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Hash password using SHA256
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        private void BackloginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Login = new Form1();
            Login.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

