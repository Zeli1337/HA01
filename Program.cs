namespace HausaufgabeV01;
using System.Collections.Generic; 
using System.Linq;
using Gegenstände;
using Fächer;


class Program
{
    static void Main(string[] args)
    {
        //Gegenstand anlegen
        Gegenstand gegenstand = new Gegenstand(3);
        //Fach anlegen
        Fach fach= new Fach(3, gegenstand);
        //Ausgeben
        System.Console.WriteLine(fach.ToString());
        //Fehler provozieren
        gegenstand.Höhe = 20;
        //Fehler darstellen
        System.Console.WriteLine(fach.ToString());

    }
}
