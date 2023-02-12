using System;

namespace HerausforderungMethoden
{
    class Program
    {
        static void Main(string[] args) 
        {
            string friend1 = "Frank";
            string friend2 = "Horst";
            string friend3 = "Hanswurst";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
            Console.ReadKey();
        }
        
        //  Einzelaufruf
        public static void GreetFriend(string friendName)
        {
            Console.WriteLine("Hi " + friendName + ", mein Freund");
        }

        //  Mehrfachaufruf
        public static void GreetFriend(string friendName, string friendName2, string friendname3)
        {
            Console.WriteLine("Hi " + friendName + ", mein Freund", friendName);
            Console.WriteLine("Hi " + friendName + ", mein Freund", friendName2);
            Console.WriteLine("Hi " + friendName + ", mein Freund", friendname3);
        }
}
}