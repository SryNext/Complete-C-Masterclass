using System;

namespace ImpliziteUndExpliziteKonvertierung
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Implizite Konvertierung
            int num = 123456;
            long bigNum = num;

            float myFloat = 13.37f;
            double myDouble = myFloat;

            //  Exziplite Konvertierung
            int myInt;
            double myNewDouble = 13.37;
            myInt = (int)myNewDouble;

            string myString = myDouble.ToString();   // "13.37";
            string myString2 = myString + "12";
            bool sunIsShining = true;

            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);
            Console.ReadKey();
        }
    }
}