using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }
        private bool Existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }

        public double Desconta(Orcamento orcamento)
        {
            if (Existe("LAPIS", orcamento) && Existe("CANETA", orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            Console.WriteLine(Proximo.Desconta(orcamento));
            return Proximo.Desconta(orcamento);
        }
    }
}
