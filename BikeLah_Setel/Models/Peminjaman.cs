using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeLah_Setel.Models
{
    internal class Peminjaman
    {
        public int IdPeminjaman { get; set; }
        public string NomorSeriKendaraan { get; set; }
        public DateTime WaktuPeminjaman { get; set; }
        public DateTime WaktuPengembalian { get; set; }
        public string NamaPeminjam { get; set; }
        public bool StatusPengembalian { get; set; }
        public string ShelterAwal { get; set; }
        public string ShelterAkhir { get; set; }
        public string nomorSeri { get; set; }
        public string jenisKendaraan { get; set; }

    }
}
