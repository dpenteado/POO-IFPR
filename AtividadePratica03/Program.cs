
List<IContaBancaria> contasBancarias = new List<IContaBancaria>
{
    new ContaCorrente(),
    new ContaPoupanca()
};

foreach (var conta in contasBancarias)
{
    Console.WriteLine(conta.GetType().ToString());
    conta.Depositar(103);
    conta.Sacar(100);
    Console.WriteLine($"Saldo atual: {conta.ConsultarSaldo():C}\n");
}

public class ContaCorrente : IContaBancaria
{
    public void Depositar(decimal valor) 
    {
        Saldo += valor;
        Console.WriteLine($"Deposito: {valor:C}");
    }

    public void Sacar(decimal valor) 
    {
        bool saldoSuficiente = Saldo > (valor + taxaDeOperacao);

        if (saldoSuficiente) 
        {
            Saldo = Saldo - valor - taxaDeOperacao;
            Console.WriteLine($"Valor sacado: {valor:C} \nTaxa de operação: {taxaDeOperacao:C}");
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

    public decimal Saldo { get; set; }

    decimal taxaDeOperacao = 2.5m;
}

public class ContaPoupanca : IContaBancaria
{
    public void Depositar(decimal valor)
    {
        Saldo += valor;
        Console.WriteLine($"Deposito: {valor:C}");
    }

    public void Sacar(decimal valor) 
    {
        bool saldoSuficiente = Saldo > 0m;

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

    public decimal Saldo { get; set; }
}


public interface IContaBancaria
{
    void Depositar(decimal valor);
    void Sacar(decimal valor);
    public decimal ConsultarSaldo();
    decimal Saldo { get; set; }
}