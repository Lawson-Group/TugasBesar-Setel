using BikeLah_Setel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BikeLah_Setel
{
    public partial class PagePinjam : Form
    {
        public PagePinjam()
        {
            InitializeComponent();

/*            comboBox1.SelectedItem = UserSession.Peminjaman.jenisKendaraan;
            textBox3.Text = UserSession.Peminjaman.nomorSeri;
            comboBox2.SelectedItem = UserSession.Peminjaman.ShelterAwal;
            comboBox3.SelectedItem = UserSession.Peminjaman.ShelterAkhir;
*/
            /*string dataPeminjamanString = File.ReadAllText("dataPeminjaman.json");
            DataGlobal.dataPeminjaman = JsonConvert.DeserializeObject<List<Peminjaman>>(dataPeminjamanString);*/

        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*for (int i = 0; i < DataGlobal.dataKendaraan.Count; i++)
            {
                if (comboBox1.SelectedIndex.Equals(DataGlobal.dataKendaraan[i].JenisKendaraan))
                {
                    if (textBox3.Text.Equals(DataGlobal.dataKendaraan[i].NomorSeri))
                    {

                    }
                }
            }*/

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
