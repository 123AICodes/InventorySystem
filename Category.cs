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
    public partial class Category : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;
        string query;
        string title = "Point Of Sales";
        public Category()
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            fetchData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryModule category = new CategoryModule(this);
            category.btnUpdate.Visible = false;
            category.Show();
        }
        /*fetching data from database*/
        public void fetchData()
        {
            try
            {
                int i = 0;
                dgvCategory.Rows.Clear();
                query = "SELECT * FROM tbCategory WHERE CONCAT(category, date) LIKE '%" + txtSearch.Text + "%' ORDER BY category";
                command = new SqlCommand(query, connection);
                connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    i++;
                    dgvCategory.Rows.Add(i, dataReader[0].ToString(), dataReader[1].ToString(), Convert.ToDateTime(dataReader[2].ToString()).ToShortDateString());
                }
                dataReader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgvCategory.Columns[e.ColumnIndex].Name;
                if (colName == "Edit")
                {

                    CategoryModule category = new CategoryModule(this);
                    category.lblId.Text = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                    category.txtCategory.Text = dgvCategory.Rows[e.RowIndex].Cells[2].Value.ToString();

                    category.btnAdd.Visible = false;
                    category.btnUpdate.Visible = true;
                    category.lblHeading.Text = "Update Category";
                    category.Show();
                }
                else if (colName == "Delete")
                {
                    if (MessageBox.Show("Do you want to delete this  brand", title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        dbcon.executeQuery("DELETE FROM tbCategory WHERE id = '" + dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                        MessageBox.Show("Category Deleted Successfully", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
