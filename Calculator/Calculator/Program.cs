using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem Based on Abstract class");
            Result result = new Result();
            result.Multiplication(10, 20);
            result.Division(50, 5);
        }
    }
}
