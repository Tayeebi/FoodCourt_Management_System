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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\OOP 2\FoodCourt Management System\FoodCourt.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        void populate()
        {
            con.Open();
            string query = "select * from OrdersTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrdersGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void AddToCartbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("------Your Orders Printed Succesfully--------");
        }
    }
}
