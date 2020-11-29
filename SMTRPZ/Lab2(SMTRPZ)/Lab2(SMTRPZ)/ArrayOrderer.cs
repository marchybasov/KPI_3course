namespace Lab2_SMTRPZ_
{
    public static class ArrayOrderer
    {
        public static string[] SortByStringLength(string[] data) //bubble sort
        {
            int i, j;
            int dataLength = data.Length;

            for (j = dataLength - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i].Length > data[i + 1].Length)
                    {
                        string temp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = temp;
                    }
                }
            }
            return data;
        }

        public static void SortByValueDesc(ref int[] data) //bubble sort
        {
            int i, j;
            int dataLength = data.Length;

            for (j = dataLength - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] < data[i + 1])
                    {
                        int temp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = temp;
                    }
                }
            }
        }

      

    }


}
