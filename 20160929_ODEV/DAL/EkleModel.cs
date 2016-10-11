using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EkleModel
    {
        IKConnections db;
        public EkleModel()
        {
            db = new IKConnections();
        }

        public int TabloyaEkle(object nesne)
        {
            int newPK = 0;
            if (nesne is Personel)
            {
                db.Personel.Add((Personel)nesne);
                //int newPK = _personel.ID;  //son eklenen ID
            }
            else if (nesne is PersonelIletisim)
            {
                db.PersonelIletisim.Add((PersonelIletisim)nesne);
            }
            else if (nesne is PersonelEgitim)
            {
                db.PersonelEgitim.Add((PersonelEgitim)nesne);
            }
            else if (nesne is UnvanIslem)
            {
                db.UnvanIslem.Add((UnvanIslem)nesne);
            }
            else if (nesne is AracPersonel)
            {
                db.AracPersonel.Add((AracPersonel)nesne);
            }
            else if (nesne is PersonelIzin)
            {
                db.PersonelIzin.Add((PersonelIzin)nesne);
            }
            else if (nesne is BirimIslem)
            {
                db.BirimIslem.Add((BirimIslem)nesne);
            }
            else if (nesne is Sehir_T)
            {
                db.Sehir_T.Add((Sehir_T)nesne);
            }
            else if (nesne is Ilce_T)
            {
                db.Ilce_T.Add((Ilce_T)nesne);
            }
            else if (nesne is Semt_T)
            {
                db.Semt_T.Add((Semt_T)nesne);
            }
            else if (nesne is Departman_T)
            {
                db.Departman_T.Add((Departman_T)nesne);
            }
            else if (nesne is Birim_T)
            {
                db.Birim_T.Add((Birim_T)nesne);
                db.SaveChanges();
                newPK = ((Birim_T)nesne).ID;
            }
            else if (nesne is DepartmanIslem)
            {
                db.DepartmanIslem.Add((DepartmanIslem)nesne);
            }
            else if (nesne is AracMarka)
            {
                db.AracMarka.Add((AracMarka)nesne);
            }
            else if (nesne is AracModel)
            {
                db.AracModel.Add((AracModel)nesne);
            }
            else if (nesne is Araclar)
            {
                db.Araclar.Add((Araclar)nesne);
            }
            else if (nesne is Okul)
            {
                db.Okul.Add((Okul)nesne);
            }
            else if (nesne is Fakulte)
            {
                db.Fakulte.Add((Fakulte)nesne);
            }
            else if (nesne is Bolum)
            {
                db.Bolum.Add((Bolum)nesne);
            }
            else if (nesne is IzinTur)
            {
                db.IzinTur.Add((IzinTur)nesne);
            }
            else if (nesne is PrimCesidi)
            {
                db.PrimCesidi.Add((PrimCesidi)nesne);
            }
            else if (nesne is PrimIslem)
            {
                db.PrimIslem.Add((PrimIslem)nesne);
            }
            else if (nesne is Maas_T)
            {
                db.Maas_T.Add((Maas_T)nesne);
            }
            else if (nesne is Unvan)
            {
                db.Unvan.Add((Unvan)nesne);
            }
            else if (nesne is Kullanici)
            {
                db.Kullanici.Add((Kullanici)nesne);
                db.SaveChanges();
                newPK = ((Kullanici)nesne).KullaniciID;
            }
            else if (nesne is KullaniciSifre)
            {
                db.KullaniciSifre.Add((KullaniciSifre)nesne);
            }
            else if (nesne is PersonelGirisCikis)
            {
                db.PersonelGirisCikis.Add((PersonelGirisCikis)nesne);
            }
            else if (nesne is MaasIslem)
            {
                db.MaasIslem.Add((MaasIslem)nesne);
            }
            db.SaveChanges();
            return newPK;
        }

    }
}
