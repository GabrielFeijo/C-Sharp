using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp
{ 
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Estado { get; set; }
    }

}


namespace Interface
{
    interface IAnimal
    {
        void Nome(string nome);

        void Dono(string nomeDono);

        void Especie(string Especie);
    }

    class Animal : IAnimal
    {
        public string Nome { get; set; }

        public string NomeDono { get; set; }

        public string Especie { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }
        void IAnimal.Dono(string nomeDono)
        {
            this.NomeDono = nomeDono;
        }
        void IAnimal.Especie(string especie)
        {
            this.Especie = especie;
        }
    }
}


namespace Enun
{
    enum Person
    {
        Gabriel,
        Giovana,
        João,
        Kleber,
        Gustavo
    }
}