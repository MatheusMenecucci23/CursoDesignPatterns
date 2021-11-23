using System;

namespace CursoDesignPatterns
{
    public class Multiplicador : AcaoAposGerarNota
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }

        public void Executa(NotaFiscal nf)
        { 
            Console.WriteLine("Nota dobrada " + nf.ValorBruto * Fator);
        }
    }
}