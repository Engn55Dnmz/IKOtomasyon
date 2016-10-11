using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginController
    {
        LoginModel lm;
        public LoginController()
        {
            lm = new LoginModel();
        }

        public bool[] KullanıcıKontrol(string kullaniciAdi, string sifre)
        {
            List<Kullanici> _list = lm.KullaniciGetir();
            bool[] giris = new bool[2]{false,false};
            foreach (Kullanici item in _list)
            {
                if (item.KullaniciAdi == kullaniciAdi)
                {
                    KullaniciSifre sifreTemp = lm.SifreGetir(item.KullaniciID);
                    if (sifreTemp.Sifre == sifre)
                    {
                        giris[0] = true;
                        giris[1] = item.AdminMi;
                    }
                }
            }
            return giris;
        }
    }
}
