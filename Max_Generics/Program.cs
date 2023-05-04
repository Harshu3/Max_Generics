using System;

namespace Max_Generics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Practice Problem!");
            Console.WriteLine("Please choose a data type from below");
            Console.WriteLine("1.Integer\n2.Float\n3.String");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int[] arr = { 20, 56, 65, 36, 64 };
                    Find_Max<int> find = new Find_Max<int>();
                    Console.WriteLine("Maximun number is:" + find.Max(arr));
                    break;
                case 2:
                    float[] ar = { 20.5f, 65.6f, 56.8f, 35.6f, 98.3f };
                    Find_Max<float> find_ = new Find_Max<float>();
                    Console.WriteLine("Maximun number is: " + find_.Max(ar));
                    break;
                case 3:
                    string[] ary = { "abc", "bca", "cab", "def", "efd", "fed" };
                    Find_Max<string> max = new Find_Max<string>();
                    Console.WriteLine("Maximun value is:" + max.Max(ary));
                    break;
            }
        }
    }
}