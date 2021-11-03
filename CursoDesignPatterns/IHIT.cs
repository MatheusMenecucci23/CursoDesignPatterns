using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class IHIT : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return Existe(orcamento);
            
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (orcamento.Itens.Count*0.01);
        }
        private bool Existe(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                var cont = 0;
                foreach (Item item1 in orcamento.Itens)
                {
                    if (item.Nome.Equals(item1.Nome))
                    {
                        cont += 1;
                    }
                        
                }
                if (cont >=2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
