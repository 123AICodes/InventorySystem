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
    public partial class SupplierModule : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        string query, selectQuery;

        Supplier supplier;
        public SupplierModule(Supplier sp)
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            supplier = sp;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void clearFields()
        {
            txtSupplier.Clear();
            txtAddress.Clear();
            txtContactPerson.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSupplier.Text == string.Empty || txtAddress.Text == string.Empty || txtContactPerson.Text == string.Empty || txtEmail.Text == string.Empty || txtPhone.Text == string.Empty)
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "fill in the blank spaces!";
                    lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                    txtSupplier.Focus();
                }
                else
                {
                    /*checking if supplier already exist*/
                    selectQuery = "SELECT * FROM tbSupplier WHERE supplier = '" + txtSupplier.Text + "'";
                    command = new SqlCommand(selectQuery, connection);
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        Int32 count = Convert.ToInt32(command.ExecuteScalar());
                        connection.Close();

                        if (count > 0)
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = "supplier already exist!";
                            lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                        }
                        else
                        {
                            query = "INSERT INTO tbSupplier(supplier, address, contactperson, email, phone, date)VALUES(@supplier, @address, @contactperson, @email, @phone, @date)";
                            command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@supplier", txtSupplier.Text);
                            command.Parameters.AddWithValue("@address", txtAddress.Text);
                            command.Parameters.AddWithValue("@contactperson", txtContactPerson.Text);
                            command.Parameters.AddWithValue("@email", txtEmail.Text);
                            command.Parameters.AddWithValue("@phone", txtPhone.Text);
                            command.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

                            /*checking connection state*/
                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                                lblMsg.Visible = true;
                                lblMsg.Text = "supplier added successfully!";
                                lblMsg.ForeColor = Color.FromArgb(27, 168, 224);

                                clearFields();
                                supplier.fetchData();
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
                if (txtSupplier.Text == string.Empty || txtAddress.Text == string.Empty || txtContactPerson.Text == string.Empty || txtEmail.Text == string.Empty || txtPhone.Text == string.Empty)
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "no supplier selected!";
                    lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                    txtSupplier.Focus();
                }
                else
                {                  
                    query = "UPDATE tbSupplier SET supplier=@supplier, address=@address, contactperson=@contactperson, email=@email, phone=@phone, date=@date WHERE id like '"+lblId.Text+"'";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@supplier", txtSupplier.Text);
                    command.Parameters.AddWithValue("@address", txtAddress.Text);
                    command.Parameters.AddWithValue("@contactperson", txtContactPerson.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.Parameters.AddWithValue("@phone", txtPhone.Text);
                    command.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

                    /*checking connection state*/
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        lblMsg.Visible = true;
                        lblMsg.Text = "supplier updated successfully!";
                        lblMsg.ForeColor = Color.FromArgb(27, 168, 224);

                        clearFields();
                        supplier.fetchData();
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
