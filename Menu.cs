using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorixona
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Firma firma = new Firma();
            firma.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bimor bimor = new Bimor();
            bimor.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dorixona dorixona = new Dorixona();
            dorixona.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Retsep retsep = new Retsep();
            retsep.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
