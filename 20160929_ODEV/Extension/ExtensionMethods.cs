using System;
using Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extension
{
    public class ExtensionMethods
    {
        public void ComboDoldur(object nesne, ComboBox cmb)
        {
            if (nesne is List<Personel>)
            {
                cmb.DataSource = nesne;
                cmb.DisplayMember = "Adi";
                cmb.ValueMember = "ID";
            }
            else if (nesne is List<Sehir_T>)
            {
                cmb.DataSource = nesne;
                cmb.DisplayMember = "SehirAdi";
                cmb.ValueMember = "ID";
            }
            else if (nesne is List<Ilce_T>)
            {
                cmb.DataSource = nesne;
                cmb.DisplayMember = "IlceAdi";
                cmb.ValueMember = "ID";
            }
            else if (nesne is List<Semt_T>)
            {
                cmb.DataSource = nesne;
                cmb.DisplayMember = "SemtAdi";
                cmb.ValueMember = "ID";
            }
            else if (nesne is List<AracMarka>)
            {
                cmb.DataSource = nesne;
                cmb.DisplayMember = "Marka";
                cmb.ValueMember = "MarkaID";
            }
            else if (nesne is List<AracModel>)
            {
                cmb.DataSource = nesne;
                cmb.DisplayMember = "Model";
                cmb.ValueMember = "ModelID";
            }
            else if (nesne is List<Araclar>)
            {
                cmb.DataSource = nesne;
                cmb.DisplayMember = "Plaka";
                cmb.ValueMember = "AracID";
            }
            else if (nesne is List<Okul>)
            {
                cmb.DataSource = nesne;
                cmb.DisplayMember = "OkulAdi";
                cmb.ValueMember = "OkulID";
            }
            else if (nesne is List<Fakulte>)
            {
                cmb.DataSource = nesne;
                cmb.DisplayMember = "FakulteAdi";
                cmb.ValueMember = "FakulteID";
            }
            else if (nesne is List<Bolum>)
            {
                cmb.DataSource = nesne;
                cmb.DisplayMember = "BolumAdi";
                cmb.ValueMember = "BolumID";
            }
            else if (nesne is List<Unvan>)
            {
                cmb.DataSource = nesne;
                cmb.DisplayMember = "UnvanAdi";
                cmb.ValueMember = "ID";
            }
            else if (nesne is List<IzinTur>)
            {
                cmb.DataSource = nesne;
                cmb.DisplayMember = "IzinTuru";
                cmb.ValueMember = "IzinTurID";
            }
            else if (nesne is List<Birim_T>)
            {
                cmb.DataSource = nesne;
                cmb.DisplayMember = "BirimAdi";
                cmb.ValueMember = "ID";
            }
            else if (nesne is List<Departman_T>)
            {
                cmb.DataSource = nesne;
                cmb.DisplayMember = "DepartmanAdi";
                cmb.ValueMember = "ID";
            }
            else if (nesne is List<PrimCesidi>)
            {
                cmb.DataSource = nesne;
                cmb.DisplayMember = "PrimCesidi1";
                cmb.ValueMember = "PrimID";
            }
            else if (nesne is List<Maas_T>)
            {
                cmb.DataSource = nesne;
                cmb.DisplayMember = "MaasTutari";
                cmb.ValueMember = "MaasID";
            }
           
        }

        public PersonelIletisim IletisimEklemeyeGonder(int PersonelID, string CepTel, string EvTel, string EMail, int SemtID, string AcikAdres, bool AktifMi)
        {
            PersonelIletisim nesne = new PersonelIletisim();
            nesne.PersonelID = PersonelID;
            nesne.CepTel = CepTel;
            nesne.EvTel = EvTel;
            nesne.EMail = EMail;
            nesne.SemtID = SemtID;
            nesne.AcikAdres = AcikAdres;
            nesne.AktifMi = AktifMi;
            return nesne;
        }

        public void CmbSifirla(ComboBox cmb)
        {
            cmb.DataSource = null;
            //cmb.ValueMember = null;
            //cmb.DisplayMember = null;
            cmb.Items.Clear();
        }


    }
}
