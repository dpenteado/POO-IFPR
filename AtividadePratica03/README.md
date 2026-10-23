# ATIVIDADE PRÁTICA SOBRE INTERFACES

Modele uma interface chamada IContaBancaria que defina as seguintes operações:

	● void Depositar(decimal valor);
	● void Sacar(decimal valor);
	● decimal ConsultarSaldo();
	● propriedade saldo;

Implemente duas classes que utilizem essa interface:
	
1) ContaCorrente:
   * Possui uma taxa de operação fixa (por exemplo, R$ 2,50) cobrada a cada saque.
   * Deve manter e atualizar o saldo corretamente.

2) ContaPoupanca:
   * Não cobra taxa nos saques.
   * Deve manter e atualizar o saldo corretamente.

Na classe principal (Program), crie uma lista de contas (List<IContaBancaria>) com 
diferentes tipos de contas e realize operações de depósito, saque e consulta de saldo. 
Demonstre o polimorfismo usando apenas a referência IContaBancaria
