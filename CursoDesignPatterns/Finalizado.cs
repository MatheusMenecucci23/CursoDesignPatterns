using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento finalizados não recebem descontos extras");
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado");
        }


        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado");

        }
        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado");
        }
    }
}
