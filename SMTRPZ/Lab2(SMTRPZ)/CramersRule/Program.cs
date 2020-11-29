using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CramersRule
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 1, -1 }, { 3, -1, -1, -1 }, { -2, 2, 3, 5 } };
            var cramer = new Cramer();
            double[] answer = cramer.SolveEquationSystem(matrix);
            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }

}
