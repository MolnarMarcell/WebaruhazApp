using System;
using System.Collections.Generic;
using System.Text;

namespace WebaruhazApp
{
    internal class AkciosTermek : Termek
    {


        private int kedvezmenySzazalek;

        public int KedvezmenySzazalek
        {
            get { return kedvezmenySzazalek; }
            set
            {
                if ( value >= 1 && value <= 90)
                {
                    kedvezmenySzazalek = value;
                }
                else
                {
                    kedvezmenySzazalek = 10;
                }
            }
        }
        public AkciosTermek(string nev, int nettoar, int kedvezmenyszazalek) : base(nev, nettoar)
        {
            this.kedvezmenySzazalek = kedvezmenyszazalek;
        }

        public override int BruttoArKiszamitas()
        {
            return (base.BruttoArKiszamitas() - (base.BruttoArKiszamitas()/100*kedvezmenySzazalek));
        }

        public override string ToString()
        {
            return base.ToString() + $" Kedvezmény: {kedvezmenySzazalek}%" ;
        }
    }
}
