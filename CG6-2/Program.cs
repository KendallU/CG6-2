using System;

namespace CG6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Make a Proclamation to the world!");
            Console.WriteLine("Enter Proclmation here:");
            string proclamation;
            proclamation = Console.ReadLine();
            Console.Write(proclamation.ToUpper());
            Console.ReadLine();
        }
    }
}
