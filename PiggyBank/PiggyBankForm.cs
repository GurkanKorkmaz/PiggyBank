using PiggyBank.Abstract;
using PiggyBank.Concrete;
using PiggyBank.ExceptionLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PiggyBank
{
    public partial class PiggyBankForm : Form
    {
        #region Fields

        private readonly List<KagitPara> KagitParalar;
        private readonly List<BozukPara> BozukParalar;

        Kumbara kumbara;
        Para secilenPara;
        bool katlandiMi = false;
        double toplamMinHacim = 0;
        double toplamFazlaHacim = 0;
        double katlanmisParaHacmi = 0;
        int kumbaraKirilmaSayisi = 0;

        #endregion

        #region Constructor

        public PiggyBankForm()
        {
            InitializeComponent();

            if (KagitParalar == null)
            {
                KagitParalar = new List<KagitPara>();
            }

            if (BozukParalar == null)
            {
                BozukParalar = new List<BozukPara>();
            }

            if (kumbara == null)
            {
                kumbara = new Kumbara(75000);
            }
        }

        #endregion

        #region Methods

        private void PiggyBankForm_Load(object sender, EventArgs e)
        {
            BozukParalar.Add(new BozukPara() { Ad = "1 Kuruş", Miktar = 0.01, Cap = 16.50, Yukseklik = 1.35 });
            BozukParalar.Add(new BozukPara() { Ad = "5 Kuruş", Miktar = 0.05, Cap = 17.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Ad = "10 Kuruş", Miktar = 0.10, Cap = 18.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Ad = "25 Kuruş", Miktar = 0.25, Cap = 20.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Ad = "50 Kuruş", Miktar = 0.50, Cap = 23.85, Yukseklik = 1.90 });
            BozukParalar.Add(new BozukPara() { Ad = "1 Lira", Miktar = 1.0, Cap = 26.15, Yukseklik = 1.90 });

            KagitParalar.Add(new KagitPara() { Ad = "5 Lira", Miktar = 5.0, En = 64.0, Boy = 130.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "10 Lira", Miktar = 10.0, En = 64.0, Boy = 136.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "20 Lira", Miktar = 20.0, En = 68.0, Boy = 142.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "50 Lira", Miktar = 50.0, En = 68.0, Boy = 148.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "100 Lira", Miktar = 100.0, En = 72.0, Boy = 154.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "200 Lira", Miktar = 200.0, En = 72.0, Boy = 160.0, Yukseklik = 0.25 });

            cmbKagitPara.Items.Add("Seçiniz");
            foreach (var item in KagitParalar)
            {
                cmbKagitPara.Items.Add(item.Ad);
            }
            cmbKagitPara.SelectedIndex = 0;

            cmbBozukPara.Items.Add("Seçiniz");
            foreach (var item in BozukParalar)
            {
                cmbBozukPara.Items.Add(item.Ad);
            }
            cmbBozukPara.SelectedIndex = 0;
        }

        private void btnParaAt_Click(object sender, EventArgs e)
        {
            try
            {
                if (kumbaraKirilmaSayisi > 1)
                {
                    throw new KumbaraBulunamadiException();
                }
                double hacim = 0, fazlaHacim = 0;

                if (lbKumbara.Items.Count > 0)
                {
                    lbKumbara.Items.Clear();
                }

                if (secilenPara == null)
                {
                    throw new ParaSecilmediException();
                }

                if (secilenPara is BozukPara)
                {
                    BozukPara bozukPara = (BozukPara)secilenPara;
                    hacim = bozukPara.Hacim();
                    fazlaHacim = bozukPara.FazladanHacimEkle(hacim);                   

                    if (kumbara.BirikenHacim + hacim + fazlaHacim > kumbara.KumbaraHacmi)
                    {
                        throw new KumbaraDolduException();
                    }

                    toplamFazlaHacim += fazlaHacim;
                    kumbara.BirikenHacim += hacim + fazlaHacim;
                    toplamMinHacim += bozukPara.MinHacimHesapla(hacim);

                    kumbara.ParaEkle(bozukPara);

                }
                else if (secilenPara is KagitPara)
                {
                    KagitPara kagitPara = (KagitPara)secilenPara;

                    if (katlandiMi == false)
                    {
                        throw new ParaKatlaException();
                    }

                    hacim = katlanmisParaHacmi;
                    fazlaHacim = kagitPara.FazladanHacimEkle(hacim);

                    if (kumbara.BirikenHacim + hacim + fazlaHacim > kumbara.KumbaraHacmi)
                    {
                        throw new KumbaraDolduException();
                    }

                    toplamFazlaHacim += fazlaHacim;
                    kumbara.BirikenHacim += hacim + fazlaHacim;
                    toplamMinHacim += kagitPara.MinHacimHesapla(hacim);

                    kumbara.ParaEkle(kagitPara);
                }
                else
                {
                    MessageBox.Show("Seçilen para türü bulunamadı");
                }

                katlandiMi = false;
                secilenPara = null;
                cmbBozukPara.Enabled = true;
                cmbKagitPara.Enabled = true;
                cmbBozukPara.SelectedIndex = 0;
                cmbKagitPara.SelectedIndex = 0;
                lblBirikenParaMiktari.Text = string.Concat(kumbara.BirikenParaMiktari.ToString(), " TL");
                HacimYazdir();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnParaKatla_Click(object sender, EventArgs e)
        {
            KagitPara katlanacak = (KagitPara)secilenPara;
            if (katlanacak != null)
            {
                katlandiMi = true;
                katlanmisParaHacmi = katlanacak.Katla(katlanacak.Hacim());
            }
        }

        private void btnSalla_Click(object sender, EventArgs e)
        {
            if (kumbara.BirikenHacim > toplamFazlaHacim && toplamFazlaHacim > 0)
            {
                toplamFazlaHacim = 0;
                kumbara.Shake(toplamMinHacim);
                HacimYazdir();
            }
        }

        private void HacimYazdir()
        {
            lblFazlaHacim.Text = toplamFazlaHacim.ToString();
            lblToplamHacim.Text = kumbara.BirikenHacim.ToString();
        }

        private void btnKumbarayiKir_Click(object sender, EventArgs e)
        {
            try
            {
                if (kumbaraKirilmaSayisi < 2)
                {
                    lbKumbara.Items.Clear();
                    var paralar = kumbara.Break();

                    if (paralar == null)
                    {
                        throw new KumbaradaParaYokException();
                    }

                    kumbaraKirilmaSayisi++;

                    foreach (var item in paralar)
                    {
                        lbKumbara.Items.Add(item.Ad);
                    }

                    if (kumbara != null)
                    {
                        kumbara = new Kumbara(75000);
                    }
                    lblBirikenParaMiktari.Text = string.Concat(kumbara.BirikenParaMiktari.ToString(), " TL");
                }
                else
                {
                    throw new KirilmaSayiciException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBozukPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            string atilacakPara = string.Empty;
            if (cmbBozukPara.SelectedIndex > 0)
            {
                cmbKagitPara.Enabled = false;
                atilacakPara = cmbBozukPara.SelectedItem.ToString();
                foreach (var item in BozukParalar)
                {
                    if (atilacakPara == item.Ad)
                    {
                        secilenPara = item;
                    }
                }
            }
        }

        private void cmbKagitPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            string atilacakPara = string.Empty;
            if (cmbKagitPara.SelectedIndex > 0)
            {
                cmbBozukPara.Enabled = false;
                atilacakPara = cmbKagitPara.SelectedItem.ToString();
                foreach (var item in KagitParalar)
                {
                    if (atilacakPara == item.Ad)
                    {
                        secilenPara = item;
                    }
                }
            }
        }

        #endregion
    }
}
