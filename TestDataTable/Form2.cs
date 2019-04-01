using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDataTable
{
    public partial class Form2 : Form
    {
        private SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        SqlCommandBuilder cmd = null;

        string connectionStr = "";
        public Form2()
        {
            InitializeComponent();
            conn = new SqlConnection();
            connectionStr = ConfigurationManager.ConnectionStrings["MyLibrary"].ConnectionString;
            conn.ConnectionString = connectionStr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionStr);
                ds = new DataSet();
                string sql = tbRequest.Text;
                da = new SqlDataAdapter(sql, conn);
                dataGridView1.DataSource = null;
                cmd = new SqlCommandBuilder(da);

                //Debug.WriteLine(cmd.GetInsertCommand().CommandText);
                //Debug.WriteLine(cmd.GetUpdateCommand().CommandText);
                //Debug.WriteLine(cmd.GetDeleteCommand().CommandText);

                da.Fill(ds, "mybook");
                dataGridView1.DataSource = ds.Tables["mybook"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex);
            }
            finally
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            da.Update(ds, "mybook");
            //SqlCommand UpdateCmd = new SqlCommand("Update Books set Price = @pPrice where id = @pId", conn);
            ////создаем параметры для запроса Update
            //UpdateCmd.Parameters.Add(new SqlParameter("@pPrice",SqlDbType.Int));
            //UpdateCmd.Parameters["@pPrice"].SourceVersion = DataRowVersion.Current;
            //UpdateCmd.Parameters["@pPrice"].SourceColumn = "Price";
            //UpdateCmd.Parameters.Add(new SqlParameter("@pId", SqlDbType.Int));
            //UpdateCmd.Parameters["@pId"].SourceVersion = DataRowVersion.Original;
            //UpdateCmd.Parameters["@pId"].SourceColumn = "id";
            ////вставляем созданный объект SqlCommand в свойство UpdateCommand SqlDataAdapter
            //da.UpdateCommand = UpdateCmd;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
