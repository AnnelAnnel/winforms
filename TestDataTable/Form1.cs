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
using System.Configuration;


namespace TestDataTable
{
    public partial class Form1 : Form
    {
        private SqlDataReader dr;
        private DataTable dt;
        private SqlConnection conn;
        private string connStr = "";

        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection();
            connStr = ConfigurationManager.ConnectionStrings["MyCollege"].ConnectionString;
            conn.ConnectionString = connStr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = tbRequest.Text;
                cmd.Connection = conn;
                dataGridView1.DataSource = null;
                conn.Open();
                dt = new DataTable();
                dr = cmd.ExecuteReader();
                int line = 0;
                do
                {
                    while (dr.Read()){
                        {
                            if (line == 0)
                            {
                                for (int i = 0; i < dr.FieldCount; i++)
                                {
                                    dt.Columns.Add(dr.GetName(i));
                                }
                                line++;
                            }
                        }
                        DataRow row = dt.NewRow();
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            row[i] = dr[i];
                        }
                        dt.Rows.Add(row);
                    }
                } while (dr.NextResult());
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Probably wrong request syntax: "+ ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (dr != null)
                {
                    dr.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
