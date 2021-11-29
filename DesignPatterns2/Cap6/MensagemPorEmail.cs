using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap6
{
    class MensagemPorEmail
    {
        public MensagemPorEmail(string nome)
        {
            this.Nome = nome;
        }

        public object Nome { get; }

        public void Envia()
        {
            Console.WriteLine("Enviando a mensagem por Email");
            Console.WriteLine($"Mensagem para o cliente {Nome}");
        }
    }
}
