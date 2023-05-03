using System;

namespace Max_Generics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Practice Problem!");
            Console.WriteLine("Enter 3 float numbers");
            float first = Convert.ToSingle(Console.ReadLine());
            float second = Convert.ToSingle(Console.ReadLine());
            float third = Convert.ToSingle(Console.ReadLine());
            Find_Max.FindMaxValue(first, second, third);
        }
    }
}