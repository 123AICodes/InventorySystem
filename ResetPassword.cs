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
    public partial class ResetPassword : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;
        string query;
        string title = "Point Of Sales";

        Users users;
        public ResetPassword(Users use)
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            users = use;
            lblID.Text = users.lblID.Text;
            lblHeading.Text = "Reset " + users.lblUN.Text + "`s" + " Password";

        }

        private void ckbShow2_CheckedChanged(object sender, EventArgs e)
        {
            ckbHide2.BringToFront();
            txtPass.UseSystemPasswordChar = false;
        }

        private void ckbHide2_CheckedChanged(object sender, EventArgs e)
        {
            ckbShow2.BringToFront();
            txtPass.UseSystemPasswordChar = true;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == string.Empty)
            {
                ckbShow2.SendToBack();
                ckbHide2.SendToBack();
                txtPass.UseSystemPasswordChar = true;
            }
            else { ckbShow2.BringToFront(); }
        }

        private void ckbShow3_CheckedChanged(object sender, EventArgs e)
        {
            ckbHide3.BringToFront();
            txtConfirmPass.UseSystemPasswordChar = false;
        }

        private void ckbHide3_CheckedChanged(object sender, EventArgs e)
        {
            ckbShow3.BringToFront();
            txtConfirmPass.UseSystemPasswordChar = true;
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text == string.Empty)
            {
                ckbShow3.SendToBack();
                ckbHide3.SendToBack();
                txtConfirmPass.UseSystemPasswordChar = true;
            }
            else { ckbShow3.BringToFront(); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(txtPass.Text == string.Empty || txtConfirmPass.Text == string.Empty)
            {
                lblMsg.Visible = true;
                lblMsg.Text = "password field is required!";
                lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                txtPass.Focus();
                return;
            }
            if(txtPass.Text != txtConfirmPass.Text)
            {
                lblMsg.Visible = true;
                lblMsg.Text = "confirm password did not match!";
                lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                return;
            }
            else
            {
                dbcon.executeQuery("update tbUser set password = '" + txtConfirmPass.Text + "' where id = '" + lblID.Text + "'");
                MessageBox.Show(users.lblUN.Text + "'s " + " password changed successfully", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                users.fetchData();
            }
        }
    }
}
