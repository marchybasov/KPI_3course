using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GKDLab2
{
    class Cipher
    {
        private Dictionary<char, int> alphabet = new Dictionary<char, int>() {
            {'А', 1 }, { 'Б', 2 }, {'В', 3 }, {'Г', 4 }, {'Д',  5 }, { 'Е', 6 }, { 'Є',  7 }, {'Ж',  8 }, {'З',   9 },
            {'И', 10 }, {'І', 11 },{'Ї',  12 }, {'Й', 13 },{'К', 14 },{'Л', 15 },{'М', 16 }, {'Н', 17 },{'О', 18 },{'П', 19 },
            {'Р', 20 },{'С', 21 },{'Т', 22 },{'У', 23 },{'Ф', 24 },{'Х', 25},{'Ц', 26 },{'Ч', 27 },{'Ш', 28 },{'Щ', 29 },{'Ю', 30 },{'Я', 31 },{'Ь',  32 },
            {'а', 33 },{'б', 34 },{'в', 35 },{'г', 36 },{'д', 37 },{'е', 38},{'є', 39 },{'ж', 40 },{'з', 41 },{'и', 42 },{'і',  43 },{'ї',44 },{'й', 45 },
            {'к', 46 },{'л', 47 },{'м', 48 },{'н', 49 },{'о', 50 },{'п', 51},{'р', 52 },{'с', 53 },{'т', 54 },{'у', 55 },{'ф', 56 },{'х', 57 },{'ц', 58 },
            {'ч', 59 },{'ш', 60 }, {'щ', 61 },{'ю', 62 },{'я', 63 },{'ь', 64 },{',',65},{'.',66},{'?',67},{'!',68},{':',69},{'\"',70},{' ', 71}
        };

        public string CipherString(string inputString, string keyWord)
        {
            char[] splittedKeyWord = keyWord.TrimEnd().TrimStart().ToCharArray();
            int[] keywordIndexLoop = GetIndexArr(keyWord);
            int curCharIndex, curKeyWordCharIndex, loopedIndex;
            int symbolsAmount = alphabet.Count();

            string cipheredString = string.Empty;
            for (int i = 0; i < inputString.Length; i++)
            {


                loopedIndex = keywordIndexLoop[i % keywordIndexLoop.Length];
                alphabet.TryGetValue(inputString[i], out curCharIndex);
                alphabet.TryGetValue(keyWord[loopedIndex], out curKeyWordCharIndex);
                int cipherCharIndex = (curCharIndex + curKeyWordCharIndex) % symbolsAmount;
                if (cipherCharIndex == 0)
                {
                    cipherCharIndex = symbolsAmount;
                }
                cipheredString += alphabet.FirstOrDefault(x => x.Value == cipherCharIndex).Key;
            }
            return cipheredString;

        }

        public string UncipherString(string inputString, string keyWord)
        {
            char[] splittedKeyWord = keyWord.ToCharArray();
            int[] keywordIndexLoop = GetIndexArr(keyWord);
            int curCharIndex, curKeyWordCharIndex, loopedIndex;
            int alphabetLength = alphabet.Count();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string cipheredString = string.Empty;
            for (int i = 0; i < inputString.Length; i++)
            {


                loopedIndex = keywordIndexLoop[i % keywordIndexLoop.Length];
                alphabet.TryGetValue(inputString[i], out curCharIndex);
                alphabet.TryGetValue(keyWord[loopedIndex], out curKeyWordCharIndex);
                int cipherCharIndex;
                if (curCharIndex > curKeyWordCharIndex)
                {
                    cipherCharIndex = curCharIndex - curKeyWordCharIndex;
                }
                else
                {
                    cipherCharIndex = alphabetLength - Math.Abs(curCharIndex - curKeyWordCharIndex);

                }


                cipheredString += alphabet.FirstOrDefault(x => x.Value == cipherCharIndex).Key;

                Console.WriteLine($"Char-\"{inputString[i]}\" curCharInde: {curCharIndex}, curKeyWordCharIndex: {curKeyWordCharIndex}, chiphered on {keyWord[loopedIndex]} = {alphabet.FirstOrDefault(x => x.Value == cipherCharIndex).Key} ");

            }
            Console.ReadLine();
            return cipheredString;
        }


        private int[] GetIndexArr(string str)
        {
            int[] indexArr = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                indexArr[i] = i;
            }
            return indexArr;
        }
    }
}
