using DesignPatterns2.Cap6;
using System;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            IMensagem mensagem = new MensagemParaAdministrativa("victor");
            IEnviador enviador = new EnviaPorEmail();
            mensagem.Enviador = enviador;
            mensagem.Envia();
      
            Console.ReadKey();
        }
    }
}
