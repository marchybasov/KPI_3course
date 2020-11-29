namespace Lab2_SMTRPZ_
{
    interface IArrayPrinter
    {
        void PrintArray<T>(T[] array, string separator);
        void PrintMultiDimArray<T>(T[,] arr);
    }
}
