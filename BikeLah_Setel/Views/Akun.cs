﻿using BikeLah_Setel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BikeLah_Setel
{
    public partial class Akun : Form
    {
        public Akun()
        {
            InitializeComponent();
            namaLengkapUser.Text = UserSession.userSession.dataUser.dataCivitas.namaLengkap;
            NomorIDUser.Text = UserSession.userSession.dataUser.dataCivitas.id;

        }

        private void Akun_Load(object sender, EventArgs e)
        {

        }

        private void DataCivitas_TextChanged(object sender, EventArgs e)
        {

        }

        private void NamaLengkap_Click(object sender, EventArgs e)
        {

        }

        private void NamaLengkapUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomorID_Click(object sender, EventArgs e)
        {

        }

        private void NomorIDUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Role_Click(object sender, EventArgs e)
        {

        }

        private void RoleUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProgramStudi_Click(object sender, EventArgs e)
        {

        }

        private void ProgramStudiUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void TahunAngkatan_Click(object sender, EventArgs e)
        {

        }

        private void TahunAngkatanUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataPribadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void JenisKelamin_Click(object sender, EventArgs e)
        {

        }

        private void JenisKelaminUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nik_Click(object sender, EventArgs e)
        {

        }

        private void NIK_User_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomorHP_Click(object sender, EventArgs e)
        {

        }

        private void NomorHpUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void EmailUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailInstitusi_Click(object sender, EventArgs e)
        {

        }

        private void EmailInstitusiUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditData_Click(object sender, EventArgs e)
        {
            namaLengkapUser.ReadOnly = false;
        }

        private void SimpanData_Click(object sender, EventArgs e)
        {
            foreach (User user in DataGlobal.dataUser)
            {
                if (UserSession.userSession.username.Equals(user.username))
                {
                    user.dataUser.dataCivitas.namaLengkap = namaLengkapUser.Text;
                   
                }
            }
            String dataUserJson = JsonConvert.SerializeObject(DataGlobal.dataUser, Formatting.Indented);
            File.WriteAllText("userLogin.json", dataUserJson);

            namaLengkapUser.ReadOnly = true;
        }

        private void AkunSideBar_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

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

        private void button6_Click(object sender, EventArgs e)
        {
            PageHistory history = new PageHistory();
            history.Show();
            Visible = false;
        }

        private void PanelDataCivitas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataCivitas_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
