using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_SMTRPZ_
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayHandler worker = new ArrayHandler();
            int[,] myArr = worker.CreateRandomJaggedArray(5, 5);

            worker.PrintJaggedArray(myArr);
            Console.ReadKey();

        }
    }
}
