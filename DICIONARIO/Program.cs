using System.Collections;
Hashtable phonebook 
        = new Hashtable()
{
    {"Edson Arantes do Nascimento", "0000"},
    {"Ronadlo Nazáreo dos Santos", "1111"},
    {"Luiz Inácio Lula da Silva", "2222"}
};
//Adicionando em tempo de execução
phonebook["Acelino Popô de Freitas"] = "33333";
//Tratando possível erro de duplicidade de chave
try
{
    phonebook.Add("Edson Arantes do Nascimento", "00000");
}
catch (System.ArgumentException ae) 
{
        Console.WriteLine ("Chave já existente. " + ae.Message);
}       
catch (System.Exception ex) 
{
        Console.WriteLine("Erro Imprevisto. " + ex.Message);
}
//Percorrendo Valores
     Console.WriteLine("Caderninho de telefones");
if(phonebook.Count == 0)
{
    Console.WriteLine("Agenda vazia");
}
else
{
    int i = 1;
    foreach (DictionaryEntry entry in phonebook)
    {
        Console.WriteLine($"{i}. {entry.Key}. {entry.Value}");
        i++;
    }
}

// BUSCA VALORES
Console.WriteLine ("");
Console.WriteLine("Busca Por Nome: ");
string name = Console.ReadLine();

if(phonebook.Contains(name))
{
    string number = (string)phonebook[name];
    Console.WriteLine($"{name} - {number}");
}
else
{
    Console.WriteLine($"{name} não encontrado. ");
    
}

//Dicionários

Dictionary<string, string>dic = 
    new Dictionary<string, string>()
{
    {"Dom Pedrão II", "123456" },
    {"Joaquim José da Silva Xavier", "112233" },
};
    
//Obtendo Valor do Dicionário
string value = dic["Dom Pedrão II"];

dic["Dom Pedrão II"] = "666";

foreach(KeyValuePair<string, string> entry in dic)
{
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}