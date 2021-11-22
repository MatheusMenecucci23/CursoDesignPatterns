using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ItemDaNota
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public ItemDaNota(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }


    }
}
