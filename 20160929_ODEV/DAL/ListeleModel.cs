using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ListeleModel
    {

        IKConnections db;

        public ListeleModel()
        {
            db = new IKConnections();
        }

        public List<PersonelIletisim> IletisimBilgisiOlanPersoneller()
        {
            List<PersonelIletisim> _personeller = new List<PersonelIletisim>();
            _personeller = (from p in db.PersonelIletisim
                            where p.AktifMi == true
                            select p).ToList();
            return _personeller;
        }
        public List<PersonelEgitim> EgitimBilgisiOlanPersoneller()
        {
            List<PersonelEgitim> _personeller = new List<PersonelEgitim>();
            _personeller = (from p in db.PersonelEgitim
                            where p.AktifMi == true
                            select p).ToList();
            return _personeller;
        }
        public List<Personel> PersonelListele()
        {
            List<Personel> _personeller = new List<Personel>();
            _personeller = (from p in db.Personel
                            where p.AktifMi==true
                            select p).ToList();
            return _personeller;
        }
        public List<Yetki_T> YetkiListele()
        {
            List<Yetki_T> _yetkiler = new List<Yetki_T>();
            _yetkiler = (from y in db.Yetki_T
                         where y.AktifMi == true
                         select y).ToList();
            return _yetkiler;
        }

        public List<YetkiIslem> YetkiIslemListele()
        {
            List<YetkiIslem> _islemler = new List<YetkiIslem>();
            _islemler = (from y in db.YetkiIslem
                         where y.AktifMi == true
                         select y).ToList();
            return _islemler;
        }

        public List<Personel> ButunPersonelListele()
        {
            List<Personel> _personeller = new List<Personel>();
            _personeller = (from p in db.Personel
                            select p).ToList();
            return _personeller;
        }

        public List<PersonelIletisim> PersonelIletisimBilgisi()
        {
            List<PersonelIletisim> _personelIletisim = new List<PersonelIletisim>();
            _personelIletisim = (from pi in db.PersonelIletisim
                                 join semt in db.Semt_T on pi.SemtID equals semt.ID
                                 join ilce in db.Ilce_T on semt.IlceID equals ilce.ID
                                 join sehir in db.Sehir_T on ilce.SehirID equals sehir.ID
                                 where pi.AktifMi==true
                                 select pi).ToList();
            return _personelIletisim;
        }

        public List<PersonelEgitim> PersonelEgitimBilgisi()
        {
            List<PersonelEgitim> _personelEgitim = new List<PersonelEgitim>();
            _personelEgitim = (from pe in db.PersonelEgitim
                               join bolum in db.Bolum on pe.BolumID equals bolum.BolumID
                               join fakulte in db.Fakulte on bolum.FakulteID equals fakulte.FakulteID
                               join okul in db.Okul on fakulte.OkulID equals okul.OkulID
                               where pe.AktifMi==true
                               select pe).ToList();
            return _personelEgitim; 
        }
        public List<Sehir_T> SehirListele()
        {
            List<Sehir_T> _sehiler = new List<Sehir_T>();
            _sehiler = (from s in db.Sehir_T
                        select s).ToList();
            return _sehiler;
        }

        public List<Ilce_T> IlceListele(int SehirID)
        {
            List<Ilce_T> _ilceler = new List<Ilce_T>();
            _ilceler = (from i in db.Ilce_T
                        where i.SehirID==SehirID
                        select i).ToList();
            return _ilceler;
        }

        public List<Semt_T> SemtlerListele(int IlceID)
        {
            List<Semt_T> _semtler = new List<Semt_T>();
            _semtler = (from s in db.Semt_T
                        where s.IlceID == IlceID
                        select s).ToList();
            return _semtler;
        }

        public List<AracMarka> AracMarkalariListele()
        {
            List<AracMarka> _markalar = new List<AracMarka>();
            _markalar = (from marka in db.AracMarka
                         select marka).ToList();
            return _markalar;
        }

        public List<AracModel> AracModelleriListele(int MarkaID)
        {
            List<AracModel> _modeller = new List<AracModel>();
            _modeller = (from model in db.AracModel
                         where model.MarkaID == MarkaID
                         select model).ToList();
            return _modeller;
        }
        public List<Araclar> AraclariListele()
        {
            List<Araclar> _araclar = new List<Araclar>();
            _araclar = (from arac in db.Araclar
                        where arac.AktifMi==true
                        select arac).ToList();
            return _araclar;
        }
        public List<Departman_T> DepartmanListele()
        {
            List<Departman_T> _departmanlar = new List<Departman_T>();
            _departmanlar = (from s in db.Departman_T
                             where s.AktifMi==true
                             select s).ToList();
            return _departmanlar;
        }
        public List<Birim_T> BirimleriListele(int _departmanID)
        {
            List<Birim_T> _birimler = new List<Birim_T>();
            _birimler = (from birim in db.Birim_T
                         join di in db.DepartmanIslem on birim.ID equals di.BirimID
                         where di.DerpartmanID == _departmanID && birim.AktifMi==true
                         select birim).ToList();
            return _birimler;
        }
        public Birim_T PersoneleAitBirim(Personel personel)
        {
            Birim_T _birim = new Birim_T();
            _birim = (from islem in db.BirimIslem
                      join birim in db.Birim_T on islem.BirimID equals birim.ID
                      where islem.AktifMi == true && islem.PersonelID == personel.ID
                      select birim).FirstOrDefault();
            return _birim;
        }
        public List<BirimIslem> AktifBirimIslemListele()
        {
            List<BirimIslem> _islemler = new List<BirimIslem>();
            _islemler = (from islem in db.BirimIslem
                        where islem.AktifMi==true
                        select islem).ToList();
            return _islemler;
        }
        public Departman_T BiriminDepartmani(int birimID)
        {
            Departman_T _departman = new Departman_T();
            _departman = (from di in db.DepartmanIslem
                          join departman in db.Departman_T on di.DerpartmanID equals departman.ID
                          where di.BirimID == birimID && di.AktifMi==true
                          select departman).FirstOrDefault();
            return _departman;
        }
        public List<Okul> OkulListele()
        {
            List<Okul> _okullar = new List<Okul>();
            _okullar = (from s in db.Okul
                        select s).ToList();
            return _okullar;

        }

        public List<Fakulte> FakulteListele(int UniversiteID)
        {
            List<Fakulte> _fakulteler = new List<Fakulte>();
            _fakulteler = (from f in db.Fakulte
                           where f.OkulID==UniversiteID
                           select f).ToList();
            return _fakulteler;
        }

        public List<Bolum> BolumListele(int FakulteID)
        {
            List<Bolum> _bolumler = new List<Bolum>();
            _bolumler = (from b in db.Bolum
                         where b.FakulteID == FakulteID
                         select b).ToList();
            return _bolumler;
        }
        public List<Unvan> UnvanListele()
        {
            List<Unvan> _unvanlar = new List<Unvan>();
            _unvanlar = (from u in db.Unvan
                         select u).ToList();
            return _unvanlar;
        }

        public List<UnvanIslem> UnvanIslemListele()
        {
            List<UnvanIslem> _islemler = new List<UnvanIslem>();
            _islemler = (from islem in db.UnvanIslem
                         join unvan in db.Unvan on islem.UnvanID equals unvan.ID
                         where islem.AktifMi == true
                         select islem).ToList();
            return _islemler;
        }

        public List<IzinTur> IzinTurleriListele()
        {
            List<IzinTur> _turler = new List<IzinTur>();
            _turler = (from tur in db.IzinTur
                       where tur.AktifMi == true
                       select tur).ToList();
            return _turler;
        }

        public List<PrimCesidi> PrimCesidiListele()
        {
            List<PrimCesidi> _cesitler = new List<PrimCesidi>();
            _cesitler = (from cesit in db.PrimCesidi
                         where cesit.AktifMi == true
                         select cesit).ToList();
            return _cesitler;
        }

        public PersonelGirisCikis PersonelinGirisCikisiListele(int _PersonelID)
        {
            PersonelGirisCikis girisCikis = new PersonelGirisCikis();
            girisCikis = (from t in db.PersonelGirisCikis
                          where t.PersonelID == _PersonelID
                          orderby t.IseBaslamaTarihi descending
                          select t).First();
            return girisCikis;
        }
        public List<PersonelAyrintiEntity> PersonelAyrintiListele()
        {
            var data = (from p in db.Personel
                        join pi in db.PersonelIletisim on p.ID equals pi.PersonelID
                        join ui in db.UnvanIslem on p.ID equals ui.PersonelID
                        join u in db.Unvan on ui.UnvanID equals u.ID
                        join bi in db.BirimIslem on p.ID equals bi.PersonelID
                        join b in db.Birim_T on bi.BirimID equals b.ID
                        join di in db.DepartmanIslem on b.ID equals di.BirimID
                        join d in db.Departman_T on di.DerpartmanID equals d.ID
                        where p.AktifMi == true && pi.AktifMi == true && ui.AktifMi == true && bi.AktifMi == true && b.AktifMi == true && di.AktifMi == true && d.AktifMi == true
                        select new PersonelAyrintiEntity
                        {
                            PersonelID = p.ID,
                            PersonelAdi = p.Adi,
                            PersonelSoyadi = p.Soyadi,
                            TCNo = p.TCNo,
                            CepTel = pi.CepTel,
                            UnvanAdi = u.UnvanAdi,
                            DepartmanAdi = d.DepartmanAdi,
                            BirimAdi = b.BirimAdi
                        }).ToList();
            return data;
        }

        public List<PersonelMaaslariEntity> PersonelMaaslariListele()
        {
            var data = (from p in db.Personel
                        join mi in db.MaasIslem on p.ID equals mi.PersonelID
                        join m in db.Maas_T on mi.MaasID equals m.MaasID
                        where p.AktifMi == true && m.AktifMi==true
                        select new PersonelMaaslariEntity
                        {
                            PersonelID = p.ID,
                            PersonelAdi = p.Adi,
                            PersonelSoyadi = p.Soyadi,
                            TCNo = p.TCNo,
                            MaasTutari = m.MaasTutari,
                            MaasTarihi = mi.MaasTarihi,
                        }).ToList();
            return data;
        }
        public List<PersonelIzinleriEntity> PersonelIzinleriListele()
        {
            var data = (from p in db.Personel
                        join pi in db.PersonelIzin on p.ID equals pi.PersonelID
                        join izin in db.IzinTur on pi.IzinTurID equals izin.IzinTurID
                        where p.AktifMi == true && pi.AktifMi == true && izin.AktifMi == true
                        select new PersonelIzinleriEntity
                        {
                            PersonelID = p.ID,
                            PersonelAdi = p.Adi,
                            PersonelSoyadi = p.Soyadi,
                            TCNo = p.TCNo,
                            IzinTuru = izin.IzinTuru,
                            IzinBaslangic = pi.IzinBasTarihi,
                            IzinBitis = pi.IzinBitisTarihi
                        }).ToList();
            return data;
        }
        public List<PersonelAracTahsisleriEntity> PersonelAracTahsisleriListele()
        {
            var data = (from p in db.Personel
                        join pa in db.AracPersonel on p.ID equals pa.PersonelID
                        join arac in db.Araclar on pa.AracID equals arac.AracID
                        join model in db.AracModel on arac.ModelID equals model.ModelID
                        join marka in db.AracMarka on model.MarkaID equals marka.MarkaID
                        where p.AktifMi == true && pa.AktifMi == true && arac.AktifMi == true && model.AktifMi == true && marka.AktifMi == true
                        select new PersonelAracTahsisleriEntity
                        {
                            PersonelID = p.ID,
                            PersonelAdi = p.Adi,
                            PersonelSoyadi = p.Soyadi,
                            TCNo = p.TCNo,
                            Plaka = arac.Plaka,
                            AlinanTarih = pa.AldigiTarih,
                            BirakilanTarih = pa.BiraktigiTarih,
                            Marka = marka.Marka,
                            Model = model.Model
                        }).ToList();
            return data;
        }
        public List<Maas_T> MaasListele()
        {
            List<Maas_T> maasListe = new List<Maas_T>();
            maasListe = (from m in db.Maas_T where m.AktifMi == true select m).ToList();
            return maasListe;
        }
    }
}
