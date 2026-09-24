using System.Collections.Generic;

Stack<char> chars = 
    new Stack<char>();

string text = string.Empty;
Console.WriteLine("Digite uma Palavra ou Frase para Reverter: ");
text = Console.ReadLine();

foreach (char c in text)
{
    chars.Push(c);
}

while (chars.Count > 0)
{
    Console.Write(chars.Pop());
}

Console.WriteLine("");
