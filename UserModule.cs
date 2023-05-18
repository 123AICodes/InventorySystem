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
using System.IO;

namespace NewInventory
{
    public partial class UserModule : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        string query, selectQuery;

        Users user;
        public UserModule(Users use)
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            user = use;
        }
        private void ckbShow_CheckedChanged(object sender, EventArgs e)
        {
            ckbHide.BringToFront();
            txtPass.UseSystemPasswordChar = false;
        }
        private void ckbHide_CheckedChanged(object sender, EventArgs e)
        {
            ckbShow.BringToFront();
            txtPass.UseSystemPasswordChar = true;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == string.Empty)
            {
                ckbShow.SendToBack();
                ckbHide.SendToBack();
                txtPass.UseSystemPasswordChar = true;
            }
            else { ckbShow.BringToFront(); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void clearFields()
        {
            txtUsername.Clear();
            txtPass.Clear();
            txtFullName.Clear();
            cmbRole.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            txtResidence.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            picUpload.Image = null;
        }
        private void picUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.Filter = "Choose files(*.jpg; *.png; *.jpeg;) | *.jpg; *.png; *.jpeg;";
            if(opfd.ShowDialog() == DialogResult.OK)
            {
                picUpload.Image = Image.FromFile(opfd.FileName);
            }

        }
        public void LoadImage()
        {
            query = "SELECT photo from tbUser where id = '"+lblId.Text+"'";
            command = new SqlCommand(query, connection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            connection.Open();
            if (ds.Tables[0].Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["photo"]);
                picUpload.Image = new Bitmap(ms);
            }
            connection.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Image picimg = picUpload.Image;
                ImageConverter ctr = new ImageConverter();
                var img = ctr.ConvertTo(picimg, typeof(Byte[]));

                if (txtUsername.Text == string.Empty || txtPass.Text == string.Empty || txtFullName.Text == string.Empty || cmbRole.Text == "" || txtResidence.Text == string.Empty || txtEmail.Text == string.Empty || txtPhone.Text == string.Empty || cmbGender.Text == "")
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "complete the empty fields!";
                    lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                    txtUsername.Focus();
                    return;
                }
                else
                {
                    /*checking if supplier already exist*/
                    selectQuery = "SELECT * FROM tbUser WHERE username = '" + txtUsername.Text + "' OR fullname = '"+txtFullName.Text+"'";
                    command = new SqlCommand(selectQuery, connection);
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        Int32 count = Convert.ToInt32(command.ExecuteScalar());
                        connection.Close();

                        if (count > 0)
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = "user already exist!";
                            lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                            return;
                        }
                        else
                        {
                            query = "INSERT INTO tbUser(username, password, fullname, role, gender, residence, email, phone, photo, date)VALUES(@username, @password, @fullname, @role, @gender, @residence, @email, @phone, @photo, @date)";
                            command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@username", txtUsername.Text);
                            command.Parameters.AddWithValue("@password", txtPass.Text);
                            command.Parameters.AddWithValue("@fullname", txtFullName.Text);
                            command.Parameters.AddWithValue("@role", cmbRole.Text);
                            command.Parameters.AddWithValue("@gender", cmbGender.Text);
                            command.Parameters.AddWithValue("@residence", txtResidence.Text);
                            command.Parameters.AddWithValue("@email", txtEmail.Text);
                            command.Parameters.AddWithValue("@phone", txtPhone.Text);
                            command.Parameters.AddWithValue("@photo", img);
                            command.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

                            /*checking connection state*/
                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                                lblMsg.Visible = true;
                                lblMsg.Text = "user added successfully!";
                                lblMsg.ForeColor = Color.FromArgb(27, 168, 224);

                                clearFields();
                                user.fetchData();
                                connection.Close();
                            }

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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Image picimg = picUpload.Image;
                ImageConverter ctr = new ImageConverter();
                var img = ctr.ConvertTo(picimg, typeof(Byte[]));
                if (txtUsername.Text == string.Empty || txtPass.Text == string.Empty || txtFullName.Text == string.Empty || cmbRole.Text == "" || txtResidence.Text == string.Empty || txtEmail.Text == string.Empty || txtPhone.Text == string.Empty || cmbGender.Text == "")
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "no user selected!";
                    lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                }
                else
                {
                    query = "UPDATE tbUser SET username=@username, password=@password, fullname=@fullname, role=@role, gender=@gender, residence=@residence, email=@email, phone=@phone, photo=@photo, date=@date WHERE id like '"+lblId.Text+"'";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", txtUsername.Text);
                    command.Parameters.AddWithValue("@password", txtPass.Text);
                    command.Parameters.AddWithValue("@fullname", txtFullName.Text);
                    command.Parameters.AddWithValue("@role", cmbRole.Text);
                    command.Parameters.AddWithValue("@gender", cmbGender.Text);
                    command.Parameters.AddWithValue("@residence", txtResidence.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.Parameters.AddWithValue("@phone", txtPhone.Text);
                    command.Parameters.AddWithValue("@photo", img);
                    command.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
                    /*checking connection state*/
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        lblMsg.Visible = true;
                        lblMsg.Text = "user updated successfully!";
                        lblMsg.ForeColor = Color.FromArgb(27, 168, 224);

                        clearFields();
                        user.fetchData();
                        connection.Close();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearFields();
            lblMsg.Visible = false;
        }
    }
}
