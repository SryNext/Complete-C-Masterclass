using Microsoft.Win32.SafeHandles;
using System;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string my2ndString = "13";
            int num1 = int.Parse(myString);
            int num2 = int.Parse(my2ndString);
            int resultInt = num1+ num2;

            string result = myString+ my2ndString;
            Console.WriteLine(resultInt);
            Console.ReadKey();
        }
    }
}