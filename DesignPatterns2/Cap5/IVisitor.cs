﻿using DesignPatterns2.Cap4;

namespace DesignPatterns2.Cap5
{
    interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSubstracao(Subtracao subtracao);

        void ImprimeNumero(Numero numero);
    }
}
