using AtividadePratica03.Interfaces;
using AtividadePratica03.Models;


List<IContaBancaria> contasBancarias = new List<IContaBancaria>
{
    new ContaCorrente(),
    new ContaPoupanca()
};

foreach (var conta in contasBancarias)
{
    Console.WriteLine(conta.GetType().ToString());
    conta.Depositar(102.50m);
    conta.Sacar(100);
    Console.WriteLine($"Saldo atual: {conta.ConsultarSaldo():C}\n");
}