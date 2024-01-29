using System;

namespace ClassAtleta
{
    internal class Atleta
    {
        public string nome;
        public string cognome;
        public string categoria;

        public Atleta(string nome, string cognome, string categoria)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.categoria = categoria;
        }
        public void showAtleta()
        {
            Console.WriteLine($"Nome: {nome}, Cognome: {cognome}, Categoria: {categoria}");
        }


    }
}
