using System.Collections.Generic;

namespace BikeLah_Setel.Models
{
    internal class Shelter
    {
        public int IdShelter { get; set; }
        public string NamaShelter { get; set; }
        public string LokasiShelter { get; set; }
        public List<Kendaraan> KendaraanTersedia { get; set; }

        public Shelter(int idShelter, string namaShelter, string lokasiShelter, List<Kendaraan> kendaraanTersedia)
        {
            IdShelter = idShelter;
            NamaShelter = namaShelter;
            LokasiShelter = lokasiShelter;
            KendaraanTersedia = kendaraanTersedia;
        }
    }
}
