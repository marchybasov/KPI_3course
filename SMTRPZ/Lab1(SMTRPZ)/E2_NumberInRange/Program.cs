using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_NumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int i;

            try
            {
                s = Console.ReadLine();
                i = int.Parse(s);
                string message;

                if (IsInRange(i, -10, 10))
                {
                    message = $"number {i} is in range -10..10";
                }
                else
                {
                    message = $"number {i} is  not in range -10..10";
                }
                Console.WriteLine(message);
                Console.ReadKey();
            }
            catch (Exception)
            {

                throw;
            }
           
           
        }

        static bool IsInRange(int number, int lowerBound, int upperBound) => (number <= upperBound && number >= lowerBound);
    }
}
