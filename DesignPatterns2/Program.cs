using DesignPatterns2.Cap6;
using DesignPatterns2.Cap7;
using System;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            FilaDeTrabalho fila = new FilaDeTrabalho();
            Pedido pedido1 = new Pedido("Maurício",100.0);
            Pedido pedido2 = new Pedido("Marcelo", 200.0);
            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));

            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();
      
            Console.ReadKey();
        }
    }
}
