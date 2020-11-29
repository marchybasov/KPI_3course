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
            IArrayPrinter printer = new ArrayPrinter();

            DoTask1_2(printer);
            DoTask3(printer);
            DoTask4();
            DoTask5(new int[] { -5, 2 }, new int[] { 7, -7 }, new int[] { 5, 7 });
            DoTask6(printer, 10);
            DoTask7(printer, 5, 7);
            DoTask8(printer, 5, 7);
            


        }

        static void DoTask1_2(IArrayPrinter printer)
        {
            Console.WriteLine("Original array:");
            int[,] myArr = ArrayCreator.CreateRandomMultiDimArray(5, 5);

            printer.PrintMultiDimArray(myArr);

            Console.WriteLine("Copied array:");
            int[,] copiedArr = new int[5, 5];
            Array.Copy(myArr, copiedArr, myArr.Length);
            printer.PrintMultiDimArray(copiedArr);

            Console.WriteLine("Cloned array:");
            int[,] clonedArr = (int[,])myArr.Clone();

            printer.PrintMultiDimArray(clonedArr);

            myArr[4, 4] = 10;
            clonedArr[0, 0] = -158;

            copiedArr[0, 1] = 513;

            Console.WriteLine("original, cloned and copied array have been changed!");
            Console.WriteLine("Orginal array after change (el[4,4]=10):");
            printer.PrintMultiDimArray(myArr);
            Console.WriteLine("Copied array after change (el[0,1]=513):");
            printer.PrintMultiDimArray(copiedArr);
            Console.WriteLine("Cloned arr after change (el[0,0]=158):");
            printer.PrintMultiDimArray(clonedArr);

            Console.ReadKey();
        }

        static void DoTask3(IArrayPrinter printer)
        {
            string[] inputArr = new string[3];
            Console.WriteLine("Enter three rows with random length:");

            for (int i = 0; i < inputArr.Length; i++)
            {
                Console.WriteLine($"row {i + 1}");
                inputArr[i] = Console.ReadLine();
            }
            string[] orderedArr = ArrayOrderer.SortByStringLength(inputArr);
            Console.WriteLine("Sorted string array:");
            printer.PrintArray(orderedArr, "\n");

            Console.ReadLine();
        }

        static void DoTask4()
        {
            Console.WriteLine("Define array length");
            try
            {
                int arrLenth = Int32.Parse(Console.ReadLine().TrimEnd().TrimStart());
                int[] arr = new int[arrLenth];
                for (int i = 0; i < arrLenth; i++)
                {
                    Console.WriteLine($"Enter {i + 1} element:");
                    arr[i] = Int32.Parse(Console.ReadLine().TrimEnd().TrimStart());
                }
                new ArrayMath().GetArraySum(arr);
                Console.ReadKey();
            }
            catch (InvalidCastException)
            {

                Console.WriteLine("Incorrect input");
            }

        }

        static void DoTask5(int[] cordsA, int[] cordsB, int[] cordsC)
        {
                 

            //найдем длины сторон треугольника
            double AB = Math.Round(Math.Sqrt(Math.Pow((cordsB[0] - cordsA[0]), 2) + Math.Pow((cordsB[1] - cordsA[1]), 2)), 2);
            double AC = Math.Round(Math.Sqrt(Math.Pow((cordsC[0] - cordsA[0]), 2) + Math.Pow((cordsC[1] - cordsA[1]), 2)), 2);
            double BC = Math.Round(Math.Sqrt(Math.Pow((cordsC[0] - cordsB[0]), 2) + Math.Pow((cordsC[1] - cordsB[1]), 2)), 2);

            Console.WriteLine($"|AB|={AB}; |AC|={AC}; |BC|= {BC}");

            //длина медианы через три стороны
            double m = Math.Round(0.5 * Math.Sqrt(2 * Math.Pow(AB, 2) + 2 * Math.Pow(AC, 2) + 2 * Math.Pow(BC, 2)), 2);
            Console.WriteLine($"Median line height = {m}");

            //длина высоты опущенной на сторону АВ через три стороны и полупериметр
            double p = (AB + AC + BC) / 2; //полупериметр 
            double h = Math.Round((2 / AB) * (Math.Sqrt(p * (p - AB) * (p - AC) * (p - BC))), 2);
            Console.WriteLine($"Height = {h}");

            //длина биссектрисы через три стороны 
            double midLine = Math.Round(Math.Sqrt(AB * AC * (AB + AC + BC) * (AB + AC - BC)) / (AB + AC));
            Console.WriteLine($"Midline length = {midLine}");

            Console.ReadKey();

        }

        static void DoTask6(IArrayPrinter printer, int arrLength)
        {

            int[] myArray = ArrayCreator.CreateRandomIntArray(arrLength);
            int lastElement = myArray[arrLength - 1];
            Console.WriteLine("Orginal array:");
            printer.PrintArray(myArray, "\t");
            int[] sortedArr = new int[arrLength - 1];
            Array.Copy(myArray, sortedArr, arrLength - 1);
            ArrayOrderer.SortByValueDesc(ref sortedArr);
            Console.WriteLine("Array with n-1 elements sorted descending:");
            printer.PrintArray(sortedArr, "\t");
            Console.WriteLine($"Element to be inserted into array: {lastElement}");
            Array.Resize(ref sortedArr, sortedArr.Length + 1);
            int p = 0;

            for (int i = 0; i < sortedArr.Length; i++)
            {
                if (lastElement > sortedArr[i])
                {
                    p = i;
                    break;
                }
            }
            for (int i = sortedArr.Length - 1; i >= p; i--)
            {
                sortedArr[i] = sortedArr[i - 1];
            }
            sortedArr[p] = lastElement;
            Console.WriteLine($"Last element included at {p} index");
            printer.PrintArray(sortedArr, "\t");


            Console.ReadLine();

        }

        static void DoTask7(IArrayPrinter printer, int m, int n)
        {

            int[,] matrix = ArrayCreator.CreateRandomMultiDimArray(m, n);
            int[] rowsSummArr = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    rowSum += matrix[i, j];
                }
                rowsSummArr[i] = rowSum;
            }

            Console.WriteLine("Original array:");
            printer.PrintMultiDimArray(matrix);

            Console.WriteLine("Rows summ array:");
            printer.PrintArray(rowsSummArr, "\t");

            int[] rowsSummArrSorted = (int[])rowsSummArr.Clone();

            ArrayOrderer.SortByValueDesc(ref rowsSummArrSorted);
            Console.WriteLine("Rows summ array sorted:");
            printer.PrintArray(rowsSummArrSorted, "\t");

            int[,] sortedMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int tempRowNum = Array.IndexOf(rowsSummArr, rowsSummArrSorted[i]);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sortedMatrix[i, j] = matrix[tempRowNum, j];
                }

            }
            Console.WriteLine("Matrix sorted by rows summ: ");
            printer.PrintMultiDimArray(sortedMatrix);

            Console.ReadKey();



        }

        static void DoTask8(IArrayPrinter printer, int m, int n)
        {
            int[,] matrix = ArrayCreator.CreateRandomMultiDimArray(m, n);
            Console.WriteLine("Original matrix");
            printer.PrintMultiDimArray(matrix);
            int[] poistiveNumbersInRow = new int[matrix.GetLength(0)];
            int positiveNumAmount;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                positiveNumAmount = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]>0)
                    {
                        positiveNumAmount++;
                    }
                }
                poistiveNumbersInRow[i] = positiveNumAmount;
            }
            Console.WriteLine("Positive numbers amount by row");
            printer.PrintArray(poistiveNumbersInRow, "\t");

            int[] negativeNumbersInColumn = new int[matrix.GetLength(1)];
            int negativeNum;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                negativeNum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i,j]<0)
                    {
                        negativeNum++;
                    }
                }
                negativeNumbersInColumn[j] = negativeNum;
            }

            Console.WriteLine("Negative numbers amount by column:");
            printer.PrintArray(negativeNumbersInColumn, "\t");

            Console.ReadKey();
            
        }

    }
}
