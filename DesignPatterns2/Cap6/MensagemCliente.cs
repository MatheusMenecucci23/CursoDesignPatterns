using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap6
{
    class MensagemCliente : IMensagem
    {
        public MensagemCliente(string nome)
        {
            this.Nome = nome;
        }

        public object Nome { get; }
        public IEnviador Enviador { get; set; }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return String.Format($"Mensagem para o cliente {Nome}");
        }
    }
}
