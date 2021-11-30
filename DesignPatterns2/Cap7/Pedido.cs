using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap7
{
    class Pedido
    {
        public Pedido(string cliente, double valor)
        {
            Cliente = cliente;
            Valor = valor;
            Status = Status.Novo;
        }

        public string Cliente { get; private set; }
        public double Valor { get; private set; }
        public DateTime DataFinalizacao { get; private set; }
        public Status Status { get; private set; }
        public void Paga()
        {
            this.Status = Status.Pago;
        }
        public void Finaliza()
        {
            this.Status = Status.Entregue;
            this.DataFinalizacao = DateTime.Now;
        }
        
    }
}
