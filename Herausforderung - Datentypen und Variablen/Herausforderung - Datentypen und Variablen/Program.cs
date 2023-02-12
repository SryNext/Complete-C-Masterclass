using System;
using System.Transactions;

namespace Herausforderung
{
    class Program
    {
        static void Main(string[] args) 
        {
            byte myByte = 7;
            Console.WriteLine(myByte);

            sbyte mySbyte = -113;
            Console.WriteLine(mySbyte);
            int myInt = 29;
            Console.WriteLine(myInt);
            uint myUint = 16;
            Console.WriteLine(myUint);
            short myShort = +18;
            Console.WriteLine(myShort);
            ushort myUshort = 60;
            Console.WriteLine(myUshort);
            long myLong = -29090234080243;
            Console.WriteLine(myLong);
            ulong myUlong = 12390138038120830192;
            Console.WriteLine(myUlong);
            float myFloat = 17f;
            Console.WriteLine(myFloat);
            double myDouble = 18f;
            Console.WriteLine(myDouble);
            char myCharacter = 'A';
            Console.WriteLine(myCharacter);
            bool myBoolean = true;
            Console.WriteLine(myBoolean);
            decimal myDecimal = 13 * 12 / 13;
            Console.WriteLine(myDecimal);
            string myText = "I control text";
            Console.WriteLine(myText);
            string numText = "15";

            int myNumFromText = int.Parse(numText);

            Console.Write(myNumFromText);
            Console.ReadKey();

        }
    }
}