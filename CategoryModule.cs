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
    public partial class CategoryModule : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        string query, selectQuery;

        Category category;
        public CategoryModule(Category cat)
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            category = cat;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCategory.Text == string.Empty)
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "enter category name!";
                    lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                    txtCategory.Focus();
                }
                else
                {
                    /*checking if brand already exist*/
                    selectQuery = "SELECT * FROM tbCategory WHERE category = '" + txtCategory.Text + "'";
                    command = new SqlCommand(selectQuery, connection);
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        Int32 count = Convert.ToInt32(command.ExecuteScalar());
                        connection.Close();

                        if (count > 0)
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = "category already exist in database!";
                            lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                        }
                        else
                        {
                            query = "INSERT INTO tbCategory(category, date)VALUES(@category, @date)";
                            command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@category", txtCategory.Text);
                            command.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

                            /*checking connection state*/
                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                                lblMsg.Visible = true;
                                lblMsg.Text = "category added successfully!";
                                lblMsg.ForeColor = Color.FromArgb(27, 168, 224);

                                txtCategory.Clear();
                                category.fetchData();
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
                if (txtCategory.Text == string.Empty)
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "no category selected!";
                    lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                }
                else
                {
                    query = "UPDATE tbCategory SET category=@category, date=@date WHERE id like '" + lblId.Text + "'";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@category", txtCategory.Text);
                    command.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

                    /*checking connection state*/
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        lblMsg.Visible = true;
                        lblMsg.Text = "category updated successfully!";
                        lblMsg.ForeColor = Color.FromArgb(27, 168, 224);

                        txtCategory.Clear();
                        category.fetchData();
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
