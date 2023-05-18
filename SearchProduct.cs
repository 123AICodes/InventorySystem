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
    public partial class SearchProduct : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;
        string query;
        string title = "Point Of Sales";
        public SearchProduct()
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            fetchData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgvProduct.Columns[e.ColumnIndex].Name;
                if(colName == "AddToCart")
                {
                    Qty qty = new Qty();
                    qty.Show();
                    //qty.productDetails(dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString(), double.Parse(dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString()), cashier.lblUsername.Text, int.Parse(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString()));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
