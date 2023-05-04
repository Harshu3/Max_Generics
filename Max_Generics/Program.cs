using System;

namespace Max_Generics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Practice Problem!");
            Console.WriteLine("Which data type you want to check?");
            Console.WriteLine("1.Integer\n2.Float\n3.String");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3 values");
            switch (option)
            {
                case 1:
                    int first = Convert.ToInt32(Console.ReadLine());
                    int second = Convert.ToInt32(Console.ReadLine());
                    int third = Convert.ToInt32(Console.ReadLine());
                    Find_Max<int> find = new Find_Max<int>(first, second, third);
                    find.TestMaximum();
                    break;
                case 2:
                    float a = Convert.ToSingle(Console.ReadLine());
                    float b = Convert.ToSingle(Console.ReadLine());
                    float c = Convert.ToSingle(Console.ReadLine());
                    Find_Max<float> max = new Find_Max<float>(a, b, c);
                    max.TestMaximum();
                    break;
                case 3:
                    string x = Console.ReadLine();
                    string y = Console.ReadLine();
                    string z = Console.ReadLine();
                    Find_Max<string> value = new Find_Max<string>(x, y, z);
                    value.TestMaximum();
                    break;
            }
        }
    }
}