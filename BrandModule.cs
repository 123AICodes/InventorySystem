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
    public partial class BrandModule : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        string query, selectQuery;

        Brand brand;
        public BrandModule(Brand bd)
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            brand = bd;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBrand.Text == string.Empty)
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "enter brand name!";
                    lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                    txtBrand.Focus();
                }
                else
                {
                    /*checking if brand already exist*/
                    selectQuery = "SELECT * FROM tbBrand WHERE brand = '" + txtBrand.Text + "'";
                    command = new SqlCommand(selectQuery, connection);
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        Int32 count = Convert.ToInt32(command.ExecuteScalar());
                        connection.Close();

                        if (count > 0)
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = "brand exist in database already!";
                            lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                        }
                        else
                        {
                            query = "INSERT INTO tbBrand(brand, date)VALUES(@brand, @date)";
                            command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@brand", txtBrand.Text);
                            command.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

                            /*checking connection state*/
                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                                lblMsg.Visible = true;
                                lblMsg.Text = "brand added successfully!";
                                lblMsg.ForeColor = Color.FromArgb(27, 168, 224);

                                txtBrand.Clear();
                                brand.fetchData();
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
                if (txtBrand.Text == string.Empty)
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "no brand selected!";
                    lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                }
                else
                {                  
                    query = "UPDATE tbBrand SET brand=@brand, date=@date WHERE id like '"+lblId.Text+"'";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@brand", txtBrand.Text);
                    command.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

                    /*checking connection state*/
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        lblMsg.Visible = true;
                        lblMsg.Text = "brand updated successfully!";
                        lblMsg.ForeColor = Color.FromArgb(27, 168, 224);

                        txtBrand.Clear();
                        brand.fetchData();
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
    }
}
