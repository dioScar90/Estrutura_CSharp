### Exercícios de C#

Esses são alguns dos meus exercícios do curso de **Análise e Desenvolvimento de Sistemas**, na matéria de Estrutura de Dados. Trata-se de exercícios de _C#_. Dentre os exercícios, veremos conceitos de:

- Recursividade.
- Pilha.
- Fila.
- Lista encadeada.
- Árvore binária.
- Função hash.


2) Escreva uma função recursiva chamada potencia(x, y), que retorne a base x elevado ao expoente y.


3) Implemente uma versão recursiva da seguinte função iterativa. Faça a repetição recursiva somente do for, não precisa fazer da expressão i * i * i.
void cubos (int n)
{
for (int i = 1; i <= n; i++)
Controle.WrilteLine(i * i * i);
}

4) Baseado no algoritmo de Euclides, implemente uma função recursiva para determinar o máximo divisor comum (mdc) entre dois números inteiros x e y.
	Algoritmo de Euclides:
	se (x = y) retorna x
	senão se (x < y) retorna mdc(y, x)
	senão retorna mdc(x - y, y)


5) A Série de Fibonacci pode ser definida da seguinte maneira:
	se (n == 0 ou n == 1) retorna n
	se (n >= 2) retorna fib(n – 1) + fib(n – 2)
Seja fib(n) uma função que retorna o n-ésimo termo da série de Fibonacci, implemente uma versão recursiva e outra iterativa. Observe que a partir de um determinado número, a função recursiva começa a ficar mais lenta que a iterativa.


6) Defina uma função recursiva que converte um número inteiro para a base binária.


10) Elabore um programa que verifica se uma dada expressão é válida em relação aos abre e fecha parênteses, colchetes e chaves. Exemplos:
a) a = b + (c -d) * (e – f)				- válida
b) b = [c – d)						- inválida
c) while (m < (n[8] + o)) { m = m + 1; }		- válida
d) for (i = 1; i <= tl; i++				- inválida


14) Escreva um programa que insira vários números numa fila. Após a digitação dos números, seu programa deve encontrar o maior, o menor e a média aritmética dos números da fila. Por fim, informe os resultados encontrados.


17) Faça uma implementação que construa uma lista encadeada. Seu programa deve ter as opções de inserção e remoção dos elementos. Após remover um elemento da lista, exiba-o na tela.


18) Faça um programa que utilize lista encadeada e que tenha as opções a seguir. O nó deve conter os atributos: nome, idade, sexo e prox.	
a)	Incluir conforme apresentado em aulas
b)	Para alterar, consulte pelo nome. Se encontrar, exiba os valores atuais e permita a alteração. Caso não encontre, exiba mensagem de não encontrado.
c)	Para excluir, procure pelo nome. Se encontrar, exiba os valores atuais e permita a exclusão. Caso não encontre, exiba mensagem de não encontrado.
d)	Na opção exibir, exiba todos os registros.


19) Faça um programa para o usuário digitar vários números, inclua-os num vetor. Em seguida, faça uma função recursiva que copie os números do vetor para uma lista encadeada. Após copiar os números do vetor para a lista, percorra a lista e encontre o menor, o maior e a média dos números.


20) Implemente a lógica da inserção em uma lista duplamente encadeada (nó com ponteiro para o anterior e o próximo nó). Utilize o conceito de pilha.


21) Implemente a lógica da remoção em uma lista duplamente encadeada. Faça a procura pelo nó a ser excluído.


22) Implemente a lógica de uma lista encadeada com o conceito de fila, ou seja, insira os nós no fim da lista e remova-os do início da lista. Utilize duas variáveis (inicio e fim) para controlar os acessos a lista.


25) Desenvolva um programa para inserir, pesquisar, remover e exibir os valores de uma árvore binária. Observe as opções a seguir:
a)	Inserir um valor digitado pelo usuário
b)	Pesquisar um valor digitado pelo usuário. Exiba uma mensagem informando se encontrou ou não
c)	Remover um valor digitado pelo usuário. Exiba a mensagem se removido com sucesso ou não encontrado
d)	Exibir todos os valores da árvore em ordem, pré ordem ou pós ordem


29) Implemente um programa com as seguintes opções: Sem tratamento de colisão, Tratamento de colisão Linear e Tratamento de colisão com Lista Encadeada.
	Dentro de cada opção deve haver as funcionalidades: Inserir, Consultar, Alterar e Relatar.
	O vetor deve ser do tipo abstrato de dado composto por idade, nome e sexo. Serão necessários 3 vetores, um para cada tipo de tratamento de colisão.
Para inserir um novo registro, solicite a idade, nome e sexo. Utilize a idade como chave.
Para consultar solicite a idade (chave) para ser utilizada na busca. Caso encontrada, informe o nome e o sexo da pessoa. Após a consulta, o usuário pode atualizar somente o nome e o sexo.
Para relatar, percorra o vetor do inicio ao fim e exibe todos os registros.