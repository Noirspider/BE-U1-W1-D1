using ClassDipendente;
using ClassAnimali;
using ClassAtleta;
using ClassVeicolo;
using System;


namespace U2_W1_D1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dipendente dipendente1 = new Dipendente("Pippo", "Rossi", "Juventus");
            dipendente1.showDipendente();
            Animal animal1 = new Animal("Franco", "cammelo", "Mammifero");
            animal1.showAnimali();
            Auto auto1 = new Auto("Pietro", "Garden Tir", "Giardinaggio");
            auto1.showAuto();
            Atleta atleta1 = new Atleta("Paolo", "Rossi", "Calcio");
            atleta1.showAtleta();  
            Console.ReadKey();  

        }
    }
}
