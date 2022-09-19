using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Vyber(Penize castka)
        {

        }
    }
}
