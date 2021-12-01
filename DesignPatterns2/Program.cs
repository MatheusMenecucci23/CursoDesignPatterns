using DesignPatterns2.Cap8;
using System;
using System.IO;
using System.Xml.Serialization;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = "victor";
            cliente.Endereco = "Rua Vergueiro";
            cliente.DataDeNascimento = DateTime.Now;

            String xml = new GeradorDeXml().GeraXml(cliente);

            Console.WriteLine(xml);
      
            Console.ReadKey();
        }
    }
}
