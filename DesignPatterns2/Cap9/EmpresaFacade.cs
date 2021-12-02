using DesignPatterns2.Cap8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap9
{
    class EmpresaFacade
    {
        public Cliente BuscaCliente(string cpf)
        {
            return new ClienteDAO().BuscaPorCpf(cpf);
        }
        public Fatura CriaFatura(Cliente cliente)
        {
            return new Fatura(cliente, valor);
        }
        public Cobranca GeraCobranca(Tipo tipo, Fatura fatura)
        {
            GeraCobranca cobranca = new Cobranca(tipo, fatura);
            corbacna.Emite();
        }
        public ContatoCliente FazContato(CLinete cliente, Cobranca cobranca)
        {
            ContatoCliente contato = new ContatoCliente(cliente, valor);
            contato.Dispara();
            return contato;
        }
    }
}
