using System;

namespace FindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Problem using Generics");
            
            int integerOutput = MaximumNumberCheck.MaximumIntegerNumber(11,44,33);
            Console.WriteLine(integerOutput);

            double doubleOutput = MaximumNumberCheck.MaximumFloatNumber(111.44, 44.20, 33.65);
            Console.WriteLine(doubleOutput);

<<<<<<< HEAD
            string stringOutput = MaximumNumberCheck.MaximumStringNumber("22","44","33");
=======
            string stringOutput = MaximumNumberCheck.MaximumStringNumber("Apple","Carrot","Banana");
>>>>>>> UC3-FindMaxStringNumber
            Console.WriteLine(stringOutput);
        }
    }
}
