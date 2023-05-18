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
    public partial class Product : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;
        string query;
        string title = "Point Of Sales";
        public Product()
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            fetchData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductModule product = new ProductModule(this);
            product.btnUpdate.Visible = false;
            product.Show();
        }
        /*fetching data from database*/
        public void fetchData()
        {
            try
            {
                int i = 0;
                dgvProduct.Rows.Clear();
                query = "SELECT * FROM tbProduct WHERE CONCAT(name,description, category, brand, qty, price, supplier) LIKE '%" + txtSearch.Text + "%' ORDER BY brand";
                command = new SqlCommand(query, connection);
                connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    i++;
                    dgvProduct.Rows.Add(i, dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), int.Parse(dataReader[5].ToString()), double.Parse(dataReader[6].ToString()), dataReader[7].ToString(), Convert.ToDateTime(dataReader[8].ToString()).ToShortDateString());
                }
                dataReader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgvProduct.Columns[e.ColumnIndex].Name;
                if (colName == "Edit")
                {

                    ProductModule product = new ProductModule(this);
                    product.lblId.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                    product.txtName.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                    product.txtDescription.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                    product.cmbCategory.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                    product.cmbBrand.Text = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                    product.txtQty.Text = dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                    product.txtPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString();
                    product.cmbSupplier.Text = dgvProduct.Rows[e.RowIndex].Cells[8].Value.ToString();

                    product.btnAdd.Visible = false;
                    product.btnUpdate.Visible = true;
                    product.lblHeading.Text = "Update Product";
                    product.Show();
                }
                else if (colName == "Delete")
                {
                    if (MessageBox.Show("Do you want to delete this product", title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        dbcon.executeQuery("DELETE FROM tbProduct WHERE id = '" + dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                        MessageBox.Show("product Deleted Successfully", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fetchData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            fetchData();
        }
    }
}
