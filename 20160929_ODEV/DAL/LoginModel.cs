using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginModel
    {
        IKConnections db;
        public LoginModel()
        {
            db = new IKConnections();
        }

        public List<Kullanici> KullaniciGetir()
        {
            List<Kullanici> _liste = (from k in db.Kullanici
                                      select k).ToList();
            return _liste;
        }

        public KullaniciSifre SifreGetir(int kullaniciID)
        {
            KullaniciSifre sifre = (from k in db.KullaniciSifre
                                where k.KullaniciID==kullaniciID
                                select k).FirstOrDefault();
            return sifre;
        }
    }
}
