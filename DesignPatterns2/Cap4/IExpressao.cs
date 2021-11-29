using DesignPatterns2.Cap5;

namespace DesignPatterns2.Cap4
{
    internal interface IExpressao
    {
        int Avalia();
        void Aceita(Impressora impressora);
    }
}