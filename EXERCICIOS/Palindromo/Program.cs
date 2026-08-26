using System;

Console.Write("Digite uma palavra: ");
string entrada = Console.ReadLine();

// Prepara a palavra (remove espaços e passa para minúsculo)
string palavra = entrada.Replace(" ", "").ToLower();

// Inverte a palavra
char[] caracteres = palavra.ToCharArray();
Array.Reverse(caracteres);
string palavraInvertida = new string(caracteres);

// Verifica se é palíndromo
Console.WriteLine();
if (palavra == palavraInvertida)
{
    Console.WriteLine($"\"{entrada}\" É um palíndromo!");
}
else
{
    Console.WriteLine($"\"{entrada}\" NÃO é um palíndromo.");
}