using PiggyBank.Abstract;
using PiggyBank.Interface;
using System.Collections.Generic;

namespace PiggyBank.Concrete
{
    public class Kumbara : IKumbara
    {
        #region Fields & Propertys

        private double _paraMiktari;

        public double BirikenParaMiktari {
            get { return _paraMiktari; }
            set { _paraMiktari = value; } 
        }

        public double KumbaraHacmi { get; set; }

        public double BirikenHacim { get; set; }

        public List<Para> KumbaradakiParalar { get; set; }

        #endregion

        #region Constructor

        public Kumbara(int hacim)
        {
            KumbaraHacmi = hacim;
        }

        #endregion

        #region Methods

        public void Shake(double minHacim)
        {
            BirikenHacim = minHacim;
        }
        
        public void ParaEkle(Para para)
        {
            _paraMiktari += para.Miktar;
            if (KumbaradakiParalar == null)
            {
                KumbaradakiParalar = new List<Para>();
            }
            KumbaradakiParalar.Add(para);
        }

        public List<Para> Break()
        {
            return KumbaradakiParalar;
        }

        #endregion
    }
}
