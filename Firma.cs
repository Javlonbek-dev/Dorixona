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
    public partial class Firma : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public Firma()
        {
            InitializeComponent();
        }
        string queryAll = "SELECT Firma.Ferma_Id,Firma.Ferma_Nomi,Firma.Manzil,Firma.Telefon_raqam FROM Firma";
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
        private void Firma_Load(object sender, EventArgs e)
        {
            dbConnection();
            showAllData(queryAll);
        }
        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection();
                cmd = new SqlCommand("insert into Firma values (@Ferma_Nomi, @Manzil, @Telefon_raqam)", con);
                string newNomi = txtFirmNomi.Text;
                string newManzil = txtManzil.Text;
                string newTel = txtFirTel.Text;

                //cmd.Parameters.AddWithValue("@Firma_Id", newFirmaId);
                cmd.Parameters.AddWithValue("@Ferma_Nomi", newNomi);
                cmd.Parameters.AddWithValue("@Manzil", newManzil);
                cmd.Parameters.AddWithValue("@Telefon_raqam", newTel);

                cmd.ExecuteNonQuery();
                showAllData(queryAll);
                con.Open();
                con.Close();
                cleardata();

                MessageBox.Show("New record added successfully");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input. Please enter a valid number for Ferma_Id ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the new record: " + ex.Message);
            }
        }
        private void cleardata()
        {
            txtFirmNomi.Clear();
            txtManzil.Clear();
            txtFirTel.Clear();
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
            int Id = int.Parse(txtFirId.Text);
            string query = "Delete Firma where Ferma_Id =@Id";
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
            txtFirId.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            txtFirmNomi.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            txtManzil.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            txtFirTel.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            dbConnection();
            string query = "Update Firma set  Ferma_Nomi=@Ferma_Nomi,Manzil=@Manzil,Telefon_raqam= @Telefon_raqam where Ferma_Nomi=@Ferma_Nomi";
            cmd = new SqlCommand(query, con);
            string newNomi = txtFirmNomi.Text;
            string newManzil = txtManzil.Text;
            string newTel = txtFirTel.Text;
            cmd.Parameters.AddWithValue("@Ferma_Nomi", newNomi);
            cmd.Parameters.AddWithValue("@Manzil", newManzil);
            cmd.Parameters.AddWithValue("@Telefon_raqam", newTel);
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

        private void button2_Click(object sender, EventArgs e)
        {
            string Id = textBox1.Text.Trim();
            string Nomi = textBox2.Text.Trim();
            string Manzil = textBox3.Text.Trim();
            string Tel = textBox4.Text.Trim();

            string query = "SELECT * FROM Firma WHERE 1=1";
            if (!string.IsNullOrEmpty(Id))
            {
                query += " AND Ferma_Id LIKE '%" + Id + "%'";
            }
            if (!string.IsNullOrEmpty(Nomi))
            {
                query += " AND Ferma_Nomi LIKE '%" + Nomi + "%'";
            }
            if (!string.IsNullOrEmpty(Manzil))
            {
                query += " AND Manzil LIKE '%" + Manzil + "%'";
            }
            if (!string.IsNullOrEmpty(Tel))
            {
                query += " AND Telefon_Raqam LIKE '%" + Tel + "%'";
            }

            showAllData(query);
        }
    }
}
