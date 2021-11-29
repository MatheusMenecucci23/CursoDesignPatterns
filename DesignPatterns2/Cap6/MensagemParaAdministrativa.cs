using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap6
{
    class MensagemParaAdministrativa : IMensagem
    {
        public MensagemParaAdministrativa(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; }
        public IEnviador Enviador { get ; set ; }

        public void Envia()
        {
            Enviador.Envia(this);  
        
        }

        public string Formata()
        {
            return string.Format($"Enviando a mensagem para o ADM {Nome}");
        }
    }
}
