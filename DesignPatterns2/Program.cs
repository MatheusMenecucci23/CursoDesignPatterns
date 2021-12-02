using DesignPatterns2.Cap8;
using DesignPatterns2.Cap9;
using System;
using System.IO;
using System.Xml.Serialization;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            String cpf = "1234";

            EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
            Cliente cliente = facade.BuscaCliente(cpf);

            var fatura = facade.CriaFatura(cliente, 5000);
            facade.GeraCobranca(tipo.Boleto, fatura);

            Console.ReadKey();
        }
    }
}
