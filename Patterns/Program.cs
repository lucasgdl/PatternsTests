using System;
using Patterns.

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            Console.WriteLine("SINGLETON");
            if(s1 == s2)
            {
                Console.WriteLine("Singleton works");
            }
            else
            {
                Console.WriteLine("Singleton failed");
            }

            Console.WriteLine("---------------");


        }
    }
}
