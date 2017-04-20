using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBdOO
{
    class ContaCorrente : Conta
    {
        public override void Desconta()
        {
            Saldo = 0.20m;
        }
        public override bool Sacar(decimal s)
        {
            base.Sacar(s);
            Desconta();
            return true;
        }
        public override bool Depositar(decimal d)
        {
            return base.Depositar(d);
        }
        public override bool Debita(decimal d)
        {
            return base.Debita(d);
        }
    }
}
