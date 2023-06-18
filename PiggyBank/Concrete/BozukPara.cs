using PiggyBank.Abstract;
using System;

namespace PiggyBank.Concrete
{
    public class BozukPara : Para
    {
        #region Fields & Propertys

        public const double PI = 3.14;

        public double Cap { get; set; }

        public override double Hacim()
        {
            return Yukseklik * (Cap / 2) * (Cap / 2) * PI;
        }

        #endregion

        #region Methods

        public override double FazladanHacimEkle(double hacim)
        {
            Random rnd = new Random();
            return hacim * rnd.Next(25, 76) * 0.01;
        }

        public override double MinHacimHesapla(double hacim)
        {
            Random rnd = new Random();
            return hacim * 1.25;
        }

        #endregion
    }
}
