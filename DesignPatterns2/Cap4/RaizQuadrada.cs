using DesignPatterns2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap4
{
    class RaizQuadrada : IExpressao
    {
        public RaizQuadrada(IExpressao expressao)
        {
            Expressao = expressao;
        }

        public IExpressao Expressao { get; private set; }

        public void Aceita(Impressora impressora)
        {
            throw new NotImplementedException();
        }

        public int Avalia()
        {
            int valor = Expressao.Avalia();

            return (int)Math.Sqrt(valor);

        }
    }
}
