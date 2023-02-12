using System;


namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Deklarieren und Initialisieren der Variablen meinName
            string meinName = "Domi";

            string nachricht = "Mein name ist " + meinName;
            int laengeDesStrings = nachricht.Length;
            //  die ToUpper Methode gibt den String in Großschrift aus.
            string allesGrossGeschrieben = nachricht.ToUpper();
            string allesKleinGeschrieben = nachricht.ToLower();

            Console.WriteLine(allesKleinGeschrieben);
            Console.WriteLine(allesGrossGeschrieben);
            Console.WriteLine(nachricht + " ist {0} Zeichen lang", laengeDesStrings);
            Console.ReadKey();
        }

    }
}