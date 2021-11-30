using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap7
{
    class FinalizaPedido : IComando
    {
        public FinalizaPedido(Pedido pedido)
        {
            Pedido = pedido;
        }

        public Pedido Pedido { get; }

        public void Executa()
        {
            Console.WriteLine($"Finalizando o pedido do cliente {Pedido.Cliente}");
            Pedido.Finaliza();
        }
    }
}
