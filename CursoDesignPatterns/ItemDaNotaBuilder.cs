using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ItemDaNotaBuilder
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public ItemDaNotaBuilder ComNome(string descricao)
        {
            Descricao = descricao;
            return this;
        }
        public ItemDaNotaBuilder ComValor(double valor)
        {
            Valor = valor;
            return this;
        }
        public ItemDaNota Constroi()
        {
            return new ItemDaNota(Descricao, Valor);
        }

    }
}
