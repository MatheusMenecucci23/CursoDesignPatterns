using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ISS : Imposto
    {
       public double Calcula(Orcamento orcamento)
        {
            Console.WriteLine(orcamento.Valor * 0.06);
            return orcamento.Valor * 0.06;
        }
    }
}
