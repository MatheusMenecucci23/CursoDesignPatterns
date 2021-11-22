using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento reprovados não recebem descontos extras");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está reprovado");
        }

        public void Reprova(Orcamento orcamento)
        {

            throw new Exception("Orçamento já está reprovado");

        }
        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
