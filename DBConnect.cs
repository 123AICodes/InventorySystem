using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewInventory
{
    class DBConnect
    {
        SqlConnection con = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;
        string query;

        private string connection;

        public string myConnection()
        {
            connection = "Data Source=DESKTOP-AI;Initial Catalog=NewInventory;Integrated Security=True";

            return connection;
        }
        public DataTable getTable(string query)
        {
            con.ConnectionString = myConnection();
            command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public void executeQuery(String sql)
        {
            try
            {
                con.ConnectionString = myConnection();
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                    command = new SqlCommand(sql, con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public String getPassword(string username)
        {
            string password = "";
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.ConnectionString = myConnection();
                con.Open();
                query = "select password from tbUser where username = '" + username + "'";
                command = new SqlCommand(query, con);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                if (dataReader.HasRows)
                {
                    password = dataReader["password"].ToString();
                }
                con.Close();
                dataReader.Close();
            }
            return password;

        }

        public double ExtractDate(string sql)
        {
            con = new SqlConnection();
            con.ConnectionString = myConnection();
            con.Open();
            command = new SqlCommand(sql, con);
            double data = double.Parse(command.ExecuteScalar().ToString());
            con.Close();

            return data;
        }

    }
}
