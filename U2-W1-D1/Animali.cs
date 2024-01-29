using System;

namespace ClassAnimali
{
    internal class Animal
    {
        public string nome;
        public string razza;
        public string specie;

        public Animal(string nome, string razza, string specie)
        {
            this.nome = nome;
            this.razza = razza;
            this.specie = specie;
        }
        public void showAnimali()
        {
            Console.WriteLine($"Nome: {nome}, Cognome: {razza}, Specie: {specie}");
        }


    }
}

