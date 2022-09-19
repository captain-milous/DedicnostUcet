using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DedicnostUcet
{
    internal class Ucet
    {
        protected Penize stav;

        public Ucet()
        {
            this.stav = new Penize();
        }

        public Ucet(double stav, string mena)
        {
            this.stav = new Penize(stav, mena);
        }

        public void Vyber(Penize vybiranePenize)
        {
            if(this.stav.Castka < vybiranePenize.Castka)
            {
                throw new Exception("Nemáš dostatek peněz pro výběr");
            } else
            {
                this.stav.Castka = this.stav.Castka - vybiranePenize.Castka;
                Console.WriteLine("Z účetu bylo vybráno " + vybiranePenize + ". Zůstatek na účně je " + this.stav);
            }
        }

        public void Vloz(Penize vklad)
        {
            this.stav.Castka = this.stav.Castka + vklad.Castka;
            Console.WriteLine("Na účet bylo úspěšně přidáno " + vklad + ". Zůstatek na účně je " + this.stav);
        }

        public Penize getStav()
        {
            return this.stav;
        }
    }
}
