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
    public partial class Customer : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;
        string query;
        string title = "Point Of Sales";
        public Customer()
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            fetchData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerModule customer = new CustomerModule(this);
            customer.btnUpdate.Visible = false;
            customer.Show();
        }
        /*fetching data from database*/
        public void fetchData()
        {
            try
            {
                int i = 0;
                dgvCustomer.Rows.Clear();
                query = "SELECT * FROM tbCustomer WHERE CONCAT(name,residence, gender, phone) LIKE '%" + txtSearch.Text + "%' ORDER BY name";
                command = new SqlCommand(query, connection);
                connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    i++;
                    dgvCustomer.Rows.Add(i, dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), Convert.ToDateTime(dataReader[5].ToString()).ToShortDateString());
                }
                dataReader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgvCustomer.Columns[e.ColumnIndex].Name;
                if (colName == "Edit")
                {
                    CustomerModule customer = new CustomerModule(this);
                    customer.lblId.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                    customer.txtName.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                    customer.txtResidence.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                    customer.cmbGender.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                    customer.txtPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells[5].Value.ToString();

                    customer.btnAdd.Visible = false;
                    customer.btnUpdate.Visible = true;
                    customer.lblHeading.Text = "Update Customer";
                    customer.Show();
                }
                else if (colName == "Delete")
                {
                    if (MessageBox.Show("Do you want to delete this customer", title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        dbcon.executeQuery("DELETE FROM tbCustomer WHERE id = '" + dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                        MessageBox.Show("customer Deleted Successfully", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
