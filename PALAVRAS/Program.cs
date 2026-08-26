Console.WriteLine("Hello, World!");
string firstName = "Henrique";
string LastName = "Pauluk";

string note = LastName.ToUpper()
                + " " + firstName;

string initials =LastName[0] + " " +
                firstName[0];

// Formatação de String
string texto = string.Format ("{0} {1} nascido em {2}", firstName, LastName, 2007);
Console.WriteLine(texto);

// C# é uma linguagem filha do C++ 
//totalmente orientada a objetos
// portanto, tudo dentro do C é descendente
// do tipo Obkect

int age = 24;
object ageBoxing = age;
int ageUnboxing = (int)ageBoxing;
