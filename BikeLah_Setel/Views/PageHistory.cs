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
    public partial class PageHistory : Form
    {
        public PageHistory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageHome home = new PageHome();
            home.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PagePanduan guide = new PagePanduan();
            guide.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Akun acc = new Akun();
            acc.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PagePinjam pinjam = new PagePinjam();
            pinjam.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PageInfoShelter info = new PageInfoShelter();
            info.Show();
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
