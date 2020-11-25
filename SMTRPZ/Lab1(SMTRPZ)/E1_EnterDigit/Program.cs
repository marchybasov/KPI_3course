using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1_EnterDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int i, i2;

            try
            {

                i = Int32.Parse(s);
                i2 = Convert.ToInt32(s);
                Console.WriteLine("i={0} i2={1}", i, i2);

            }
            catch (FormatException)
            {

                Console.WriteLine($"{s}: incorrect input");
            }

            //task1




        }
       
       

    }
}
