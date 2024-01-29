using System;

namespace ClassVeicolo
{
    internal class Auto
    {
        public string nome;
        public string marca;
        public string modello;

        public Auto(string nome, string marca, string categoria)
        {
            this.nome = nome;
            this.marca = marca;
            this.modello = categoria;
        }
        public void showAuto()
        {
            Console.WriteLine($"Nome: {nome}, Cognome: {marca}, Categoria: {modello}");
        }


    }
}
