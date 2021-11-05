using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculando imposto conjugado
            Imposto iss = new ICPP(new ISS());
            

            Orcamento orcamento = new Orcamento(500.0);

            double valor = iss.Calcula(orcamento);

            Console.WriteLine(valor);

            Console.ReadKey();
        }
    }
}
