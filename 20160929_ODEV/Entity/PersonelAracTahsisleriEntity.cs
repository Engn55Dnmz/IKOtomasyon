using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PersonelAracTahsisleriEntity
    {
        public int PersonelID { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public string TCNo { get; set; }
        public string Plaka { get; set; }
        public DateTime? AlinanTarih { get; set; }
        public DateTime? BirakilanTarih { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
    }
}
