using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedicnostUcet
{
    internal class Penize
    {
        private double castka;
        private string mena; // CZK, EUR, USD

        public Penize(double castka, string mena)
        {
            if(castka < 0)
            {
                throw new ArgumentException("Penize nemohou byt zaporne");
            } else
            this.castka = castka;
            this.mena = mena;
        }

        public Penize()
        {
            this.castka = 0;
            this.mena = "CZK";
        }

        public double Castka
        {
            get { return this.castka; }
            set {
                if (castka < 0)
                {
                    throw new ArgumentException("Penize nemohou byt zaporne");
                } else
                    this.castka = value; 
            }
        }
        public string Mena
        {
            get { return this.mena; }
            set { this.mena = value; }
        }

        public override string ToString()
        {
            return this.castka + " " + this.mena;
        }

        public void ZmenMenu(string novaMena)
        {
            if(novaMena == "CZK")
            {
                //this.toCZK;
            }
        }

        public virtual Penize toCZK()
        {
            if (this.mena == "EUR")
            {
                return new Penize(this.castka * 24.52, "CZK");
            }
            if (this.mena == "USD")
            {
                return new Penize(this.castka * 24.56, "CZK");
            }
            else return new Penize(this.castka, "CZK");
        }

        public virtual Penize toEUR()
        {
            if (this.mena == "CZK")
            {
                return new Penize(this.castka * 0.041, "EUR");
            }
            if (this.mena == "USD")
            {
                return new Penize(this.castka * 1, "EUR");
            }
            else return new Penize(this.castka, "EUR");
        }

        public virtual Penize toUSD()
        {
            if (this.mena == "EUR")
            {
                return new Penize(this.castka * 1, "USD");
            }
            if (this.mena == "CZK")
            {
                return new Penize(this.castka * 0.041, "USD");
            }
            else return new Penize(this.castka, "USD");
        }
    }
}
