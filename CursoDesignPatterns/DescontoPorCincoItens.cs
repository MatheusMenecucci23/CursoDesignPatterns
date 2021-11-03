﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class DescontoPorCincoItens : Desconto
    {
        public Desconto Proximo {get;set;}
        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }
            //chamando o proxímo que é o D2 = new DescontoProMaisDeQuinhentosReais();
            return Proximo.Desconta(orcamento);
        }
    }






}
