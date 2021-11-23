using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            criador
                .ParaEmpresa("Caelum Ensino e Inovacao")
                .Com("23.456.789/00101-12")
                .Com(new ItemDaNota("item 1",100.0))
                .Com(new ItemDaNota("item 2",200.0))
                .ComObservacoes("uma obs qualquer");

            criador.AdicionaAcao(new EnviadorDeEmail());
            criador.AdicionaAcao(new NotaFiscalDao());
            criador.AdicionaAcao(new EnviadorDeSms());
            criador.AdicionaAcao(new Multiplicador(2));

            NotaFiscal nf = criador.Constroi();


            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
            Console.ReadKey();
        }
    }
}
