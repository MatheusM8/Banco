using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBdOO
{
    class ContaPoupanca : Conta
    {
        public override void Desconta()
        {
            Saldo = Saldo - 0.10m;
        }
        public override bool Sacar(decimal s)
        {
            if(s <= 1000)
            {
                base.Sacar(s);
                Desconta();
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Depositar(decimal d)
        {
            return base.Depositar(d);
        }
    }
}
