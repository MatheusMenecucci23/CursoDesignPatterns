using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class NotaFiscal
    {

        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataEmissao { get; set; }
        public double ValorBruto{ get; set; }
        public double Impostos{ get; set; }
        public IList<ItemDaNota> item { get; set; }
        public string Observacoes{ get; set; }
        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataEmissao, double valorBruto, double impostos, IList<ItemDaNota> item, string observacoes)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            DataEmissao = dataEmissao;
            ValorBruto = valorBruto;
            Impostos = impostos;
            this.item = item;
            Observacoes = observacoes;
        }
        
    }
}
