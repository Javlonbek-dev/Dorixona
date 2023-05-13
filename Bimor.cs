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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dorixona
{
    public partial class Bimor : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public Bimor()
        {
            InitializeComponent();
        }
        string queryAll = "SELECT Bemor.Bemor_Id,Bemor.Ismi,Bemor.Manzil,Bemor.Telefon_Raqam FROM Bemor";
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
        private void Bimor_Load(object sender, EventArgs e)
        {
            dbConnection();
            showAllData(queryAll);
        }
        private void insert_Click(object sender, EventArgs e)
        {

            try
            {
                dbConnection();
                cmd = new SqlCommand("insert into Bemor values (@Bemor_Id, @Ismi, @Manzil, @Telefon_Raqam)", con);
                int newBemorId = int.Parse(txtbermorId.Text);
                string newIsmi = txtIsm.Text;
                string newManzil = txtManzil.Text;
                string newTel = txtTelefon.Text;

                cmd.Parameters.AddWithValue("@Bemor_Id", newBemorId);
                cmd.Parameters.AddWithValue("@Ismi", newIsmi);
                cmd.Parameters.AddWithValue("@Manzil", newManzil);
                cmd.Parameters.AddWithValue("@Telefon_Raqam", newTel);

                cmd.ExecuteNonQuery();
                showAllData(queryAll);
                con.Open();
                con.Close();
                cleardata();

                MessageBox.Show("New record added successfully");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Qaysidir textboxga malumot kiritilmadi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the new record: " + ex.Message);
            }
        }

        private void cleardata()
        {
            txtbermorId.Clear();
            txtIsm.Clear();
            txtManzil.Clear();
            txtTelefon.Clear();

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
                dataGridView1.Rows[dtRow].Cells[column++].Value = row.Field<string>(3);

                dtRow++;
            }
            con.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            dbConnection();
            int Id = int.Parse(txtbermorId.Text);
            string query = "Delete Bemor where Bemor_Id=@Id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Ma'lumot o'chirildi!");
            cleardata();
            showAllData(queryAll);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtbermorId.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            txtIsm.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            txtManzil.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            txtTelefon.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            dbConnection();
            string query = "Update Bemor set Bemor_Id=@Bemor_Id, Ismi=@Ismi,Manzil=@Manzil,Telefon_Raqam= @Telefon_Raqam where Bemor_Id = @Bemor_Id";
            cmd = new SqlCommand(query, con);
            int newBemorId = int.Parse(txtbermorId.Text);
            string newIsmi = txtIsm.Text;
            string newManzil = txtManzil.Text;
            string newTel = txtTelefon.Text;
            cmd.Parameters.AddWithValue("@Bemor_Id", newBemorId);
            cmd.Parameters.AddWithValue("@Ismi", newIsmi);
            cmd.Parameters.AddWithValue("@Manzil", newManzil);
            cmd.Parameters.AddWithValue("@Telefon_Raqam", newTel);
            cmd.ExecuteNonQuery();
            showAllData(queryAll);
            con.Open();
            con.Close();
            cleardata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string Bemor_Id = textBox1.Text.Trim();
            string Ismi = textBox2.Text.Trim();
            string Manzil = textBox3.Text.Trim();
            string Telefon_Raqam = textBox4.Text.Trim();

            string query = "SELECT * FROM Bemor WHERE 1=1";
            if (!string.IsNullOrEmpty(Bemor_Id))
            {
                query += " AND Bemor_Id LIKE '%" + Bemor_Id + "%'";
            }
            if (!string.IsNullOrEmpty(Ismi))
            {
                query += " AND Ismi LIKE '%" + Ismi + "%'";
            }
            if (!string.IsNullOrEmpty(Manzil))
            {
                query += " AND Manzil LIKE '%" + Manzil + "%'";
            }
            if (!string.IsNullOrEmpty(Telefon_Raqam))
            {
                query += " AND Telefon_Raqam LIKE '%" + Telefon_Raqam + "%'";
            }

            showAllData(query);
        }
    }
}
