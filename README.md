# Algoritmos em C#

**Algoritmos de Ordenação**
- **Bubble Sort**: é o algoritmo mais simples, porém o menos eficiente também. A ideia é executar passos de ordenação de elementos vizinhos enquanto houver movimentação/permutação.
- **Selection Sort**: A ideia é executar passos de ordenação enquanto houver movimentação/permutação. Para cada elemento de posição i até n-1 o vetor é percorrido à direita a partir de i+1 até encontrar um elemento (i+1) menor que o elemento (i). Ao encontrar realiza-se a movimentação e incrementa i.
- **Insertion Sort**: A ideia é executar n-1 passos de ordenação, partindo da posição i=2. Para cada passo o vetor é percorrido da posição i-1 até encontrar a melhor posição para inserir o elemento de posição i=2.
- **Quick Sort**: Utiliza a estratégia de divisão e conquista ou partição. A ideia é levar o pivo até a sua posição ideal de modo que os elementos à sua esquerda serão sempre menores e os elementos à sua direita serão sempre maiores. Depois disso o algoritmo é aplicado recursivamente aos elementos à esquerda do pivo e aos elementos à direita do pivo.
- **Merge Sort**: Também utiliza a estratégia de divisão e conquista ou partição. A ideia é executar passos de divisões e ordenação na estrutura. Uma diferença em relação ao QuickSort é que no MergeSort se utiliza de estruturas auxiliares, enquanto que no QuickSort não precisa.