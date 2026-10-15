//var conta01 = new ContaCorrente(600);
//var conta02 = new ContaPoupanca(100);
//var conta03 = new ContaCorrente(200);
//var conta04 = new ContaPoupanca(50);

//Console.WriteLine($"Conta 01 - Tipo de conta: {conta01.GetType().Name}\nSaldo Atual: {conta01.ObterSaldo():C}\n");
//Console.WriteLine($"Conta 02 - Tipo de conta: {conta02.GetType().Name}\nSaldo Atual: {conta02.ObterSaldo():C}\n");
//Console.WriteLine($"Conta 03 - Tipo de conta: {conta03.GetType().Name}\nSaldo Atual: {conta03.ObterSaldo():C}\n");
//Console.WriteLine($"Conta 04 - Tipo de conta: {conta04.GetType().Name}\nSaldo Atual: {conta04.ObterSaldo():C}\n");

//conta01.Sacar(1500);
//conta02.Sacar(100);
//conta03.Sacar(250);
//conta04.Sacar(60);

//Console.WriteLine($"Conta 01 - Tipo de conta: {conta01.GetType().Name}\nSaldo Atual: {conta01.ObterSaldo():C}\n");
//Console.WriteLine($"Conta 02 - Tipo de conta: {conta02.GetType().Name}\nSaldo Atual: {conta02.ObterSaldo():C}\n");
//Console.WriteLine($"Conta 03 - Tipo de conta: {conta03.GetType().Name}\nSaldo Atual: {conta03.ObterSaldo():C}\n");
//Console.WriteLine($"Conta 04 - Tipo de conta: {conta04.GetType().Name}\nSaldo Atual: {conta04.ObterSaldo():C}\n");

var contas = new List<ContaBancaria> { new ContaCorrente(5010), new ContaCorrente(100), new ContaPoupanca(700) };


foreach (var conta in contas)
{
    Console.WriteLine($"Tipo de conta: {conta.GetType().Name}\nSaldo Atual: {conta.ObterSaldo():C}\n");
}

public abstract class ContaBancaria
{
    protected decimal Saldo { get; set; }

    protected ContaBancaria(decimal saldoInicial = 0)
    {
        Saldo = saldoInicial;
    }

    public abstract void Depositar(decimal valor);
    public abstract bool Sacar(decimal valor);
    public decimal ObterSaldo() { return Saldo; }

}

public class ContaCorrente : ContaBancaria
{
    public ContaCorrente(decimal saldo) : base(saldo) { }

    public override void Depositar(decimal valor)
    {
        Saldo += valor;
    }

    public override bool Sacar(decimal valor)
    {
        bool temLimite = Saldo - valor >= -500m;

        if (temLimite)
        {
            Saldo = Saldo - valor;
            return true;
        }

        return false;

    }
}

public class ContaPoupanca : ContaBancaria
{
    public ContaPoupanca(decimal saldo) : base(saldo) { }

    public override void Depositar(decimal valor)
    {
        Saldo += valor;
    }

    public override bool Sacar(decimal valor)
    {
        bool verificaSaldo = Saldo - valor >= 0m;

        if (verificaSaldo)
        {
            Saldo -= valor;
            return true;
        }
        return false;

    }
}