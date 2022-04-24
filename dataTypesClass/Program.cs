using System;

namespace dataTypesClass
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Declaring Variables.
            int num1;
            //Declaring multiple variables at once
            int num3, num4, num5;
            //assigning a value to a variable.
            num1 = 13;

            //Declaring and initializing a variable in one go.
            int num2 = 23;
            num2 = 100;

            //printing it on the console.
            //Console.WriteLine(sum);
            //Console.Read();

            //using concatination
            Console.WriteLine("Num1 is " + num1);
            int sum = num1 + num2;
            Console.WriteLine("Num1: " + num1 + " + Num2: " + num2 + " is " + sum);

            double d1 = 3.1415; // more precise, see result runing the programm
            double d2 = 5.1;
            double dDiv = d1 / d2;

            Console.WriteLine("d1/d2 is: " + dDiv);

            float f1 = 3.1415f; // less precise, see result runing the programm
            float f2 = 5.1f;
            float fDiv = f1 / f2;

            Console.WriteLine("f1/f2 is: " + fDiv);
        }
    }
}
