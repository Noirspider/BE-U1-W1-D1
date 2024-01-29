using System;


namespace ClassDipendente
{
    internal class Dipendente
    {
        public string nome;
        public string cognome;
        public string azienda;

        public Dipendente(string nome, string cognome, string azienda)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.azienda = azienda;
        }
        public void showDipendente()
        {
            Console.WriteLine($"Nome: {nome}, Cognome: {cognome}, Categoria: {azienda}");
        }


    }
}
