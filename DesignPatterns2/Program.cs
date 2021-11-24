using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using System;
using System.Linq.Expressions;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            IExpressao direita = new Substracao(new Numero(20), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());

            Expression soma1 = Expression.Add(Expression.Constant(10),Expression.Constant(100));

            Func<int> funcao = Expression.Lambda<Func<int>>(soma1).Compile();
            Console.WriteLine(funcao());

            IExpressao raizQuadrada = new RaizQuadrada(new Numero(100));
            Console.WriteLine(raizQuadrada.Avalia());

            Console.ReadKey();
        }
    }
}
