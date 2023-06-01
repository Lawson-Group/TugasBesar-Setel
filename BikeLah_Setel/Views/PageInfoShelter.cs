using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeLah_Setel
{
    public partial class PageInfoShelter : Form
    {
        public PageInfoShelter()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PagePinjam pinjam = new PagePinjam();
            pinjam.Show();
            Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PagePinjam pinjam = new PagePinjam();
            pinjam.Show();
            Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageHome home = new PageHome();
            home.Show();
            Visible = false;
        }

        private void PageInfoShelter_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PagePinjam pinjam = new PagePinjam();
            pinjam.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PagePanduan guide = new PagePanduan();
            guide.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PageHistory history = new PageHistory();
            history.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Akun acc = new Akun();
            acc.Show();
            Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PagePinjam pinjam = new PagePinjam();
            pinjam.Show();
            Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PagePinjam pinjam = new PagePinjam();
            pinjam.Show();
            Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Visible = false;
        }
    }
}
