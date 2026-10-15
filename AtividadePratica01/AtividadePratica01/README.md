# Atividade prática 1

* Crie a classe abstrata Funcionario com as propriedades Nome, Cpf e 
SalarioBase.

* Na classe Funcionario, crie o método abstrato: public abstract decimal 
SalarioMensal();

* Crie as classes Estagiario e Senior, ambas herdando de Funcionario, e 
sobrescreva (override) o método SalarioMensal() com regras distintas de cálculo:
○ O estagiário recebe metade do SalarioBase; o sênior recebe SalarioBase 
mais um bônus de 20%.

* Na Main (classe principal), crie uma List<Funcionario> contendo objetos de 
Estagiario e Senior.
* Percorra a lista e exiba o nome, o tipo do funcionário e o salário mensal, 
demonstrando o polimorfismo.
