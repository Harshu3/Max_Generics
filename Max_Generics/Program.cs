using System;

namespace Max_Generics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Practice Problem!");
            Console.WriteLine("Enter 3 integer numbers");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());
            Find_Max.FindMaxValue(first, second, third);
        }
    }
}