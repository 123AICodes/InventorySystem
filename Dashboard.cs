using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewInventory
{
    public partial class Dashboard : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        //SqlDataReader dataReader;

        public Dashboard()
        {
            InitializeComponent();
            timer1.Start();
            connection = new SqlConnection(dbcon.myConnection());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblProduct.Text = dbcon.ExtractDate("select count(*) from tbProduct").ToString("#,##0");
            lblBrand.Text = dbcon.ExtractDate("select count(*) from tbBrand").ToString("#,##0");
            lblCategory.Text = dbcon.ExtractDate("select count(*) from tbCategory").ToString("#,##0");
            lblCustomer.Text = dbcon.ExtractDate("select count(*) from tbCustomer").ToString("#,##0");
            lblUsers.Text = dbcon.ExtractDate("select count(*) from tbUser").ToString("#,##0");

        }
    }
}
