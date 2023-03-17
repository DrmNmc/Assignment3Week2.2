using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            try
            {
                Console.Write("Enter a double value: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter a second double value: ");
                num2 = double.Parse(Console.ReadLine());

            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input, please restart the program.");
            
            }
            //add
            Func<double, double, double> add = (a, b) => a + b;
            //multiply
            Func<double, double, double> multiply = (a, b) => a * b;
            //min value
            Func<double, double, double> smaller = (a, b) =>
            {
                if (a < b)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            };

            Console.WriteLine($"The sum of {num1} and {num2} is: {add(num1, num2)}");
            Console.WriteLine($"The product of {num1} and {num2} is: {multiply(num1, num2)}");
            Console.WriteLine($"The smaller value between {num1} and {num2} is: {smaller(num1, num2)}");
        }
    }
}
