using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fibonnaci sequence length");
            string userInput = Console.ReadLine();
            int fibonacciLength;
            try
            {
                fibonacciLength = int.Parse(userInput);

                for (int i = 0; i < fibonacciLength; i++)
                {
                    Console.Write(Fibonacci(i)+" ");
                }
                Console.WriteLine("");
                Console.ReadLine();
            }
            catch (FormatException)
            {

                Console.WriteLine($"{userInput}: incorrect input");
            }

        }

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
