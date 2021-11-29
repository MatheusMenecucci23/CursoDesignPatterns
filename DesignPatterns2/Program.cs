using DesignPatterns2.Cap6;
using System;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            MensagemPorEmail mensagem = new MensagemPorEmail("victor");
            mensagem.Envia();
            Console.ReadKey();
        }
    }
}
