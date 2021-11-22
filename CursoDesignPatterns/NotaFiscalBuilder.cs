using System;
using System.Collections.Generic;

namespace CursoDesignPatterns
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Observacoes { get; private set; }
        public DateTime Data { get; private set; }

        private double valorTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public NotaFiscalBuilder()
        {
            //data fica como parametro opcional
            Data = DateTime.Now;
        }

        //retornando um construtor
        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);
        }
        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }
        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime data)
        {
            Data = data;
            return this;
        }
        public NotaFiscalBuilder Com(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }
        public NotaFiscalBuilder Com(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }


    }
}