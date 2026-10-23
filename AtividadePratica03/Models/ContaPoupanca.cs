using System;
using AtividadePratica03.Interfaces;

namespace AtividadePratica03.Models
{
    public class ContaPoupanca : IContaBancaria
    {
        public void Depositar(decimal valor)
        {
            if (valor > 0m)
            {
                Saldo += valor;
                Console.WriteLine($"Deposito: {valor:C}");
            }
            else
            {
                Console.WriteLine("Deposite um valor maior do que zero!");
            }
        }

        public void Sacar(decimal valor)
        {
            bool saldoSuficiente = Saldo >= valor && valor > 0m;

            if (saldoSuficiente)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque: {valor:C}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }

        public decimal ConsultarSaldo() => Saldo;

        public decimal Saldo { get; private set; }
    }
}
