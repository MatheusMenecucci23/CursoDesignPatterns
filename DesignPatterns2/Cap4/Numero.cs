using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap4
{
    class Numero : IExpressao
    {
        public int NumeroProp { get; private set; }
        public Numero(int numero){
            NumeroProp = numero;
        }

        public int Avalia()
        {
            return NumeroProp;
        }


    }
}
