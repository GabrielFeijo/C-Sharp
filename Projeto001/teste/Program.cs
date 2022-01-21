using System;
using CSharp;
using Interface;
using Enun;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            var pessoa1 = (Person)0;
            Person pessoa2 = Person.Giovana;
            Person pessoa3 = (Person)4;

            Pessoa person = new Pessoa();

            person.Nome = "Gabriel";
            person.Idade = 19;
            person.Estado = "PE";

            var person2 = new Pessoa();

            person2.Nome = "Lívia";
            person2.Idade = 20;
            person2.Estado = "MG";

            Animal animal = new Animal();


            animal.Nome = "Rex";
            animal.NomeDono = "Pedro";
            animal.Especie = "Cachorro";

            Console.WriteLine(person2.Nome);
           Console.WriteLine(person2.Idade);
           Console.WriteLine(person2.Estado);
            Console.WriteLine(animal.Especie);
            Console.WriteLine(pessoa1);
            Console.WriteLine(pessoa2);
            Console.WriteLine(pessoa3);


        }
    }
}
