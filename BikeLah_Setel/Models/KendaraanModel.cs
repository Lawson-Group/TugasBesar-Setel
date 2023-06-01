using Newtonsoft.Json;
using System.Diagnostics.Contracts;
using System.IO;

namespace BikeLah_Setel.Models
{
    internal class KendaraanModel
    {
        // Deklarasi variabel untuk menyimpan atribut Kendaraan.
        public string JenisKendaraan { get; private set; }
        public string NomorSeri { get; private set; }
        public string ShelterAwal { get; private set; }
        public string ShelterTujuan { get; private set; }

        public KendaraanModel() { }

        // Implementasi Design by Contract.
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(!string.IsNullOrEmpty(JenisKendaraan));
            Contract.Invariant(!string.IsNullOrEmpty(NomorSeri));
            Contract.Invariant(!string.IsNullOrEmpty(ShelterAwal));
            Contract.Invariant(!string.IsNullOrEmpty(ShelterTujuan));
        }

        public void ReadJSON()
        {
            // Deserialisasi JSON.
            string JsonText = File.ReadAllText("C:\\Users\\Aisha\\Downloads\\TubesKPL_BikeLah\\TubesKPL_BikeLah\\BikeLah_Setel\\Models\\dataPeminjaman.json");

            dynamic JsonObj = JsonConvert.DeserializeObject(JsonText);

            JenisKendaraan = JsonObj.dataPeminjaman.jenisKendaraan;
            NomorSeri = JsonObj.dataPeminjaman.nomorSeri;
            ShelterAwal = JsonObj.dataPeminjaman.shelterAwal;
            ShelterTujuan = JsonObj.dataPeminjaman.shelterAkhir;
        }

        public Kendaraan CariNomorSeri(string NoSeri)
        {
            ReadJSON();

            // Memeriksa input NoSeri yang diberikan oleh user.
            if (NoSeri.Equals(NomorSeri))
            {
                Kendaraan Vhc = new Kendaraan(NomorSeri, JenisKendaraan);

                Contract.Ensures(Contract.Result<Kendaraan>() != null);
                Contract.Ensures(Vhc != null);
                Contract.Ensures(Vhc.NomorSeri == NomorSeri);
                Contract.Ensures(Vhc.JenisKendaraan == JenisKendaraan);

                return Vhc;
            }

            Contract.Ensures(Contract.Result<Kendaraan>() == null);

            return null;
        }

        public void UpdateJumlahTersedia(string NomorSeri, int Jumlah)
        {

        }
    }
}
