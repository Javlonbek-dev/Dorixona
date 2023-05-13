using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Dorixona
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }


        string queryAll = "SELECT Dori.doriId, Dori.Nomi, Dori.Doza, Dori.Narxi, Dori.Ferma_Nomi, Dori.Ishlab_Chiqarilgan_Sana, Dori.Muddati, Dori.Joy, Dori.Miqdor FROM Dori";
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
        private void Form1_Load(object sender, EventArgs e)
        {
            dbConnection();
            showAllData(queryAll);
        }

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection();
                cmd = new SqlCommand("insert into Dori values (@Dori_Id, @Nomi, @Doza, @Narxi, @Ferma_Nomi, @Ishlab_Chiqarilgan_Sana, @Muddati, @Joy, @Miqdor)", con);
                int newDoriId = int.Parse(txtDoriId.Text);
                string newNomi = txtNomi.Text;
                string newDoza = txtDoza.Text;
                float newNarxi = float.Parse(txtNarxi.Text);
                string newFermaNomi = txtFermaNomi.Text;
                string newIshlabChiqarilganSana = txtSana.Text;
                string newMuddati = txtMuddati.Text;
                string newJoy = txtJoy.Text;
                int newMiqdor = int.Parse(txtMiqdor.Text);

                cmd.Parameters.AddWithValue("@Dori_Id", newDoriId);
                cmd.Parameters.AddWithValue("@Nomi", newNomi);
                cmd.Parameters.AddWithValue("@Doza", newDoza);
                cmd.Parameters.AddWithValue("@Narxi", newNarxi);
                cmd.Parameters.AddWithValue("@Ferma_Nomi", newFermaNomi);
                cmd.Parameters.AddWithValue("@Ishlab_Chiqarilgan_Sana", newIshlabChiqarilganSana);
                cmd.Parameters.AddWithValue("@Muddati", newMuddati);
                cmd.Parameters.AddWithValue("@Joy", newJoy);
                cmd.Parameters.AddWithValue("@Miqdor", newMiqdor);
                cmd.ExecuteNonQuery();
                showAllData(queryAll);
                con.Open();
                con.Close();
                cleardata();

                MessageBox.Show("New record added successfully");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input. Please enter a valid number for Narxi and Miqdor fields.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the new record: " + ex.Message);
            }

        }
        private void cleardata()
        {
            txtDoriId.Clear();
            txtNomi.Clear();
            txtDoza.Clear();
            txtNarxi.Clear();
            txtJoy.Clear();
            txtMuddati.Clear();
            txtMiqdor.Clear();
            txtFermaNomi.Clear();
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
                dataGridView1.Rows[dtRow].Cells[column++].Value = row.Field<Int32>(3);
                dataGridView1.Rows[dtRow].Cells[column++].Value = row.Field<string>(4);
                dataGridView1.Rows[dtRow].Cells[column++].Value = row.Field<string>(5);
                dataGridView1.Rows[dtRow].Cells[column++].Value = row.Field<string>(6);
                dataGridView1.Rows[dtRow].Cells[column++].Value = row.Field<string>(7);
                dataGridView1.Rows[dtRow].Cells[column++].Value = row.Field<Int32>(8);

                dtRow++;
            }
            con.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            dbConnection();
            int Id = int.Parse(txtDoriId.Text);
            string query = "Delete Dori where doriId=@Id";
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
            txtDoriId.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            txtNomi.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            txtDoza.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            txtNarxi.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            txtFermaNomi.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
            txtSana.Text = dataGridView1.Rows[row].Cells[5].Value.ToString();
            txtMuddati.Text = dataGridView1.Rows[row].Cells[6].Value.ToString();
            txtJoy.Text = dataGridView1.Rows[row].Cells[7].Value.ToString();
            txtMiqdor.Text = dataGridView1.Rows[row].Cells[8].Value.ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            dbConnection();
            string query = "Update Dori set doriId=@Dori_Id, Nomi=@Nomi,Doza=@Doza,Narxi= @Narxi, Ferma_Nomi=@Ferma_Nomi, Ishlab_Chiqarilgan_Sana=@Ishlab_Chiqarilgan_Sana, Muddati=@Muddati, Joy=@Joy,Miqdor= @Miqdor where doriId = @Dori_Id";
            cmd = new SqlCommand(query, con);
            int newDoriId = int.Parse(txtDoriId.Text);
            string newNomi = txtNomi.Text;
            string newDoza = txtDoza.Text;
            float newNarxi = float.Parse(txtNarxi.Text);
            string newFermaNomi = txtFermaNomi.Text;
            string newIshlabChiqarilganSana = txtSana.Text;
            string newMuddati = txtMuddati.Text;
            string newJoy = txtJoy.Text;
            int newMiqdor = int.Parse(txtMiqdor.Text);

            cmd.Parameters.AddWithValue("@Dori_Id", newDoriId);
            cmd.Parameters.AddWithValue("@Nomi", newNomi);
            cmd.Parameters.AddWithValue("@Doza", newDoza);
            cmd.Parameters.AddWithValue("@Narxi", newNarxi);
            cmd.Parameters.AddWithValue("@Ferma_Nomi", newFermaNomi);
            cmd.Parameters.AddWithValue("@Ishlab_Chiqarilgan_Sana", newIshlabChiqarilganSana);
            cmd.Parameters.AddWithValue("@Muddati", newMuddati);
            cmd.Parameters.AddWithValue("@Joy", newJoy);
            cmd.Parameters.AddWithValue("@Miqdor", newMiqdor);
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
            string Id = textBox1.Text.Trim();
            string Nomi = textBox2.Text.Trim();
            string Doza = textBox3.Text.Trim();
            string Narxi = textBox4.Text.Trim();
            string Firma_Nomi = textBox5.Text.Trim();
            string IshSana = textBox6.Text.Trim();
            string Muddat = textBox7.Text.Trim();
            string Joy = textBox8.Text.Trim();
            string Miqdor = textBox9.Text.Trim();


            string query = "SELECT * FROM Dori WHERE 1=1";
            if (!string.IsNullOrEmpty(Id))
            {
                query += " AND doriId LIKE '%" + Id + "%'";
            }
            if (!string.IsNullOrEmpty(Nomi))
            {
                query += " AND Nomi LIKE '%" + Nomi + "%'";
            }
            if (!string.IsNullOrEmpty(Doza))
            {
                query += " AND Doza LIKE '%" + Doza + "%'";
            }
            if (!string.IsNullOrEmpty(Narxi))
            {
                query += " AND Narxi LIKE '%" + Narxi + "%'";
            }
            if (!string.IsNullOrEmpty(Firma_Nomi))
            {
                query += " AND Ferma_Nomi LIKE '%" + Firma_Nomi + "%'";
            }
            if (!string.IsNullOrEmpty(IshSana))
            {
                query += " AND Ishlab_Chiqarilgan_Sana LIKE '%" + IshSana + "%'";
            }
            if (!string.IsNullOrEmpty(Muddat))
            {
                query += " AND Muddati LIKE '%" + Muddat + "%'";
            }
            if (!string.IsNullOrEmpty(Joy))
            {
                query += " AND Joy LIKE '%" + Joy + "%'";
            }
            if (!string.IsNullOrEmpty(Miqdor))
            {
                query += " AND Miqdor LIKE '%" + Miqdor + "%'";
            }

            showAllData(query);
        }
    }
}
