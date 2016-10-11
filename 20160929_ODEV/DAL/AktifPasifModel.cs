using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AktifPasifModel
    {
        IKConnections db;
        public AktifPasifModel()
        {
            db = new IKConnections();
        }

        public void AktifPasifYap(object nesne)
        {
            if (nesne is PersonelIletisim)
            {
                PersonelIletisim iletisim = (from p in db.PersonelIletisim
                                             where p.ID == ((PersonelIletisim)nesne).ID
                                             select p).FirstOrDefault();
                iletisim.AktifMi = false;
                db.SaveChanges();
            }
            else if (nesne is PersonelEgitim)
            {
                PersonelEgitim egitim = (from p in db.PersonelEgitim
                                         where p.ID == ((PersonelEgitim)nesne).ID
                                         select p).FirstOrDefault();
                egitim.AktifMi = false;
                db.SaveChanges();
            }
            else if (nesne is UnvanIslem)
            {
                UnvanIslem islem = (from p in db.UnvanIslem
                                    where p.PersonelID == ((UnvanIslem)nesne).PersonelID && p.UnvanID == ((UnvanIslem)nesne).UnvanID
                                    select p).FirstOrDefault();
                islem.AktifMi = false;
                db.SaveChanges();
            }
            else if (nesne is Araclar)
            {
                Araclar arac = (from a in db.Araclar
                                where a.AracID == ((Araclar)nesne).AracID
                                select a).FirstOrDefault();
                arac.AktifMi = false;
                db.SaveChanges();
            }
            else if (nesne is BirimIslem)
            {
                BirimIslem islem = (from p in db.BirimIslem
                                    where p.PersonelID == ((BirimIslem)nesne).PersonelID && p.BirimID == ((BirimIslem)nesne).BirimID
                                    select p).FirstOrDefault();
                islem.AktifMi = false;
                db.SaveChanges();
            }
            else if (nesne is int)
            {
                Personel personel = (from p in db.Personel
                                     where p.ID == ((int)nesne)
                                     select p).FirstOrDefault();
                personel.AktifMi = !(personel.AktifMi);
                db.SaveChanges();
            }
            else if (nesne is YetkiIslem)
            {
                YetkiIslem islem = (from p in db.YetkiIslem
                                    where p.PersonelID == ((YetkiIslem)nesne).PersonelID && p.AktifMi==true
                                    select p).FirstOrDefault();
                islem.AktifMi = false;
                db.SaveChanges();
            }
        }
    }
}
