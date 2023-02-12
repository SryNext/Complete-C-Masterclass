using System;
using System.Security.Cryptography.X509Certificates;

namespace VoidMethode
{
    class Program
    {
        //  Startpunkt des Programmes
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomething();
            WriteSomething();
            string myArgument = "Hallo, ich bin super Text";
            WriteSomethingSpecific(myArgument);
            Console.ReadKey();
        }

        //  Zugriffsmodifizierer (static) Rückgabetyp Methodenname(parameter1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("Ich bin eine Methode!");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

    }
}