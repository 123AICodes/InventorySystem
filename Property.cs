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
    public partial class Property : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        string title = "Point Of Sales";

        Users users;
        public Property(Users use)
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            users = use;
            lblHeading.Text = users.lblUN.Text + "`s" + " Account Properties";
            txtUsername.Text = users.lblUN.Text;
            txtFullname.Text = users.lblFN.Text;
            cmbRole.Text = users.lblRL.Text;
            cmbStatus.Text = users.lblST.Text;
            lblID.Text = users.lblID.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAppy_Click(object sender, EventArgs e)
        {
            if(txtFullname.Text == string.Empty || txtUsername.Text == string.Empty || cmbRole.Text == "" || cmbStatus.Text == "")
            {
                lblMsg.Visible = true;
                lblMsg.Text = "fill in the blank spaces!";
                lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                return;
            }
            else
            {
                dbcon.executeQuery("Update tbUser set fullname = '" + txtFullname.Text + "', role = '" + cmbRole.Text + "', isactivated = '" + cmbStatus.Text + "' where id = '" + lblID.Text + "'");
                MessageBox.Show(txtUsername.Text + "'s " + " record is updated successfully", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                users.fetchData();
            }
        }
    }
}
