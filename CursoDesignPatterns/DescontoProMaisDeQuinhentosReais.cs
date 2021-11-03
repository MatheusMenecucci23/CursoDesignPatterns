using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class DescontoProMaisDeQuinhentosReais : Desconto
    {
        public Desconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {

            if (orcamento.Valor > 500) 
            {
                return orcamento.Valor * 0.07;
            }
            Console.WriteLine(Proximo.Desconta(orcamento));

            //linkando o próximo método a ser chamado
            //próximo é o d3
            return Proximo.Desconta(orcamento);
        }
    }
}
