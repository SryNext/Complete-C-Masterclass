using System;

namespace MethodenMitRueckgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = Add(15, 23);
            Console.WriteLine(Multiply(32,55));
            Console.WriteLine(Devide(13,23));
            Console.WriteLine(Add(15, 23));
            Console.ReadLine();
        }

        public static int Add(int num1, int num2)
        {
            return num1+ num2;
        }

        public static int Multiply(int num1, int num2)
        {
            int result = num1*num2;
            return result;
        }

        public static double Devide(double num1, double num2)
        {
            return num1/num2;
        }

    }
}