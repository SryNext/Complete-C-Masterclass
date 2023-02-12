using System;

namespace Namengebung
{
    //  Klassennamen sollten immer mit Großbuchstaben beginnen || z.b. ClientActivity
    class Progam
    {
        //  Methodenname sollten nach Möglichkeit Verben sein, wie z.b. CalculateValue
        //  Methodenargumente werden klein geschrieben
        static void Main(string[] args)
        {
            //  variable heißt wie z.b. itemCount
            //  nutze userControl statt usrCtr

            //  keine Zahlen bei Variablennamen am Anfang verwenden
            int num5 = 3;

            //  richtig
            string myName;
            int year;
            bool isSaved;

            /*
             *  vermeide:
             *  String myName;
             *  Int32 lastNum;
             *  Boolean isSaved;
             */



            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}