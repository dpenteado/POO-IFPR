var funcionarios = new List<Funcionario> {new Senior("Jubileu", "000.000.000.00"),
    new Estagiario("Sr. Leoncio", "111.111.111.11")};

foreach (var funcionario in funcionarios)
{
    Console.WriteLine(
        $"Nome {funcionario.Nome}, " +
        $"Tipo do funcionario: {funcionario.GetType().Name}, " +
        $"CPF: {funcionario.Cpf}, " +
        $"Salário Mensal: {funcionario.SalarioMensal():C}");
}


public abstract class Funcionario
{
    public string Nome { get; set; }
    public string Cpf { get; set; }

    public decimal SalarioBase { get; set; } = 5000m;

    protected Funcionario(string nome, string cpf)
    {
        Nome = nome;
        Cpf = cpf;
    }

    public abstract decimal SalarioMensal();

}

public class Estagiario : Funcionario
{

    public Estagiario(string nome, string cpf) : base(nome, cpf) { }

    public override decimal SalarioMensal()
    {
        return SalarioBase / 2;
    }
}

public class Senior : Funcionario
{

    public Senior(string nome, string cpf) : base(nome, cpf) { }

    public override decimal SalarioMensal()
    {
        return SalarioBase * 1.2m;
    }
}
