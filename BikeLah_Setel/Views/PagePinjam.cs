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
    public partial class PagePinjam : Form
    {
        public PagePinjam()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PeminjamanBerhasil success = new PeminjamanBerhasil();
            success.Show();
            Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageHome home = new PageHome();
            home.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PageInfoShelter info = new PageInfoShelter();
            info.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PagePanduan pagePanduan = new PagePanduan();
            pagePanduan.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PageHistory pageHistory = new PageHistory();
            pageHistory.Show();
            Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Visible = false;
        }

        private void PagePinjam_Load(object sender, EventArgs e)
        {

        }
    }
}
