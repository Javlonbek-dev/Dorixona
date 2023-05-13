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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Dorixona;Integrated Security=True");

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            txt_password.Clear();
            txt_username.Clear();

            txt_username.Focus();
        }

        private void button_login_Click(object sender, EventArgs e)
        {

            string username = txt_username.Text;
            string password = txt_password.Text;

            if (username == "admin" && password == "admin123")
            {
                Menu menu= new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                
                MessageBox.Show("Password yoki username xato!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //String username, user_password;
            //username = txt_username.Text;
            //user_password = txt_password.Text;

            //try
            //{
            //    String query = "SELECT * FROM Login WHERE userName='" + txt_username.Text + "' AND password='" + txt_password.Text + "'";
            //    //MessageBox.Show(query);
            //    SqlDataAdapter sda = new SqlDataAdapter(query, conn);

            //    DataTable dtable = new DataTable();
            //    sda.Fill(dtable);

            //    if (username == txt_username.Text && user_password == txt_password.Text)
            //    {
            //        Menu menu = new Menu();
            //        menu.Show();
            //        this.Hide();
            //    }

            //    else
            //    {
            //        MessageBox.Show("Password yoki username xato!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txt_password.Clear();
            //        txt_username.Clear();

            //        txt_username.Focus();
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Error");
            //}
            //finally
            //{

            //}
        }
    }
}
