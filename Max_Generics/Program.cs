using System;

namespace Max_Generics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Practice Problem!");
            Console.WriteLine("Enter 3 string values");
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string third = Console.ReadLine();
            Find_Max.FindMaxValue(first, second, third);
        }
    }
}