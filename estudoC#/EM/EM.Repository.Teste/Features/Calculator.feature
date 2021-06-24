#language: pt-br
Funcionalidade: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](EM.Repository.Teste/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Cenário: Add two numbers
	Dado the first number is 50
	E the second number is 70
	Quando the two numbers are added
	Então the result should be 120