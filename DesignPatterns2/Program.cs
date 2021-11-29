using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using DesignPatterns2.Cap5;
using System;
using System.Linq.Expressions;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());

            Impressora impressora = new Impressora();
            soma.Aceita(impressora);
            Console.ReadKey();
        }
    }
}
