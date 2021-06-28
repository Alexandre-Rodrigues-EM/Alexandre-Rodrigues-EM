#language: pt-br
Funcionalidade: Cadastro de Alunos
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](EM.Repository.Teste/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Cenário: Adicionar aluno
	Dado que a matrícula do aluno é 181818181
	E o nome é Mateus
	E o sexo é Masculino
	E a data de nascimento é 10/05/2012
	Quando the two numbers are added
	Então the result should be 120