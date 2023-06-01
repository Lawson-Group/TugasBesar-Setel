using BikeLah_Setel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BikeLah_Setel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            string dataUserString = File.ReadAllText("UserData.json");
            DataGlobal.dataUser = JsonConvert.DeserializeObject<List<User>>(dataUserString);

            string dataKendaraanString = File.ReadAllText("KendaraanData.json");
            DataGlobal.dataKendaraan = JsonConvert.DeserializeObject<List<Kendaraan>>(dataKendaraanString);

            string dataPeminjamanString = File.ReadAllText("PeminjamanData.json");
            DataGlobal.dataPeminjaman = JsonConvert.DeserializeObject<List<Peminjaman>>(dataPeminjamanString);

            string dataShelterString = File.ReadAllText("ShelterData.json");
            DataGlobal.dataShelter = JsonConvert.DeserializeObject<List<Shelter>>(dataShelterString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGlobal.dataUser.Count; i++)
            {
                if (textBoxUsername.Text.Equals(DataGlobal.dataUser[i].Username))
                {
                    if (textBoxPassword.Text.Equals(DataGlobal.dataUser[i].Password))
                    {
                        MessageBox.Show("Login Berhasil");
                    }
                    else
                    {
                        MessageBox.Show("Password Anda salah");
                    }
                    return;
                }
            }
        }

        private bool IsValidUser(string username, string password)
        {
            // Logika validasi pengguna
            if (username.Equals("Aisha") && password.Equals("1302213038"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
