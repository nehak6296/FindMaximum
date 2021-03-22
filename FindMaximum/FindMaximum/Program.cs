using System;

namespace FindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Problem using Generics");
            
            int output = MaximumNumberCheck.MaximumIntegerNumber(11,32,44);
            Console.WriteLine(output);
        }
    }
}
