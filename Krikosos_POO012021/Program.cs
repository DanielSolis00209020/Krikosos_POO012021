//Krikosos, Github practice
using System;

namespace Krikosos_POO012021
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 0;
            //Ask for a value for a
            Console.WriteLine("Enter a value for a: ");
            a = Int32.Parse(Console.ReadLine());
            //Ask for a value for b
            Console.WriteLine("Enter a value for b:");
            b = Int32.Parse(Console.ReadLine());
            //this will display the results of the method operation
            Console.WriteLine($"Multiplicating {a} * {b} equals {MultiplicateNumbers(a, b)} ");
        }
        //Final method
        public static int MultiplicateNumbers(int a, int b)
        {
            return a * b;//multiplication
        }
    }
}