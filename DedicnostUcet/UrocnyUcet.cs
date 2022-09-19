using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedicnostUcet
{
    internal class UrocnyUcet : Ucet
    {
        protected double urok; //procenta 0-1

        public UrocnyUcet() :base()
        {
            this.urok = 0.01;
        }

        public UrocnyUcet(double stav, string mena) : base(stav, mena)
        {
            this.urok = 0.01;
        }
        public UrocnyUcet(double stav, string mena, double urok) :base(stav, mena)
        {
            this.urok = urok;
        }
    }
}
