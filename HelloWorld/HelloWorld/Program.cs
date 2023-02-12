using System;

namespace HelloWorld
{
    class Program
    {
        //  Einstiegspunkt für das Program

        static void Main(string[] args)
        {
            //  Setzt die Hintergrundfarbe der Konsole
            Console.BackgroundColor= ConsoleColor.DarkGray;
            //  Setzt die Schriftfarbe der Konsole
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hallo Welt!");
            Console.WriteLine("Hallo ...");
            //  Wartet auf Eingabe einer Taste für weitere Ausführung
            Console.ReadKey();
            
        }
    }
}
