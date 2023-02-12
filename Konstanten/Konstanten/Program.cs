using System;

namespace Konstanten
{
    class Program
    {
        /*  Konstanten ( bleibende Körper ) sind normalerweise Felder welche während
         *  der Kompilierzeit bekannt sind und danach für die gesamte Laufzeit
         *  des Programmes nicht verändert werden können. Muss Sofort definiert werden */
        const double PI = Math.PI;
        const int weeks = 52, months = 12;
        const string geburtstag = "17.10.1993";


        static void Main(string[] args)
        {
            
            Console.WriteLine("Mein Geburtstag ist am: " + geburtstag);
            Console.ReadKey();
        }
    }
}