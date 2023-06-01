using BikeLah_Setel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeLah_Setel.Controllers
{
    internal class PeminjamanController
    {
        public PeminjamanModel BrwModel;
        public KendaraanModel VhcModel;

        public PeminjamanController()
        {
            VhcModel = new KendaraanModel();
            BrwModel = new PeminjamanModel();
        }

        public void ShowHistory()
        {
            foreach (var peminjaman in BrwModel.GetHistory())
            {
                Console.WriteLine("Id Peminjaman\t: " + peminjaman.IdPeminjaman);
                Console.WriteLine("Unit Kendaraan\t: " + peminjaman.NomorSeriKendaraan);
                Console.WriteLine("Waktu Peminjaman\t: " + peminjaman.WaktuPeminjaman);
                Console.WriteLine("Waktu Pengembalian\t: " + peminjaman.WaktuPengembalian);

                if (peminjaman.StatusPengembalian.Equals(true))
                {
                    Console.WriteLine("Status Pengembalian\t: Sudah dikembalikan.");
                } else
                {
                    Console.WriteLine("Status Pengembalian\t: Belum dikembalikan.");
                }
                
            }
        }

        public void CreatePeminjaman(String UserID, string NomorSeri)
        {
            DateTime now = DateTime.Now;
            Kendaraan Brw = VhcModel.CariNomorSeri(NomorSeri);
            List<Peminjaman> DataPinjam = new List<Peminjaman>();

            BrwModel.TambahPeminjaman(DataPinjam, 1, Brw.NomorSeri, now, now, UserID, true);
        }
    }
}
