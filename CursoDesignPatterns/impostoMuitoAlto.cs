using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class impostoMuitoAlto : Imposto
    {
        //para o outro imposto funcionar
        public impostoMuitoAlto(Imposto outroImposto) : base(outroImposto) { }
        public impostoMuitoAlto() : base() { }

        //
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculoDoOutroImposto(orcamento);
        }
    }
}
