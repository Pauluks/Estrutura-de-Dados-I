using System.Collections;
using System.Globalization;

// ArrayLists
ArrayList arrayList = new ArrayList();

// Adicionando Itens à Lista
arrayList.Add(5);

// Adicionando quantias de itens à Lista
arrayList.AddRange(new int[] { 1, 2, 3 });

// Insere o valor 7.8 na posição 3 da lista      
arrayList.Insert(3, 7.8);

// Percorrendo itens da lista de forma genérica
foreach (object obj in arrayList)
{
    Console.WriteLine(obj);
}

// LISTAS GENÉRICAS
List<double> numbers = new List<double>();

Console.WriteLine("Digite 'Sair' para encerrar:");

bool run = true;

do
{
    Console.Write("Digite um número: ");
    string? numberStr = Console.ReadLine(); // 'string?' permite valor nulo

    // Verifica se é nulo antes de tratar
    if (numberStr != null && numberStr.Trim().ToLower() == "sair")
    {
        run = false;
        Console.WriteLine("Processo encerrado.");
        break;
    }
    else if (numberStr != null)
    {
        // Removido o ';' do final e adicionada a lógica de inserção na lista
        if (double.TryParse(numberStr, NumberStyles.Float, CultureInfo.InvariantCulture, out double number))
        {
            numbers.Add(number);
            Console.WriteLine($"Número {number} adicionado com sucesso!");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Digite um número válido.");
        }
    }

} while (run);

// LISTAS DE TIPOS ABSTRATOS DE DADOS (TAD)

List<Person> people = new List<Person>();

//criar uma variavel do tipo Person
Person p1 = new Person();
p1.Name = "Henrique";
p1.Age = 42;
p1.Nationality = CountryEnum.BR;

people.Add(p1);

//Adicionando à Lista Inline
people.Add(new Person() 
{
     Name = "Cleber", 
     Age = 27, 
     Nationality = CountryEnum.US 
});

people.Add(new Person()
{
    Name = "Carlitos",
    Age = 27,
    Nationality = CountryEnum.PY
});

//Exemplo de ordenação de Lista Genérica
//Utilizando o LINQ
List<Person> results = 
people.OrderBy(p => p.Name).ToList();

//Percorremos a lista
foreach(Person p in results)
{
    Console.WriteLine(
        $"Nome: {p.Name}, Idade: {p.Age}, Nacionalidade: {p.Nationality}"
    );
}

