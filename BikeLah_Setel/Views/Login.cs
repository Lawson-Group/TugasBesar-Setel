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

            string dataUserString = File.ReadAllText("userLogin.json"); 
            DataGlobal.dataUser = JsonConvert.DeserializeObject<List<User>>(dataUserString);


            /*string dataKendaraanString = File.ReadAllText("KendaraanData.json");
            DataGlobal.dataKendaraan = JsonConvert.DeserializeObject<List<Kendaraan>>(dataKendaraanString);

            string dataPeminjamanString = File.ReadAllText("dataPeminjaman.json");
            DataGlobal.dataPeminjaman = JsonConvert.DeserializeObject<List<Peminjaman>>(dataPeminjamanString);

            string dataShelterString = File.ReadAllText("ShelterData.json");
            DataGlobal.dataShelter = JsonConvert.DeserializeObject<List<Shelter>>(dataShelterString);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGlobal.dataUser.Count; i++)
            {
                if (textBoxUsername.Text.Equals(DataGlobal.dataUser[i].username))
                {
                    if (textBoxPassword.Text.Equals(DataGlobal.dataUser[i].password))
                    {
                        MessageBox.Show("Login Berhasil");
                        UserSession.userSession = DataGlobal.dataUser[i];
                        PageHome pageHome = new PageHome();
                        
                        this.Hide();
                        pageHome.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password Anda salah");
                    }
                    return;
                } else
                {
                    MessageBox.Show("Username Anda salah");
                }
                return;
            }
        }

        private bool IsValidUser(string username, string password)
        {
            
            if (File.Exists("userLogin.json"))
            {
                // Membaca data pengguna dari UserData.json
                string userDataString = File.ReadAllText("userLogin.json");
                List<User> users = JsonConvert.DeserializeObject<List<User>>(userDataString);

                foreach (User user in DataGlobal.dataUser)
                {
                    if (user.username.Equals(username) && user.password.Equals(password))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
