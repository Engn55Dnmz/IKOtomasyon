using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PersonelIzinleriEntity
    {
        public int PersonelID { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public string TCNo { get; set; }
        public string IzinTuru { get; set; }
        public DateTime? IzinBaslangic { get; set; }
        public DateTime? IzinBitis { get; set; }
    }
}
