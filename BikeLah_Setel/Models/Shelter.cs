using System.Collections.Generic;

namespace BikeLah_Setel.Models
{
    internal class Shelter
    {
        public int IdShelter { get; set; }
        public string NamaShelter { get; set; }
        public string LokasiShelter { get; set; }
        public List<Kendaraan> KendaraanTersedia { get; set; }
    }
}
