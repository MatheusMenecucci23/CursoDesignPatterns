using DesignPatterns2.Cap3;
using System;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            Historico historico = new Historico();

            Contrato c = new Contrato(DateTime.Now, "victor", TipoContrato.Novo);
            historico.Adiciona(c.SalvaEstado());
            Console.WriteLine(c.Tipo);

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());
            Console.WriteLine(c.Tipo);
            
            c.Retrocede();
            historico.Adiciona(c.SalvaEstado());
            Console.WriteLine(c.Tipo);

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());
            Console.WriteLine(c.Tipo);


            Console.WriteLine(historico.Pega(2).Contrato.Tipo);
            Console.ReadKey();
        }
    }
}
