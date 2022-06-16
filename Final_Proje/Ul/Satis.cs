using System;

namespace Final_Proje
{
    internal class Satis
    {
        public Satis()
        {
        }

        public Guid ID { get; set; }
        public Guid MusteriID { get; set; }
        public Guid UrunID { get; set; }
        public double Fiyat { get; set; }
        public DateTime Tarih { get; set; }
    }
}