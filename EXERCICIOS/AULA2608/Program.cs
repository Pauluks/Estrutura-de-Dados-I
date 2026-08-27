using System;
using System.Collections.Generic;

namespace AgendaSortedList
{
    // Enumeração para representar os países
    public enum CountryEnum
    {
        PL,
        UK,
        DE
    }

    // Classe para representar os dados da pessoa
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public CountryEnum Country { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Criação da lista ordenada (SortedList) usando chave (string) e valor (Person)
            SortedList<string, Person> people = new SortedList<string, Person>();

            // Adicionando elementos à coleção
            // A ordenação é feita automaticamente pela chave (Nome)
            people.Add("Marcin", new Person() 
            { 
                Name = "Marcin", 
                Country = CountryEnum.PL, 
                Age = 29 
            });

            people.Add("Sabine", new Person() 
            { 
                Name = "Sabine", 
                Country = CountryEnum.DE, 
                Age = 25 
            });

            people.Add("Ann", new Person() 
            { 
                Name = "Ann", 
                Country = CountryEnum.PL, 
                Age = 31 
            });

            // Iterando pelos elementos da coleção utilizando KeyValuePair
            foreach (KeyValuePair<string, Person> person in people)
            {
                Console.WriteLine($"{person.Value.Name} ({person.Value.Age} years) from {person.Value.Country}.");
            }
        }
    }
}