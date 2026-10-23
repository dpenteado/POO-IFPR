using System;

namespace AtividadePratica03.Interfaces
{
    public interface IContaBancaria
    {
        void Depositar(decimal valor);
        void Sacar(decimal valor);
        decimal ConsultarSaldo();
        decimal Saldo { get; }
    }
}
