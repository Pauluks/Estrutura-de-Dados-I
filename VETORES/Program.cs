using System;

// 1. Declaração do vetor com tamanho definido (ex: 5 elementos)
int[] numbers = new int[5];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    
    // 2. Uso correto do Convert.ToInt32
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

// 3. Variável de contagem simples
int contador = 0;

foreach (int num in numbers)
{
    Console.WriteLine($"Número: {num}");
    contador++;
}

Console.WriteLine($"Total de elementos: {contador}");