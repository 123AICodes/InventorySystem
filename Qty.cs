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
    public partial class Qty : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;
        string query;
        string title = "Point Of Sales";
        private double price;
        private String transno;
        private int qty;
        int _qty;
        public Qty()
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

        }
    }
}
