using System;
using Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GuncelleModel
    {
        IKConnections db;
        public GuncelleModel()
        {
            db = new IKConnections();
        }
        public void VeriyiGuncelle(object nesne)
        {
            if (nesne is PersonelGirisCikis)
            {
                PersonelGirisCikis girisCikis = new PersonelGirisCikis();
                girisCikis = (from t in db.PersonelGirisCikis
                              where t.PersonelID == ((PersonelGirisCikis)nesne).PersonelID
                              orderby t.IseBaslamaTarihi descending
                              select t).First();
                girisCikis.IstenCikmaTarihi = ((PersonelGirisCikis)nesne).IstenCikmaTarihi;
                db.SaveChanges();
            }
        }
    }
}
