# Avaliação Final - DiverseDev - Ada Tech

1 - Escreva um programa que faça a leitura de 5 valores Inteiros do usuário. Em seguida, o programa deve exibir no console a informação de quantos dos valores digitados são pares, quantos dos valores digitados são ímpares, quantos deles são positivos e, por fim, quantos são negativos. Cada uma das informações deve ser escrita em uma linha diferente.

2 - Escreva um programa que calcule e escreva a multiplicação e a divisão inteira de dois números inteiros, N1 por N2, que devem ser lidos do teclado. É importante observar que a máquina que irá executar este programa é capaz de efetuar apenas duas operações matemáticas: adição e subtração. Ou seja, você não poderá usar os operadores de multiplicação, divisão, módulo etc. bem como truncamentos.

3 - Escreva um programa que recebe como entrada uma frase do usuário. Como saída o programa deve exibir no console as seguintes informações: quantas palavras são maiúsculas, quantas palavras são minúsculas, quantas palavras iniciam com letra maiúscula, quantas palavras iniciam com letra minúscula e a quantidade de palavras.

4 - Ao executar o código a seguir será exibido qual valor no terminal? Justifique sua resposta.

```
Int32 numero;
numero = Convert.ToInt16(!(21 > 21));
Console.WriteLine(numero);
```

A) -1;

B) 0;

`C) 1;`

D) 21;

E) Irá dar erro

A resposta é `C`.

O resultado de `(21 > 21)` é `false`, mas como tem o `!`, que é o operador de negação, ele inverte para `true`.

O `Convert.ToInt16` é usado para converter um valor boleano em número, e `true` em inteiro é o mesmo que `1`, se fosse `false` seria `0`.

5 - Analise o código a seguir.

```
for (int i = -5; i <= 7; i += 3)
{
    Console.WriteLine(i);
}
```

Assinale a opção que apresenta corretamente o resultado produzido pela execução do trecho acima. Justifique o porque dessa opção.

A) –2, 1, 4, 7, 10

B) –5, –2, 1, 4, 10

C) –2, 1, 4, 7

D) –5, –2, 1, 4

`E) –5, –2, 1, 4, 7`

A resposta é `E` pois o for começa com `i = -5`, esse é o primeiro valor que entra dentro do bloco, na próxima interação, ele soma `3` a esse valor, ficando com `i = -2`, nas próximas interações ele recebe `1, 4 e 7` respectivamente. O `7` é impresso pois o for continua até que `i <= 7` não sejá mais verdadeira, e isso só acontece quando ele se tornar `10`.
