using System;

namespace CramersRule
{
    class Cramer
    {
      
        public double[] SolveEquationSystem(int[,] equationArgs)
        {
            Func<int[,], int> determinant = DefineMatrixDeterminant;

            int[,] mainMatrix = GetMatrixByColumnNumber(equationArgs, 0, 1, 2);
            int[,] firstMatrix = GetMatrixByColumnNumber(equationArgs, 3, 1, 2);
            int[,] secondMatrix = GetMatrixByColumnNumber(equationArgs, 0, 3, 2);
            int[,] thirdMatrix = GetMatrixByColumnNumber(equationArgs, 0, 1, 3);
            double x = determinant(firstMatrix) / determinant(mainMatrix);
            double y = determinant(secondMatrix) / determinant(mainMatrix);
            double z = determinant(thirdMatrix) / determinant(mainMatrix);

            return new[] { x, y, z };
        }

        private int[,] GetMatrixByColumnNumber(int[,] inputMatrix, int a, int b, int c)
        {
            int[,] tempMatrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                tempMatrix[i, 0] = inputMatrix[i, a];
                tempMatrix[i, 1] = inputMatrix[i, b];
                tempMatrix[i, 2] = inputMatrix[i, c];

            }
            return tempMatrix;
        }

        private int DefineMatrixDeterminant(int[,] matrix)
        {
            int det = 0;

            for (int i = 0; i < 3; i++)
            {
                det += (matrix[0, i] * (matrix[1, (i + 1) % 3] * matrix[2, (i + 2) % 3] - matrix[1, (i + 2) % 3] * matrix[2, (i + 1) % 3]));
            }

            return det;
        }
    }

}
