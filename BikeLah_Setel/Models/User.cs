using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeLah_Setel.Models
{
    internal class User
    {
        public string Username { get; set; }
        public int Password { get; set; }
        public string NamaLengkap { get; set; }
        public int Id { get; set; }
        public string Role { get; set; }
        public string Jurusan { get; set; }
        public int Angkatan { get; set; }
        public string Gender { get; set; } 
        public string Nik { get; set; }
        public string NomorHP { get; set; }
        public string Email { get; set; }
        public string EmailInstitusi { get; set; }

    }
}
