using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_SMTRPZ_
{
    class ArrayHandler
    {
        public int[,] CreateRandomJaggedArray(int rows, int columns)
        {
            int[,] randomArr = new int[rows, columns];
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    randomArr[i, j] = random.Next(-50, 50);
                }

            }


            return randomArr;
        }
        public void PrintJaggedArray(int[,] incomingArray)
        {
            string outputString = String.Empty;
            int rowLength = incomingArray.GetLength(0);
            int colLength = incomingArray.GetLength(1);
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    outputString += incomingArray[i, j] + "\t";
                }
                outputString += "\n";
                
            }
            Console.WriteLine(outputString);
        }

    }
}
