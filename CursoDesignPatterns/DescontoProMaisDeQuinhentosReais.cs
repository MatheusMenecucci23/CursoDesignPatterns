﻿using System;
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
            //chamando o próximo que o d3 que é o método sem desconto
            return Proximo.Desconta(orcamento);
        }
    }
}
