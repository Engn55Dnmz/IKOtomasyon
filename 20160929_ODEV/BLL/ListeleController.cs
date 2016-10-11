using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ListeleController
    {
        ListeleModel _listeleModel;
        public ListeleController()
        {
            _listeleModel = new ListeleModel();
        }

        public List<PersonelAyrintiEntity> PersonelAyrintiListele()
        {
            return _listeleModel.PersonelAyrintiListele();
        }
        public List<PersonelMaaslariEntity> PersonelMaaslariListele()
        {
            return _listeleModel.PersonelMaaslariListele();
        }
        public List<PersonelIzinleriEntity> PersonelIzinleriListele()
        {
            return _listeleModel.PersonelIzinleriListele();
        }
        public List<PersonelAracTahsisleriEntity> PersonelAracTahsisleriListele()
        {
            return _listeleModel.PersonelAracTahsisleriListele();
        }
        public List<Personel> PersonelListele()
        {
            List<Personel> _personeller = new List<Personel>();
            _personeller = _listeleModel.PersonelListele();
            return _personeller;
        }

        public List<Personel> ButunPersonelListele()
        {
            List<Personel> _personeller = new List<Personel>();
            _personeller = _listeleModel.ButunPersonelListele();
            return _personeller;
        }
        public List<Yetki_T> YetkiListele()
        {
            List<Yetki_T> _yetkiler = new List<Yetki_T>();
            _yetkiler = _listeleModel.YetkiListele();
            return _yetkiler;
        }
        public PersonelIletisim PersonelIletisimListele(Personel nesne)
        {
            PersonelIletisim _personelIltisim = new PersonelIletisim();
            List<PersonelIletisim> _IleitismBilgileri = new List<PersonelIletisim>();
            _IleitismBilgileri = _listeleModel.PersonelIletisimBilgisi();
            foreach (PersonelIletisim item in _IleitismBilgileri)
            {
                if (item.PersonelID==nesne.ID)
                {
                    _personelIltisim = item;
                    break;
                }
                else
                {
                    _personelIltisim = null;
                }
            }
            return _personelIltisim;
        }

        public PersonelEgitim PersonelEgitimListele(Personel nesne)
        {
            PersonelEgitim _personelEgitim = new PersonelEgitim();
            List<PersonelEgitim> _EgitimBilgileri = new List<PersonelEgitim>();
            _EgitimBilgileri = _listeleModel.PersonelEgitimBilgisi();
            foreach (PersonelEgitim item in _EgitimBilgileri)
            {
                if (item.PersonelID == nesne.ID)
                {
                    _personelEgitim = item;
                    break;
                }
                else
                {
                    _personelEgitim = null;
                }
            }
            return _personelEgitim;
        }

        public List<Sehir_T> SehirlerListele()
        {
            List<Sehir_T> _sehirler = new List<Sehir_T>();
            _sehirler = _listeleModel.SehirListele();
            return _sehirler;
        }

        public List<Ilce_T> IlcelerListele(int SehirID)
        {
            List<Ilce_T> _ilceler = new List<Ilce_T>();
            _ilceler = _listeleModel.IlceListele(SehirID);
            return _ilceler;
        }

        public List<Semt_T> SemtlerListele(int IlceID)
        {
            List<Semt_T> _semtler = new List<Semt_T>();
            _semtler = _listeleModel.SemtlerListele(IlceID);
            return _semtler;
        }

        public List<AracMarka> AracMarkalariListele()
        {
            List<AracMarka> _markalar = new List<AracMarka>();
            _markalar = _listeleModel.AracMarkalariListele();
            return _markalar;
        }
        public List<AracModel> AracModelleriListele(int MarkaID)
        {
            List<AracModel> _modeller = new List<AracModel>();
            _modeller = _listeleModel.AracModelleriListele(MarkaID);
            return _modeller;
        }
        public List<Araclar> AraclarListele()
        {
            List<Araclar> _araclar = new List<Araclar>();
            _araclar = _listeleModel.AraclariListele();
            return _araclar;
        }
        public List<Departman_T> DepartmanListele()
        {
            List<Departman_T> _departmanlar = new List<Departman_T>();
            _departmanlar = _listeleModel.DepartmanListele();
            return _departmanlar;

        }
        public List<Birim_T> BirimListele(int _departmanID)
        {
            List<Birim_T> _birimler = new List<Birim_T>();
            _birimler = _listeleModel.BirimleriListele(_departmanID);
            return _birimler;
        }
        public Birim_T PersoneleAitBirim(Personel personel)
        {
            Birim_T _birim = new Birim_T();
            _birim = _listeleModel.PersoneleAitBirim(personel);
            return _birim;
        }

        public Departman_T BiriminDepartmani(Birim_T birim)
        {
            Departman_T _departman = new Departman_T();
            _departman = _listeleModel.BiriminDepartmani(birim.ID);
            return _departman;
        }
        public List<Okul> OkulListele()
        {
            List<Okul> _okullar = new List<Okul>();
            _okullar = _listeleModel.OkulListele();
            return _okullar;
        }

        public List<Fakulte> FakulteListele(int UniversiteID)
        {
            List<Fakulte> _fakulteler = new List<Fakulte>();
            _fakulteler = _listeleModel.FakulteListele(UniversiteID);
            return _fakulteler;
        }

        public List<Bolum> BolumListele(int FakulteID)
        {
            List<Bolum> _bolumler = new List<Bolum>();
            _bolumler = _listeleModel.BolumListele(FakulteID);
            return _bolumler;
        }

        public List<Unvan> UnvanListele()
        {
            List<Unvan> _unvan = new List<Unvan>();
            _unvan = _listeleModel.UnvanListele();
            return _unvan;
        }

        public Unvan UnvanListele(Personel _personel)
        {
            Unvan _unvan = new Unvan();
            List<UnvanIslem> _PersonelUnvanlari = new List<UnvanIslem>();
            _PersonelUnvanlari = _listeleModel.UnvanIslemListele();
            foreach (UnvanIslem item in _PersonelUnvanlari)
            {
                if (item.PersonelID == _personel.ID)
                {
                    _unvan = item.Unvan;
                    break;
                }
                else
                {
                    _unvan = null;
                }
            }
            return _unvan;
        }

        public List<IzinTur> IzinTurleriListele()
        {
            List<IzinTur> _turler = new List<IzinTur>();
            _turler = _listeleModel.IzinTurleriListele();
            return _turler;
        }
        public List<PrimCesidi> PrimCesidiListele()
        {
            List<PrimCesidi> _cesitler = new List<PrimCesidi>();
            _cesitler = _listeleModel.PrimCesidiListele();
            return _cesitler;
        }

        public PersonelGirisCikis PersonelinGirisCikisiListele(Personel _Personel)
        {
            PersonelGirisCikis girisCikis = new PersonelGirisCikis();
            girisCikis = _listeleModel.PersonelinGirisCikisiListele(_Personel.ID);
            return girisCikis;
        }
        public List<Maas_T> MaasListele()
        {
            List<Maas_T> maasListe = new List<Maas_T>();
            maasListe = _listeleModel.MaasListele();
            return maasListe;
        }
    }
}
