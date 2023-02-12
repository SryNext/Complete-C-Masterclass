using System;

namespace DatenTypen
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Deklarieren und initialisieren der Variable wert1
            int wert1 = 25;
            //  Deklarieren
            int wert2;
            //  Initialisieren
            wert2 = 15;
            int summe = wert2+ wert1;
            //  Deklarieren mehrerer Variablen in einer Zeile
            int wert3, wert4, wert5;

            double d1 = 333.5;
            double d2 = 1.337;
            double ergebnis = d1 / d2;

            //  Verwendung von Gleitkommazahlen mit Float
            float f1 = 1.337f;

            Console.WriteLine("Ergebnis ist " + ergebnis);
            Console.ReadKey();
        }
    }
}