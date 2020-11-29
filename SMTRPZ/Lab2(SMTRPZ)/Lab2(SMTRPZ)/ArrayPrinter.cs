using System;

namespace Lab2_SMTRPZ_
{
    class ArrayPrinter : IArrayPrinter
    {
        public void PrintArray<T>(T[] array, string separator)
        {
            string outputString = String.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                outputString += array[i].ToString() +separator;
            }
            Console.WriteLine(outputString) ;
        }


        public void PrintMultiDimArray<T>(T[,] arr)
        {
            string outputString = String.Empty;
            int rowLength = arr.GetLength(0);
            int colLength = arr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    outputString += arr[i, j] + "\t";
                }
                outputString += "\n";

            }
            Console.WriteLine(outputString);
        }


    }
}
