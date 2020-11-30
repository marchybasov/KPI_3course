using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{

    class Program
    {


        static void Main(string[] args)
        {
            DoTask1();
            DoTask2();
            DoTask3();
            DoTask4();
            DoTask5();
        }

        static void DoTask1()
        {
            ArrayList arrList = new ArrayList();
            arrList.Add(1.3);
            arrList.Add(56);
            arrList.Add(new string[] { "Lab2", "SMTRPZ" });
            arrList.Add(new List<string> { "list", "of", "strings" });

            var e = arrList.GetEnumerator();
            while (e.MoveNext())
            {
                object obj = e.Current;
                if (obj is IEnumerable)
                {
                    foreach (var item in obj as IEnumerable)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine(obj);
                }
            }
            Console.ReadKey();

        }

        static void DoTask2()
        {
            SortedList<int, string> zp92 = new SortedList<int, string>();

            zp92.Add(3, "Gelemei");
            zp92.Add(10, "Zdanova");
            zp92.Add(1, "Archybasov");
            zp92.Add(9, "Dybinka");
            zp92.Add(6, "Gryshko");
            zp92[15] = "Nosova";
            zp92[13] = "Kozlinskii";


            Console.WriteLine("List of students sorted by order");
            foreach (var student in zp92)
            {
                Console.WriteLine(student.Key + " " + student.Value);
            }

            Console.WriteLine("Value by key \"6\" = {0}", zp92[6]);
            Console.WriteLine("Key by value \"Archybasov\" = {0}", zp92.ElementAt(zp92.IndexOfValue("Archybasov")).Key);

            Console.ReadLine();


        }

        static void DoTask3()
        {
            Stack<int> numbersStack = new Stack<int>();

            for (int i = 0; i < 3; i++)
            {
                numbersStack.Push(i + 1);
                Console.WriteLine($"{i + 1} has been pushed to stack");
            }
            Console.WriteLine("first available element in stack is: {0}", numbersStack.ElementAt(0));
            Console.ReadKey();

        }
        static void DoTask4()
        {
            Dictionary<int, string> numbers = new Dictionary<int, string>();
            numbers.Add(1, "one");
            numbers.Add(2, "two");
            numbers.Add(3, "three");
            numbers.Add(4, "four");
            numbers.Add(5, "five");
            numbers.Add(6, "six");
            numbers.Add(7, "seven");
            numbers.Add(8, "eight");
            numbers.Add(9, "nine");
            numbers.Add(0, "zero");
            ConsoleKeyInfo keyPressed;

            do
            {
                Console.Clear();
                Console.WriteLine("Enter a text equivalent of a digit from 0 to 9");

                string input = Console.ReadLine().TrimStart().TrimEnd();
                int keyInput = numbers.FirstOrDefault(x => x.Value == input).Key;
                Console.WriteLine("Your input is: {0}", keyInput);
                keyPressed = Console.ReadKey();

            } while (keyPressed.KeyChar != (int)ConsoleKey.Escape);


        }

        static void DoTask5()
        {

            Console.WriteLine("Enter any sentence");
            string inputStr = Console.ReadLine();
            string[] wordsInString = inputStr.Split(' ');
            string wordWithBiggestConsonant = string.Empty;
            int maxConsonants = 0;
            foreach (var word in wordsInString)
            {
                int wordConsonantsAmount = DefineConsonantsAmonut(word);
                if (wordConsonantsAmount > maxConsonants)
                {
                    maxConsonants = wordConsonantsAmount;
                    wordWithBiggestConsonant = word;
                }
            }
            Console.WriteLine("Word with biggest amount of consonants is: {0}", wordWithBiggestConsonant);

            string wordOrderedChars = SortCharsInWordByOrder(wordWithBiggestConsonant);
            Console.WriteLine("Reordered chars in the word: {0}", wordOrderedChars);
            Console.ReadKey();
        }

        static int DefineConsonantsAmonut(string input)
        {
            List<char> Consonants = new List<char> { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Z', 'Y' };
            string word = input.ToUpper();

            int consonants = 0;
            for (int i = 0; i < word.Length; i++)
            {

                if (Consonants.Contains(word[i]))
                {
                    consonants++;
                }
            }
            return consonants;
        }
        static string SortCharsInWordByOrder(string input)
        {
            string outputString = String.Empty;
            char[] sortedChars = input.ToCharArray();
            CharSorter sorter = new CharSorter();
            Array.Sort(sortedChars, sorter);
            
            foreach (var item in sortedChars)
            {
                outputString += item;
            }

            return outputString;

        }


    }

    class CharSorter : IComparer<char>
    {
        public int Compare(char x, char y)
        {
            if (x > y)
            {
                return 1;
            }
            else if (x < y)
            {
                return -1;
            }
            else { }
            {
                return 0;
            }
        }
    }
}
