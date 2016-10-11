using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EkleController
    {
        EkleModel _ekleModel;
        AktifPasifModel _aktifPasif;
        ListeleModel _listele;
        GuncelleModel _guncelleModel;
        public EkleController()
        {
            _ekleModel = new EkleModel();
            _aktifPasif = new AktifPasifModel();
            _listele = new ListeleModel();
            _guncelleModel = new GuncelleModel();
        }
        public int EklemeyeGonder(object nesne)
        {
            int newID = 0;
            if (nesne is PersonelIletisim)
            {
                List<PersonelIletisim> _personeller = new List<PersonelIletisim>();
                _personeller = _listele.IletisimBilgisiOlanPersoneller();
                foreach (PersonelIletisim item in _personeller)
                {
                    if (item.PersonelID == ((PersonelIletisim)nesne).PersonelID)
                    {
                        if (item.CepTel != ((PersonelIletisim)nesne).CepTel || item.EvTel != ((PersonelIletisim)nesne).EvTel || item.EMail != ((PersonelIletisim)nesne).EMail || item.SemtID != ((PersonelIletisim)nesne).SemtID || item.AcikAdres != ((PersonelIletisim)nesne).AcikAdres)
                        {
                            _aktifPasif.AktifPasifYap(item);
                        }
                        else
                        {
                            return newID;
                        }
                    }
                }
            }
            else if (nesne is PersonelEgitim)
            {
                List<PersonelEgitim> _personeller = new List<PersonelEgitim>();
                _personeller = _listele.EgitimBilgisiOlanPersoneller();
                foreach (PersonelEgitim item in _personeller)
                {
                    if (item.PersonelID == ((PersonelEgitim)nesne).PersonelID)
                    {
                        if (item.BolumID != ((PersonelEgitim)nesne).BolumID)
                        {
                            _aktifPasif.AktifPasifYap(item);
                        }
                        else
                        {
                            return newID;
                        }
                    }
                }
            }
            else if (nesne is Araclar)
            {
                List<Araclar> _araclar = new List<Araclar>();
                _araclar = _listele.AraclariListele();
                foreach (Araclar item in _araclar)
                {
                    if (item.Plaka == ((Araclar)nesne).Plaka)
                    {
                        _aktifPasif.AktifPasifYap((Araclar)nesne);
                        break;
                    }
                }
            }
            else if (nesne is BirimIslem)
            {
                List<BirimIslem> _islemler = new List<BirimIslem>();
                _islemler = _listele.AktifBirimIslemListele();
                foreach (BirimIslem item in _islemler)
                {
                    if (item.PersonelID == ((BirimIslem)nesne).PersonelID)
                    {
                        _aktifPasif.AktifPasifYap((BirimIslem)nesne);
                        break;
                    }
                }
            }
            else if (nesne is UnvanIslem)
            {
                List<UnvanIslem> _islemler = new List<UnvanIslem>();
                _islemler = _listele.UnvanIslemListele();
                foreach (UnvanIslem item in _islemler)
                {
                    if (item.PersonelID == ((UnvanIslem)nesne).PersonelID)
                    {
                        _aktifPasif.AktifPasifYap((UnvanIslem)nesne);
                        break;
                    }
                }
            }
            else if (nesne is YetkiIslem)
            {
                List<YetkiIslem> _islemler = new List<YetkiIslem>();
                _islemler = _listele.YetkiIslemListele();
                foreach (YetkiIslem item in _islemler)
                {
                    if (item.PersonelID == ((YetkiIslem)nesne).PersonelID)
                    {
                        _aktifPasif.AktifPasifYap((YetkiIslem)nesne);
                        break;
                    }
                }
            }

            newID = _ekleModel.TabloyaEkle(nesne);
            return newID;
        }

        public void EklemeyeGonder(object nesne, bool aktifMi)
        {
            if (aktifMi)
            {
                if (nesne is PersonelGirisCikis)
                {
                    _guncelleModel.VeriyiGuncelle(nesne);
                }
            }
            else
            {
                if (nesne is PersonelGirisCikis)
                {
                    ((PersonelGirisCikis)nesne).IstenCikmaTarihi = null;
                    _ekleModel.TabloyaEkle(nesne);
                }
            }
            _aktifPasif.AktifPasifYap(((PersonelGirisCikis)nesne).PersonelID);
        }

    }
}
