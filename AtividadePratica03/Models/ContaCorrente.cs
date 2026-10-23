using System;
using AtividadePratica03.Interfaces;

namespace AtividadePratica03.Models
{
    public class ContaCorrente : IContaBancaria
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
            bool saldoSuficiente = Saldo >= (valor + _TaxaDeOperacao) && valor > 0m;

            if (saldoSuficiente)
            {
                Saldo = Saldo - valor - _TaxaDeOperacao;
                Console.WriteLine($"Valor sacado: {valor:C} \nTaxa de operação: {_TaxaDeOperacao:C}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }

        }

        public decimal ConsultarSaldo()
        {
            return Saldo;
        }

        public decimal Saldo { get; private set; }

        private const decimal _TaxaDeOperacao = 2.5m;
    }
}
