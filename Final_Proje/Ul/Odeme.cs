using System;

namespace Final_Proje
{
    internal class Odeme
    {
        public Odeme()
        {
        }

        public Guid ID { get; set; }
        public Guid MusteriID { get; internal set; }
        public DateTime Tarih { get; internal set; }
        public double Tutar { get; internal set; }
        public string Tur { get; internal set; }
        public string Aciklama { get; internal set; }
    }
}