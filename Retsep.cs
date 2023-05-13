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

namespace Dorixona
{
    public partial class Retsep : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public Retsep()
        {
            InitializeComponent();
        }
        string queryAll = "SELECT Retsep.Redsep_Id,Retsep.Dori_Id,Retsep.Bemor_Id FROM Retsep";
        private void dbConnection()
        {
            string strConnection = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Dorixona;Integrated Security=True";

            try
            {
                con = new SqlConnection(strConnection);
                con.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void Retsep_Load(object sender, EventArgs e)
        {
            dbConnection();
            showAllData(queryAll);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showAllData(string sorov)
        {
            // dbConnection();
            cmd = new SqlCommand(sorov, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataGridView1.Rows.Clear();
            data.Fill(dt);
            int column, dtRow = 0;

            foreach (DataRow row in dt.Rows)
            {
                column = 0;
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dtRow].Cells[column++].Value = row.Field<Int32>(0);
                dataGridView1.Rows[dtRow].Cells[column++].Value = row.Field<string>(1);
                dataGridView1.Rows[dtRow].Cells[column++].Value = row.Field<string>(2);
                dtRow++;
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Dorixona;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Dori";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            StreamWriter writer = new StreamWriter("C:\\Data\\data.txt");
            while (reader.Read())
            {
                writer.WriteLine(reader.GetString(0) + "," + reader.GetString(1) + "," + reader.GetString(2));
            }
            reader.Close();
            writer.Close();
            command.Dispose();
            connection.Close();
        }
    }
}
