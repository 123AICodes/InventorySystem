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
    public partial class Login : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;
        string query;
        public string _pass;
        bool _isActivated;
        public string title = "Point of Sales";
        public Login()
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want close this application", title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void ckbShow3_CheckedChanged(object sender, EventArgs e)
        {
            ckbHide3.BringToFront();
            txtPass.UseSystemPasswordChar = false;
        }
        private void ckbHide3_CheckedChanged(object sender, EventArgs e)
        {
            ckbShow3.BringToFront();
            txtPass.UseSystemPasswordChar = true;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if(txtPass.Text == string.Empty)
            {
                ckbShow3.SendToBack();
                ckbHide3.SendToBack();
                txtPass.UseSystemPasswordChar = true;
            }
            else { ckbShow3.BringToFront(); }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
            try
            {
                Main main = new Main();
                string _Username = "";
                string _Fullname = "";
                string _Role = "";
                if (txtUsername.Text == string.Empty || txtPass.Text == string.Empty)
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "username or password cannot be empty!";
                    lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                    return;
                }
                else
                {
                    Cashier cashier = new Cashier();
                    bool found;
                    query = "select * from tbUser where username = @username and password = @password";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", txtUsername.Text);
                    command.Parameters.AddWithValue("@password", txtPass.Text);
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        dataReader = command.ExecuteReader();
                        dataReader.Read();
                        if (dataReader.HasRows)
                        {
                            found = true;
                            _Username = dataReader["username"].ToString();
                            _Fullname = dataReader["fullname"].ToString();
                            _Role = dataReader["role"].ToString();
                            _pass = dataReader["password"].ToString();
                            _isActivated = bool.Parse(dataReader["isactivated"].ToString());
                        }
                        else { found = false; }
                        dataReader.Close();
                        connection.Close();

                        if (found)
                        {
                            if (!_isActivated)
                            {
                                lblMsg.Visible = true;
                                lblMsg.Text = "account is deactivated!";
                                lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                                return;
                            }
                            if (_Role == "Cashier")
                            {
                                MessageBox.Show("Login Successfull. Welcome ! " + " " + _Fullname + " ", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtUsername.Clear();
                                txtPass.Clear();
                                this.Hide();
                                cashier.lblUsername.Text = _Username;
                                cashier.lblName.Text = _Fullname;
                                cashier.Show();

                                query = "SELECT photo from tbUser where username = @username";
                                command = new SqlCommand(query, connection);
                                command.Parameters.AddWithValue("@username", cashier.lblUsername.Text);
                                SqlDataAdapter sda = new SqlDataAdapter(command);
                                DataSet ds = new DataSet();
                                sda.Fill(ds);
                                connection.Open();
                                if (ds.Tables[0].Rows.Count > 0)
                                {
                                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["photo"]);
                                    cashier.picImage.Image = new Bitmap(ms);
                                }
                                connection.Close();

                            }
                            else
                            {
                                MessageBox.Show("Login Successfull. Welcome ! " + " " + _Fullname + " ", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtUsername.Clear();
                                txtPass.Clear();
                                this.Hide();
                                main.lblName.Text =  _Fullname;
                                main.lblUsername.Text =  _Username;
                                main._pass = _pass;
                                main.Show();

                                query = "SELECT photo from tbUser where username = @username";
                                command = new SqlCommand(query, connection);
                                command.Parameters.AddWithValue("@username", main.lblUsername.Text);
                                SqlDataAdapter sda = new SqlDataAdapter(command);
                                DataSet ds = new DataSet();
                                sda.Fill(ds);
                                connection.Open();
                                if (ds.Tables[0].Rows.Count > 0)
                                {
                                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["photo"]);
                                    main.picImage.Image = new Bitmap(ms);
                                }
                                connection.Close();
                            }
                        }
                        else
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = "invalid username or password!";
                            lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                lblMsg.Text = ex.Message;
                lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
            }
        }

        private void lblOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
            if (MessageBox.Show("Do you want close this application", title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }
    }
}
