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
    public partial class Supplier : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;
        string query;
        string title = "Point Of Sales";
        public Supplier()
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            fetchData();
        }

        /*fetching data from database*/
        public void fetchData()
        {
            try
            {
                int i = 0;
                dgvSupplier.Rows.Clear();
                query = "SELECT * FROM tbSupplier WHERE CONCAT(supplier, address, contactperson, email, phone) LIKE '%"+txtSearch.Text+"%' ORDER BY supplier";
                command = new SqlCommand(query, connection);
                connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    i++;
                    dgvSupplier.Rows.Add(i, dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString(), Convert.ToDateTime(dataReader[6].ToString()).ToShortDateString());
                }
                dataReader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SupplierModule supplier = new SupplierModule(this);
            supplier.btnUpdate.Visible = false;
            supplier.Show();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgvSupplier.Columns[e.ColumnIndex].Name;
                if(colName == "Edit") { 

                    SupplierModule supplier = new SupplierModule(this);
                    supplier.lblId.Text = dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
                    supplier.txtSupplier.Text = dgvSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
                    supplier.txtAddress.Text = dgvSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
                    supplier.txtContactPerson.Text = dgvSupplier.Rows[e.RowIndex].Cells[4].Value.ToString();
                    supplier.txtEmail.Text = dgvSupplier.Rows[e.RowIndex].Cells[5].Value.ToString();
                    supplier.txtPhone.Text = dgvSupplier.Rows[e.RowIndex].Cells[6].Value.ToString();

                    supplier.btnAdd.Visible = false;
                    supplier.btnUpdate.Visible = true;
                    supplier.lblHeading.Text = "Update Supplier";
                    supplier.Show();
                }
                else if(colName == "Delete")
                {
                    if(MessageBox.Show("Do you want to delete this supplier", title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        dbcon.executeQuery("DELETE FROM tbSupplier WHERE id = '"+ dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                        MessageBox.Show("supplier Deleted Successfully",title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
