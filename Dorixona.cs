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
    public partial class Dorixona : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public Dorixona()
        {
            InitializeComponent();
        }
        string queryAll = "SELECT Dorixona.Dorixona_Id,Dorixona_Nomi,Dorixona.Manzil,Dorixona.Telefon_Raqami,Dorixona.Boshqaruvchini_Ismi FROM Dorixona";
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
        private void Dorixona_Load(object sender, EventArgs e)
        {
            dbConnection();
            showAllData(queryAll);
        }

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection();
                cmd = new SqlCommand("insert into Dorixona values (@Dorixona_Id, @Dorixona_Nomi, @Manzil, @Telefon_Raqam,@Boshqaruvchini_Ismi)", con);
                int newDorixonaId = int.Parse(textBox1.Text);
                string newNomi = textBox2.Text;
                string newManzil = textBox3.Text;
                string newTel = textBox4.Text;
                string newBoshqaruvchi = textBox5.Text;

                cmd.Parameters.AddWithValue("@Dorixona_Id", newDorixonaId);
                cmd.Parameters.AddWithValue("@Dorixona_Nomi", newNomi);
                cmd.Parameters.AddWithValue("@Manzil", newManzil);
                cmd.Parameters.AddWithValue("@Telefon_Raqam", newTel);
                cmd.Parameters.AddWithValue("@Boshqaruvchini_Ismi", newBoshqaruvchi);

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
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
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
                dataGridView1.Rows[dtRow].Cells[column++].Value = row.Field<string>(4);

                dtRow++;
            }
            con.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            dbConnection();
            int Id = int.Parse(textBox1.Text);
            string query = "Delete Dorixona where Dorixona_Id=@Id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Ma'lumot o'chirildi!");
            cleardata();
            showAllData(queryAll);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string Id = textBox6.Text.Trim();
            string Nomi = textBox7.Text.Trim();
            string Manzil = textBox8.Text.Trim();
            string Tel = textBox9.Text.Trim();
            string FikeName = textBox10.Text.Trim();

            string query = "SELECT * FROM Dorixona WHERE 1=1";
            if (!string.IsNullOrEmpty(Id))
            {
                query += " AND Dorixona_Id LIKE '%" + Id + "%'";
            }
            if (!string.IsNullOrEmpty(Nomi))
            {
                query += " AND Dorixona_Nomi LIKE '%" + Nomi + "%'";
            }
            if (!string.IsNullOrEmpty(Manzil))
            {
                query += " AND Manzil LIKE '%" + Manzil + "%'";
            }
            if (!string.IsNullOrEmpty(Tel))
            {
                query += " AND Telefon_Raqami LIKE '%" + Tel + "%'";
            }
            if (!string.IsNullOrEmpty(FikeName))
            {
                query += " AND Boshqaruvchini_Ismi LIKE '%" + FikeName + "%'";
            }

            showAllData(query);

        }
    }
}
