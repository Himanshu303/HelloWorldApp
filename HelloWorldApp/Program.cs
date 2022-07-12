using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("My name is Himanshu");
            Add(5, 2);
        }
    }
}
