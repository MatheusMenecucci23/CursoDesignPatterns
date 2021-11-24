using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap3
{
    class Contrato
    {
        public DateTime Data { get; private set; }
        public string Cliente { get; private set; }
        public TipoContrato Tipo { get; private set; }

        public Contrato(DateTime data, string cliente, TipoContrato tipo)
        {
            Tipo = tipo;
            Data = data;
            Cliente = cliente;

        }

        internal void Retrocede()
        {
            if (Tipo == TipoContrato.Novo)
            {
                throw new Exception("Esse é o primeiro estado");
            }
            else if (Tipo == TipoContrato.EmAndamento)
            {
                Tipo = TipoContrato.Novo;
            }
            else if (Tipo == TipoContrato.Acertado)
            {
                Tipo = TipoContrato.EmAndamento;
            }
            else if (Tipo == TipoContrato.Concluidos)
            {
                throw new Exception("O contrato já foi finalizado");
            }
        }

        public void Avanca()
        {
            if (Tipo == TipoContrato.Novo)
            {
                Tipo = TipoContrato.EmAndamento;
            }
            else if (Tipo == TipoContrato.EmAndamento)
            {
                Tipo = TipoContrato.Acertado;
            }
            else if (Tipo == TipoContrato.Acertado)
            {
                Tipo = TipoContrato.Concluidos;
            }
        }
        public Estado SalvaEstado()
        {
            return new Estado(new Contrato(Data, Cliente, Tipo));
        }
    }
}
