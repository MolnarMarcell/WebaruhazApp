using System;
using System.Collections.Generic;
using System.Text;

namespace WebaruhazApp
{
    internal class Termek
    {
        private int nettoAr;

        protected double afaKulcs = 0.27;

        private static int osszesTermekSzama = 0;

        public string Nev { get; set; }

        public int NettoAr
        {
            get { return nettoAr; }
            set
            {
                if (value > 0)
                {
                    nettoAr = value;
                }
            }
        }

        public Termek(string nev, int nettoar)
        {
            this.Nev = nev;
            this.nettoAr = nettoar;
            osszesTermekSzama++;
        }

        public static int OsszesTermekSzama
        {
            get { return osszesTermekSzama; }
        }

        public virtual int BruttoArKiszamitas()
        {
            return Convert.ToInt32(NettoAr * (1 + afaKulcs));
        }

        public override string ToString()
        {
            return $"Termék: {Nev} | Nettó: {NettoAr} Ft | Bruttó: {BruttoArKiszamitas()} Ft";
        }
    }






}
