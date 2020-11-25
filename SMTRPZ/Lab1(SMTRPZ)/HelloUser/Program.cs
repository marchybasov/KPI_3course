using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.WriteLine("Write your name");
                
                string userName = Console.ReadLine();
                if (userName != String.Empty)
                {
                    Console.WriteLine("Hello, {0}!", userName.TrimStart().TrimEnd());

                   
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
                Console.WriteLine("Press any key to repeat. Press \"ESC\" to finish");
                keyInfo = Console.ReadKey();

            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
