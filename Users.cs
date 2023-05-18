using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewInventory
{
    public partial class Users : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;
        string query;
        string title = "Point Of Sales";
        Main main;
        public string username, name, role, status;

        public Users(Main mn)
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            fetchData();
            main = mn;
            lblName.Text = main.lblUsername.Text;
            labelName.Text = main.lblUsername.Text;
            btnChange.Visible = false;
            btnResetPass.Visible = false;
            gbUserAccount.Text = "User Password";
            lblNote.Text = "Click on reset password to change user password";
        }

        #region checkBoxes && PassTB
        private void ckbShow1_CheckedChanged(object sender, EventArgs e)
        {
            ckbHide1.BringToFront();
            txtOldPass.UseSystemPasswordChar = false;
        }

        private void ckbHide1_CheckedChanged(object sender, EventArgs e)
        {
            ckbShow1.BringToFront();
            txtOldPass.UseSystemPasswordChar = true;
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {
            if (txtOldPass.Text == string.Empty)
            {
                ckbShow1.SendToBack();
                ckbHide1.SendToBack();
                txtOldPass.UseSystemPasswordChar = true;
            }
            else { ckbShow1.BringToFront(); }
        }

        private void ckbShow2_CheckedChanged(object sender, EventArgs e)
        {
            ckbHide2.BringToFront();
            txtNewPass.UseSystemPasswordChar = false;
        }

        private void ckbHide2_CheckedChanged(object sender, EventArgs e)
        {
            ckbShow2.BringToFront();
            txtNewPass.UseSystemPasswordChar = true;
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPass.Text == string.Empty)
            {
                ckbShow2.SendToBack();
                ckbHide2.SendToBack();
                txtNewPass.UseSystemPasswordChar = true;
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
        #endregion checkBoxes && PassTB
        /*fetching data from database*/
        public void fetchData()
        {
            try
            {
                int i = 0;
                dgvUsers.Rows.Clear();
                dgvUserAccount.Rows.Clear();
                query = "SELECT * FROM tbUser WHERE CONCAT(username, fullname, role, email, residence, gender, phone) LIKE '%" + txtSearch.Text + "%' ORDER BY role";
                command = new SqlCommand(query, connection);
                connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    i++;
                    dgvUsers.Rows.Add(i, dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString(), dataReader[6].ToString(), dataReader[7].ToString(), dataReader[8].ToString(), dataReader[9].ToString(), dataReader[10].ToString(), Convert.ToDateTime(dataReader[11].ToString()).ToShortDateString());
                    dgvUserAccount.Rows.Add(i, dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString(), dataReader[6].ToString(), dataReader[7].ToString(), dataReader[8].ToString(), dataReader[9].ToString(), dataReader[10].ToString(), Convert.ToDateTime(dataReader[11].ToString()).ToShortDateString());
                }
                dataReader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserModule user = new UserModule(this);
            user.Show();
        }
        public void clearFields()
        {
            txtOldPass.Clear();
            txtNewPass.Clear();
            txtConfirmPass.Clear();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            fetchData();
        }
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgvUsers.Columns[e.ColumnIndex].Name;
                UserModule user = new UserModule(this);

                if(colName == "Edit")
                {
                    user.lblId.Text = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                    user.txtUsername.Text = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                    user.txtPass.Text = dgvUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                    user.txtFullName.Text = dgvUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                    user.cmbRole.Text = dgvUsers.Rows[e.RowIndex].Cells[5].Value.ToString();
                    user.cmbGender.Text = dgvUsers.Rows[e.RowIndex].Cells[6].Value.ToString();
                    user.txtResidence.Text = dgvUsers.Rows[e.RowIndex].Cells[7].Value.ToString();
                    user.txtEmail.Text = dgvUsers.Rows[e.RowIndex].Cells[8].Value.ToString();
                    user.txtPhone.Text = dgvUsers.Rows[e.RowIndex].Cells[9].Value.ToString();

                    query = "SELECT photo from tbUser where id = '"+user.lblId.Text+"'";
                    command = new SqlCommand(query, connection);
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    if(connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["photo"]);
                            user.picUpload.Image = new Bitmap(ms);
                            //picImage.Image = new Bitmap(ms);
                        }
                        connection.Close();
                    }
                   

                    user.txtPass.Enabled = false;
                    user.txtPass.BackColor = Color.White;
                    user.cmbRole.Enabled = false; 
                    user.cmbRole.BackColor = Color.White;
                    user.btnAdd.Visible = false;
                    user.btnUpdate.Visible = true;

                    user.lblUser.Text = "Details of " + dgvUsers.Rows[e.RowIndex].Cells[4].Value.ToString() + " | " + dgvUsers.Rows[e.RowIndex].Cells[5].Value.ToString();
                    user.Show();
                }
                else if(colName == "Delete")
                {
                    if (MessageBox.Show("Do you want to delete this user", title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        dbcon.executeQuery("DELETE FROM tbUser WHERE id = '" + dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                        MessageBox.Show("User Deleted Successfully", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fetchData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == string.Empty)
            {
                lblMsg.Visible = true;
                lblMsg.Text = "password field is required!";
                lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                txtOldPass.Focus();
                return;

            }
            if (txtOldPass.Text != main._pass)
            {
                lblMsg.Visible = true;
                lblMsg.Text = "the password you entered is incorrect!";
                lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                txtOldPass.Focus();
                return;
            }
            else
            {
                lblMsg.Visible = false;
                btnChange.Visible = true;
                txtNewPass.Visible = true;
                txtNewPass.BringToFront();
                lblNP.Visible = true;
                txtConfirmPass.Visible = true;
                lblCP.Visible = true;

                ckbShow2.Visible = true;
                ckbHide2.Visible = true;

                 ckbShow3.Visible = true;
                ckbHide3.Visible = true;


                btnNext.Visible = false;
                txtOldPass.Visible = false;
                lblOP.Visible = false;

            }
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == string.Empty || txtConfirmPass.Text == string.Empty)
            {
                lblMsg.Visible = true;
                lblMsg.Text = "password field cannot be empty!";
                lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                txtNewPass.Focus();
                return;
            }
            if (txtNewPass.Text != txtConfirmPass.Text)
            {
                lblMsg.Visible = true;
                lblMsg.Text = "confirm password didn`t match!";
                lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                txtNewPass.Focus();
                return;
            }
            else
            {
                dbcon.executeQuery("update tbUser set password = '" + txtConfirmPass.Text + "' where username = '" + lblName.Text + "' and role like 'Administrator'");
                lblMsg.Visible = true;
                lblMsg.Text = "password was successfully changed!";
                lblMsg.ForeColor = Color.FromArgb(27, 168, 224);
                txtNewPass.Focus();
                txtNewPass.Clear();
                txtConfirmPass.Clear();
            }
            fetchData();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            fetchData();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            fetchData();
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            Property property = new Property(this);
            property.Show();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            ResetPassword reset = new ResetPassword(this);
            reset.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
            lblMsg.Visible = false;
        }
        private void dgvUserAccount_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvUserAccount.CurrentRow.Index;
            username = dgvUserAccount[1, i].Value.ToString();
            name = dgvUserAccount[3, i].Value.ToString();
            role = dgvUserAccount[2, i].Value.ToString();
            status = dgvUserAccount[4, i].Value.ToString();

            if (labelName.Text == role)
            {
                btnResetPass.Visible = false;
                btnProperties.Visible = true;
                gbUserAccount.Text = "User Password";
                lblNote.Text = "Click on reset password to change user password";
            }
            else
            {
                btnResetPass.Visible = true;
                btnProperties.Visible = true;
                gbUserAccount.Text = "Password for " + role;
                lblNote.Text = lblName.Text + ", To change the password for " + role + ". Click on reset password";
            }
        }
        private void dgvUserAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblID.Text = dgvUserAccount.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblUN.Text = dgvUserAccount.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblFN.Text = dgvUserAccount.Rows[e.RowIndex].Cells[4].Value.ToString();
                lblRL.Text = dgvUserAccount.Rows[e.RowIndex].Cells[5].Value.ToString();
                lblST.Text = dgvUserAccount.Rows[e.RowIndex].Cells[11].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
