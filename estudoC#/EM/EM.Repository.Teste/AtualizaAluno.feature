#language: pt-br
Funcionalidade: Atualizar cadastro de aluno

SENDO usuário do sistema,
QUERO atualizar um dado qualquer do aluno selecionado, 
PARA corrigir qualquer erro cometido no cadastro

Rule: Não é possível alterar matrícula de aluno

	Contexto: 
		Dados os seguintes alunos:
		| Matricula | Nome            | Sexo      | Nascimento |
		| 123456789 | Matweus Costa   | Masculino | 06/05/2009 |
		| 456789123 | Gilmar Ferreira | Masculino | 19/08/2010 |
		| 789456123 | Thalita Passos  | Feminino  | 22/01/2003 |

		Cenário: Atualiza matrícula de aluno
			Dado que não posso alterar o número de <Matricula>
			Quando eu selecionar um aluno para alteração
			E tentar modificar o número de <Matricula>
			Então o programa retornará a seguinte mensagem de erro:
			"""
			Não é possível alterar o número de matrícula
			"""


		Cenário: Atualizar nome de aluno
			Dado que o <Nome> do aluno foi digitado errado como 
			"""
			Matweus Costa
			"""
			Quando eu alterar o <Nome> para
			"""
			Mateus Costa
			"""
			Então o programa retornará os dados do aluno atualizado :
			| Matricula | Nome            | Sexo      | Nascimento |
			| 123456789 | Mateus Costa   | Masculino | 06/05/2009 |



