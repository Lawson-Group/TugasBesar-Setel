using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;

namespace BikeLah_Setel.Models
{
    internal class PeminjamanModel
    {
        // Deklarasi variabel untuk menyimpan atribut Peminjaman.
        public int IdPeminjaman { get; private set; }
        public string NomorSeriKendaraan { get; private set; }
        public DateTime WaktuPeminjaman { get; private set; }
        public DateTime WaktuPengembalian { get; private set; }
        public string NamaPeminjam { get; private set; }
        public bool StatusPengembalian { get; private set; }

        public PeminjamanModel() { }

        // Implementasi Design by Contract.
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(!string.IsNullOrEmpty(NomorSeriKendaraan));
        }

        public void ReadJSON()
        {
            // Deserialisasi JSON.
            string DataPinjam = File.ReadAllText("D:\\Kuliah\\Semester 4\\Konstruksi Perangkat Lunak (KPL)\\TubesKPL_BikeLah\\TubesKPL_BikeLah\\BikeLah_Setel\\Models\\dataPeminjaman.json");
            string DataUser = File.ReadAllText("D:\\Kuliah\\Semester 4\\Konstruksi Perangkat Lunak (KPL)\\TubesKPL_BikeLah\\TubesKPL_BikeLah\\BikeLah_Setel\\ModelsuserLogin.json");

            dynamic JsonObj = JsonConvert.DeserializeObject(DataPinjam);
            dynamic JsonObj2 = JsonConvert.DeserializeObject(DataUser);

            IdPeminjaman = JsonObj2.userLogin.dataUser.dataCivitas.id;
            NomorSeriKendaraan = JsonObj.dataPeminjaman.nomorSeri;
            NamaPeminjam = JsonObj2.userLogin.username;
        }
        public void TambahPeminjaman(List<Peminjaman> dataPinjam, int id, string nomorSeri, 
            DateTime waktuPinjam, DateTime waktuKembali, string namaPeminjam, bool status)
        {
            Peminjaman PinjamanBaru = new Peminjaman
            {
                IdPeminjaman = id,
                NomorSeriKendaraan = nomorSeri,
                WaktuPeminjaman = waktuPinjam,
                WaktuPengembalian = waktuKembali,
                NamaPeminjam = namaPeminjam,
                StatusPengembalian = status
            };

            dataPinjam.Add(PinjamanBaru);
        }

        public List<Peminjaman> GetHistory()
        {
            List<Peminjaman> history = new List<Peminjaman>
            {
                new Peminjaman
                {
                    IdPeminjaman = 1,
                    NomorSeriKendaraan = "K001",
                    WaktuPeminjaman = new DateTime(2023, 5, 1, 8, 0, 0),
                    WaktuPengembalian = new DateTime(2023, 5, 1, 12, 0, 0),
                    NamaPeminjam = "Jean",
                    StatusPengembalian = true
                },
                new Peminjaman
                {
                    IdPeminjaman = 2,
                    NomorSeriKendaraan = "K002",
                    WaktuPeminjaman = new DateTime(2023, 5, 2, 14, 0, 0),
                    WaktuPengembalian = new DateTime(2023, 5, 2, 18, 0, 0),
                    NamaPeminjam = "Triani",
                    StatusPengembalian = true
                },
                new Peminjaman
                {
                    IdPeminjaman = 3,
                    NomorSeriKendaraan = "K003",
                    WaktuPeminjaman = new DateTime(2023, 5, 3, 9, 0, 0),
                    WaktuPengembalian = new DateTime(2023, 5, 3, 13, 0, 0),
                    NamaPeminjam = "Sabila",
                    StatusPengembalian = true
                },
                new Peminjaman
                {
                    IdPeminjaman = 4,
                    NomorSeriKendaraan = "K004",
                    WaktuPeminjaman = new DateTime(2023, 5, 4, 10, 0, 0),
                    WaktuPengembalian = new DateTime(2023, 5, 4, 14, 0, 0),
                    NamaPeminjam = "Luocha",
                    StatusPengembalian = false
                }
            };

            return history;
        }

        public void GetWaktuPengembalian(int IdPeminjaman, DateTime BatasPengembalian)
        {

        }

        public void UpdateStatusPeminjaman(int IdPeminjaman, string Status)
        {

        }
    }
}
