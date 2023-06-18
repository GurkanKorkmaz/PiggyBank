using PiggyBank.Abstract;
using PiggyBank.Interface;
using System;

namespace PiggyBank.Concrete
{
    public class KagitPara : Para, IKagitPara
    {
        #region Fields & Propertys

        public double En { get; set; }

        public double Boy { get; set; }

        public override double Hacim()
        {
            return En * Boy * Yukseklik;
        }

        #endregion

        #region Methods

        public override double FazladanHacimEkle (double hacim)
        {
            Random rnd = new Random();
            return hacim * rnd.Next(25, 76) * 0.01;
        }

        public override double MinHacimHesapla(double hacim)
        {
            Random rnd = new Random();
            return hacim * 1.25;
        }

        public double Katla(double hacim)
        {
            return (En / 4) * Boy * (Yukseklik * 4);
        }

        #endregion
    }
}
