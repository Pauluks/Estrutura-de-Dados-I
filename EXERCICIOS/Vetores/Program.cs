using System;

int[] numeros = new int[10];
int[] pares = new int[10];
int[] impares = new int[10];

int qtdPares = 0;
int qtdImpares = 0;

// 1. Leitura dos 10 números
for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite o {i + 1}º número inteiro: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());

    // 2. Separação entre pares e ímpares
    if (numeros[i] % 2 == 0)
    {
        pares[qtdPares] = numeros[i];
        qtdPares++;
    }
    else
    {
        impares[qtdImpares] = numeros[i];
        qtdImpares++;
    }
}

// 3. Impressão dos números Pares
Console.WriteLine("\n--- NÚMEROS PARES ---");
if (qtdPares == 0)
{
    Console.WriteLine("Nenhum número par foi digitado.");
}
else
{
    for (int i = 0; i < qtdPares; i++)
    {
        Console.Write($"{pares[i]} ");
    }
    Console.WriteLine();
}

// 4. Impressão dos números Ímpares
Console.WriteLine("\n--- NÚMEROS ÍMPARES ---");
if (qtdImpares == 0)
{
    Console.WriteLine("Nenhum número ímpar foi digitado.");
}
else
{
    for (int i = 0; i < qtdImpares; i++)
    {
        Console.Write($"{impares[i]} ");
    }
    Console.WriteLine();
}