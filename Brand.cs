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
    public partial class Brand : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;
        string query;
        string title = "Point Of Sales";
        public Brand()
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            fetchData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BrandModule brand = new BrandModule(this);
            brand.btnUpdate.Visible = false;
            brand.lblHeading.Text = "Add New Brand";
            brand.Show();
        }
        /*fetching data from database*/
        public void fetchData()
        {
            try
            {
                int i = 0;
                dgvBrand.Rows.Clear();
                query = "SELECT * FROM tbBrand WHERE CONCAT(brand, date) LIKE '%" + txtSearch.Text + "%' ORDER BY brand";
                command = new SqlCommand(query, connection);
                connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    i++;
                    dgvBrand.Rows.Add(i, dataReader[0].ToString(), dataReader[1].ToString(), Convert.ToDateTime(dataReader[2].ToString()).ToShortDateString());
                }
                dataReader.Close();
                connection.Close();
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
        private void dgvBrand_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgvBrand.Columns[e.ColumnIndex].Name;
                if (colName == "Edit")
                {

                    BrandModule brand = new BrandModule(this);
                    brand.lblId.Text = dgvBrand.Rows[e.RowIndex].Cells[1].Value.ToString();
                    brand.txtBrand.Text = dgvBrand.Rows[e.RowIndex].Cells[2].Value.ToString();

                    brand.btnAdd.Visible = false;
                    brand.btnUpdate.Visible = true;
                    brand.lblHeading.Text = "Update Brand";
                    brand.Show();
                }
                else if (colName == "Delete")
                {
                    if (MessageBox.Show("Do you want to delete this  brand", title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        dbcon.executeQuery("DELETE FROM tbBrand WHERE id = '" + dgvBrand.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                        MessageBox.Show("Brand Deleted Successfully", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fetchData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
