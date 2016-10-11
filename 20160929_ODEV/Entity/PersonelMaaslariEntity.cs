using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PersonelMaaslariEntity
    {
        public int PersonelID { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public string TCNo { get; set; }
        public decimal MaasTutari { get; set; }
        public DateTime? MaasTarihi { get; set; }
    }
}
