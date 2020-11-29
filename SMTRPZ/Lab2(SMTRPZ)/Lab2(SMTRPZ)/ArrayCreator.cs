using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_SMTRPZ_
{
    public static class ArrayCreator
    {
        public static int[,] CreateRandomMultiDimArray(int rows, int columns)
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

        public static int[] CreateRandomIntArray(int length)
        {
            int[] arr = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = random.Next(-50, 50);
            }
            return arr;
        }



    }


}
