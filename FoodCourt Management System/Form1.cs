using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace FoodCourt_Management_System
{
    public partial class Form1 : Form
    {

        public static string LoggedInUser { get; set; } = "";
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\OOP 2\FoodCourt Management System\FoodCourt.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestOrder Item = new GuestOrder();
            Item.Show();
        }

        public static string User;
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    User = unameTb.Text;

        //    if (unameTb.Text == "" || PasswordTb.Text == "")
        //    {
        //        MessageBox.Show("Please Enter Username or PassWord");
        //    }
        //    else
        //    {
        //        con.Open();
        //        SqlDataAdapter sad = new SqlDataAdapter("select count(*) from Usertb1 where Uname='" + unameTb.Text + "' and Upassword='" + PasswordTb.Text + "'", con);
        //        DataTable dt = new DataTable();
        //        sad.Fill(dt);
        //        if (dt.Rows[0][0].ToString() == "1")
        //        {
        //            UserOrder Uorder = new UserOrder();
        //            Uorder.Show();
        //            this.Hide();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Wrong Username or PassWord !");
        //        }
        //        con.Close();
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if (unameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Please Enter Username or Password");
                return;
            }

            con.Open();
            SqlDataAdapter sad = new SqlDataAdapter("SELECT COUNT(*) FROM UserTb1 WHERE Uname='" + unameTb.Text + "' AND Upassword='" + PasswordTb.Text + "'", con);
            DataTable dt = new DataTable();
            sad.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                LoggedInUser = unameTb.Text;  // ✅ Set the global username
                UserOrder Uorder = new UserOrder();
                Uorder.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Welcome to My Foodcourt!");
            }

            con.Close();
            string username = unameTb.Text.Trim();
            string password = PasswordTb.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Username and Password.");
                return;
            }

            // Hash the entered password (must match the hashing method in sign-up)
            string hashedPassword = HashPassword(password);

            try
            {


                con.Open();

                string query = "SELECT COUNT(*) FROM [User] WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", hashedPassword); // Must match the stored password

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Login Successful!");
                    // Navigate to the main application
                    UserOrder Uorder = new UserOrder();
                    Uorder.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" Welcome to my Foodcourt !");
                }

                con.Close();

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




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void unameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
