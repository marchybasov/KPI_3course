using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_5_DelegateApplication
{
    class Program
    {


        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 9 };

            Action<int> writeMe = WriteMe;
            Array.ForEach(arr, writeMe);
            Predicate<int> isEven = Condition;
            int[] evenNumbers = Array.FindAll(arr, isEven);
            Console.WriteLine("Even numbers");
            Array.ForEach(evenNumbers, writeMe);
            Console.ReadKey();
        }
        static void WriteMe(int i) => Console.WriteLine(i);
        static bool Condition(int i) => i % 2 == 0;

    }
}
