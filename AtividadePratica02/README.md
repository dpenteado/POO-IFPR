# Atividade prática 2

* Crie a classe abstrata ContaBancaria com a propriedade Saldo protegida 
(protected decimal Saldo).

* Na classe ContaBancaria, declare os métodos abstratos:
	* public abstract void Depositar(decimal valor);
	* public abstract bool Sacar(decimal valor);

* Implemente as classes ContaCorrente e ContaPoupanca, ambas herdando de 
ContaBancaria, com políticas diferentes para as operações de saque e depósito:
	* ContaCorrente: permite saldo negativo até um limite (ex.: R$ 500).
	* ContaPoupanca: não permite saldo negativo.

* Na Main (classe principal), crie uma List<ContaBancaria> contendo objetos de 
ContaCorrente e ContaPoupanca.

* Percorra a lista realizando depósitos e saques, exibindo o tipo de conta, o saldo e 
demonstrando o polimorfismo.