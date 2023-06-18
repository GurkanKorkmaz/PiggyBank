namespace PiggyBank.Abstract
{
    public abstract class Para
    {
        public string Ad { get; set; }

        public double Miktar { get; set; }

        public double Yukseklik { get; set; } = 0.25;

        public abstract double Hacim();

        public abstract double FazladanHacimEkle(double hacim);

        public abstract double MinHacimHesapla(double hacim);
    }
}
