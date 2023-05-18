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
    public partial class ProductModule : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        string query, selectQuery;

        Product product;
        public ProductModule(Product prod)
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            loadComboBoxes();
            product = prod;
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /*populating comboboxes*/
        public void loadComboBoxes()
        {
            try
            {
                cmbCategory.Items.Clear();
                cmbCategory.DataSource = dbcon.getTable("select * from tbCategory");
                cmbCategory.DisplayMember = "category";
                cmbCategory.ValueMember = "id";

                cmbBrand.Items.Clear();
                cmbBrand.DataSource = dbcon.getTable("select * from tbBrand");
                cmbBrand.DisplayMember = "brand";
                cmbBrand.ValueMember = "id"; 
                
                cmbSupplier.Items.Clear();
                cmbSupplier.DataSource = dbcon.getTable("select * from tbSupplier");
                cmbSupplier.DisplayMember = "supplier";
                cmbSupplier.ValueMember = "id";
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                lblMsg.ForeColor = Color.FromArgb(241, 84, 1);
                lblMsg.Text = ex.Message;
            }
        }
        /*clearing input fields*/
        public void clearFields()
        {
            txtName.Clear();
            txtQty.Clear();
            txtPrice.Clear();
            txtDescription.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbBrand.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == string.Empty || txtQty.Text == string.Empty || txtDescription.Text == string.Empty || txtPrice.Text == string.Empty || cmbCategory.Text == "" || cmbBrand.Text == "" || cmbSupplier.Text == "")
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "complete the empty fields!";
                    lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                    txtName.Focus();
                }
                else
                {
                    /*checking if supplier already exist*/
                    selectQuery = "SELECT * FROM tbProduct WHERE name = '" + txtName.Text + "' AND date = '"+lblDate.Text+"'";
                    command = new SqlCommand(selectQuery, connection);
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        Int32 count = Convert.ToInt32(command.ExecuteScalar());
                        connection.Close();

                        if (count > 0)
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = "Product was just added. Suggest you update instead!";
                            lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                        }
                        else
                        {
                            query = "INSERT INTO tbProduct(name, description, category, brand, qty, price, supplier, date)VALUES(@name, @description, @category, @brand, @qty, @price, @supplier, @date)";
                            command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@name", txtName.Text);
                            command.Parameters.AddWithValue("@description", txtDescription.Text);
                            command.Parameters.AddWithValue("@category", cmbCategory.Text);
                            command.Parameters.AddWithValue("@brand", cmbBrand.Text);
                            command.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                            command.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));
                            command.Parameters.AddWithValue("@supplier", cmbSupplier.Text);
                            command.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

                            /*checking connection state*/
                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                                lblMsg.Visible = true;
                                lblMsg.Text = "product added successfully!";
                                lblMsg.ForeColor = Color.FromArgb(27, 168, 224);

                                clearFields();
                                product.fetchData();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearFields();
            lblMsg.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == string.Empty || txtQty.Text == string.Empty || txtDescription.Text == string.Empty || txtPrice.Text == string.Empty || cmbCategory.Text == "" || cmbBrand.Text == "" || cmbSupplier.Text == "")
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "select product to proceed!";
                    lblMsg.ForeColor = Color.FromArgb(228, 61, 48);
                }
                else
                {
                    query = "UPDATE tbProduct SET name=@name, description=@description, category=@category, brand=@brand, qty=@qty, price=@price, supplier=@supplier, date=@date WHERE id like '"+lblId.Text+"'";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", txtName.Text);
                    command.Parameters.AddWithValue("@description", txtDescription.Text);
                    command.Parameters.AddWithValue("@category", cmbCategory.Text);
                    command.Parameters.AddWithValue("@brand", cmbBrand.Text);
                    command.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                    command.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));
                    command.Parameters.AddWithValue("@supplier", cmbSupplier.Text);
                    command.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

                    /*checking connection state*/
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        lblMsg.Visible = true;
                        lblMsg.Text = "product updated successfully!";
                        lblMsg.ForeColor = Color.FromArgb(27, 168, 224);

                        clearFields();
                        product.fetchData();
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
