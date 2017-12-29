# Algoritmos em C#

**Algoritmos de Ordenação**
- **Bubble Sort**: é o algoritmo mais simples, porém o menos eficiente também. A ideia é executar passos de ordenação de elementos vizinhos enquanto houver movimentação/permutação.
- **Selection Sort**: A ideia é executar passos de ordenação enquanto houver movimentação/permutação. Para cada elemento de posição i até n-1 o vetor é percorrido à direita a partir de i+1 até encontrar um elemento (i+1) menor que o elemento (i). Ao encontrar realiza-se a movimentação e incrementa i.
- **Insertion Sort**: A ideia é executar n-1 passos de ordenação, partindo da posição i=2. Para cada passo o vetor é percorrido da posição i-1 até encontrar a melhor posição para inserir o elemento de posição i=2.
- **Quick Sort**: Utiliza a estratégia de divisão e conquista ou partição. A ideia é levar o pivo até a sua posição ideal de modo que os elementos à sua esquerda serão sempre menores e os elementos à sua direita serão sempre maiores. Depois disso o algoritmo é aplicado recursivamente aos elementos à esquerda do pivo e aos elementos à direita do pivo.
- **Merge Sort**: Também utiliza a estratégia de divisão e conquista ou partição. A ideia é executar passos de divisões e ordenação na estrutura. Uma diferença em relação ao QuickSort é que no MergeSort se utiliza de estruturas auxiliares, enquanto que no QuickSort não precisa.

**Recursividade**  
É uma estratégia para a solução de problemas que podem ser divididos em problemas menores de **mesma natureza** até que se chegue num **caso trivial**. A recursividade é resolvida através do **empilhamento** de funções. Se não tiver um caso trivial esse empilhamento gera um **estouro de pilha**. Ao chegar no caso trivial é feito o **desempilhamento**. Após um desempilhamento a função entra no **bloco/caso geral** que por sua vez deve-se aproveitar do resultado obtido após o desempilhamento ou acionar a recursividade caso o problema possa ser dividido em problema menor de mesma natureza.

> A recursividade é base do paradigma funcional presente em linguagens funcionais como **Lisp**, **Haskell**, **Miranda**, **F#**, **Scheme** e **Erland**. 

- Exemplos de aplicações da recursividade:
    - Quick-sort (ordenação rápida).
    - Merge-sort.
    - Busca binária.
    - Listas encadeadas.
    - Busca em árvores binárias e n-árias.
    - Fatorial de um número **n!**.
    - Sequência de Fibonacci.

```csharp
//Esquema geral de uma função recursiva

funcao resolve(problema) {
    //caso trivial
    se problema for trivial
        retorna resultado trivial
    
    //caso geral onde é possível dividir o problema em problema menor de mesma natureza
    resultado = resolve(problema menor de mesma natureza)

    //agora fica mais fácil aproveitar o resultado obtido da solução do subproblema
    o que se pode fazer com o resultado da solução do subproblema?
}
```

- Exemplo1: cálculo do fatorial de um número _n!_
    - Caso trivial: fatorial de 1 ou 0 = 1
    - Caso geral: fatorial de n>1 = n*(n-1)!

**Sequência/Série de Fibonacci**  
É uma sequência numérica baseada na perfeição de fenômenos da natureza que apresentam proporcionalidade de **1,6**. A constante **1,6** já era usada pelos egípcios como medida base para se obter e aplicar a **proporção ideal** em suas construções. Aplicar a constante **1,6** exige a aplicação da operação de multiplicação, e esta não é tão trivial como a operação de soma. Fibonacci, por volta de 1200, demonstrou uma estratégia que simplifica a aplicação da constante por meio da operação soma. Com a estratégia de Fibonacci fica muito mais fácil determinar qual é a proporção próxima da ideal para uma dada medida.

Ao aplicar a estratégia de Fibonacci obtemos uma sequência numérica, que é então chamada de sequência de Fibonacci. Repare na sequência que 2=1+1, 3=2+1, 5=3+2, 8=5+3. Além disso, 5=3\*1.6, 8=5\*1.6, 13=8\*1.6. 
- 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ... 

> Com base nesta sequência podemos dizer que a proporção ideal para a construção de objetos baseados na medida 5 é 3 e 8, ou seja, se você possui um quadro de 5m como decoração de sua sala, não seria adequado a utilização de quadros com 1m, pois de acordo com a proporção ideal a medida adequada seria 3m.

Podemos obter a sequência de Fibonacci através da recursividade e para isso podemos considerar que:
- Caso trivial: F(1) ou F(2) = 1
- Caso geral: F(n) = F(n-1) + F(n-2)

**Algoritmos de Busca**
- **Busca Sequencial**: para localizar o valor procurado a estratégia é percorrer a estrutura de dados até encontrar ou até passar pelo último elemento.
- **Busca Binária**: para localizar o valor procurado a estratégia é dentro de uma janela de busca olhar para o elemento central, se o elemento central é o valor procurado significa que encontramos, se o valor procurado não é o elemento central significa que o valor procurado pode estar à esquerda ou à direita do elemento central e um desses lados (à esquerda ou à direita) passa a ser a nova janela de busca, onde o processo é executado recursivamente até encontrar o elemento ou até não exista mais janela de busca.

> Em se tratando de complexidade computacional (esforço computacional), se considerarmos o pior caso para um vetor com **n** elementos a busca sequencial realizará **n** comparações até concluir que o elemento procurado não existe na estrutura e a busca binária realizará **log2(n)+1** comparações até concluir que o elemento não existe na estrutura. Por isso que a busca binária é mais eficiente, pois no pior caso e na ampla maioria dos casos  **log2(n)+1 < n** e apenas em casos triviais (poucos elementos) existe a possibilidade da busca sequencial se igualar a busca binária (**log2(n)+1 <= n**).
