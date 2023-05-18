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
    public partial class CustomerModule : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        string query, selectQuery;

        Customer customer;
        public CustomerModule(Customer cus)
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            customer = cus;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void clearFields()
        {
            txtName.Clear();
            txtResidence.Clear();
            cmbGender.SelectedIndex = -1;
            txtPhone.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == string.Empty || txtResidence.Text == string.Empty || txtPhone.Text == string.Empty || cmbGender.Text == "")
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "complete the empty fields!";
                    lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                    txtName.Focus();
                }
                else
                {
                    /*checking if supplier already exist*/
                    selectQuery = "SELECT * FROM tbCustomer WHERE name = '" + txtName.Text + "'";
                    command = new SqlCommand(selectQuery, connection);
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        Int32 count = Convert.ToInt32(command.ExecuteScalar());
                        connection.Close();

                        if (count > 0)
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = "the name of this customer already exist!";
                            lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                        }
                        else
                        {
                            query = "INSERT INTO tbCustomer(name, residence, gender, phone, date)VALUES(@name, @residence, @gender, @phone, @date)";
                            command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@name", txtName.Text);
                            command.Parameters.AddWithValue("@residence", txtResidence.Text);
                            command.Parameters.AddWithValue("@gender", cmbGender.Text);
                            command.Parameters.AddWithValue("@phone", txtPhone.Text);
                            command.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

                            /*checking connection state*/
                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                                lblMsg.Visible = true;
                                lblMsg.Text = "customer added successfully!";
                                lblMsg.ForeColor = Color.FromArgb(27, 168, 224);

                                clearFields();
                                customer.fetchData();
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
                if (txtName.Text == string.Empty || txtResidence.Text == string.Empty || txtPhone.Text == string.Empty || cmbGender.Text == "")
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "select customer to continue!";
                    lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                }
                else
                {
                    query = "UPDATE tbCustomer SET name=@name, residence=@residence, gender=@gender, phone=@phone, date=@date WHERE id like '"+lblId.Text+"'";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", txtName.Text);
                    command.Parameters.AddWithValue("@residence", txtResidence.Text);
                    command.Parameters.AddWithValue("@gender", cmbGender.Text);
                    command.Parameters.AddWithValue("@phone", txtPhone.Text);
                    command.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

                    /*checking connection state*/
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        lblMsg.Visible = true;
                        lblMsg.Text = "customer updated successfully!";
                        lblMsg.ForeColor = Color.FromArgb(27, 168, 224);

                        clearFields();
                        customer.fetchData();
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
