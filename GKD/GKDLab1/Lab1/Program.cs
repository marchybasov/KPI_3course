using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

class Caeaser
{
    char[] cyrAlphabet = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
    private char[] CipherCyrAplhabet()
    {
        int arrLength = cyrAlphabet.Length;
        char[] cipheredAlphabet = new char[arrLength];
        int[] shiftValues = { 1, 2, 3 };
        for (int i = 0; i < arrLength; i++)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int shift = shiftValues[i % shiftValues.Length];
            if ((i + shift) < arrLength)
            {
                cipheredAlphabet[i] = cyrAlphabet[i + shift];

            }
            else
            {

                cipheredAlphabet[i] = cyrAlphabet[i + shift - arrLength];
            }
            //Console.WriteLine($"element {i}: {cyrAlphabet[i]} = {cipheredAlphabet[i]} (shift = {shift})");
            //Console.ReadKey();
        }

        return cipheredAlphabet;
    }
    public string UncipherInput(string input)
    {
        char[] cipheredAlphabet = CipherCyrAplhabet();
        char[] splittedInput = input.ToUpper().ToCharArray();

        string output = string.Empty;
        for (int i = 0; i < splittedInput.Length; i++)
        {
            char letter = cyrAlphabet[Array.IndexOf(cipheredAlphabet, splittedInput[i])];
            output += letter;
        }
        return output;

    }

    public string CipherMessage(string message)
    {
        char[] cipheredAlphabet = CipherCyrAplhabet();
        char[] splittedInput = message.ToUpper().ToCharArray();

        string output = string.Empty;
        for (int i = 0; i < splittedInput.Length; i++)
        {
            char letter = cipheredAlphabet[Array.IndexOf(cyrAlphabet, splittedInput[i])];
            output += letter;
        }
        return Char.ToUpper(output[0]) + output.Substring(1).ToLower();

    }

}

class Cipher
{
    private Dictionary<char, int> alphabet = new Dictionary<char, int>() {
            {'А', 1 }, { 'Б', 2 }, {'В', 3 }, {'Г', 4 }, {'Д',  5 }, { 'Е', 6 }, { 'Є',  7 }, {'Ж',  8 }, {'З',   9 },
            {'И', 10 }, {'І', 11 },{'Ї',  12 }, {'Й', 13 },{'К', 14 },{'Л', 15 },{'М', 16 }, {'Н', 17 },{'О', 18 },{'П', 19 },
            {'Р', 20 },{'С', 21 },{'Т', 22 },{'У', 23 },{'Ф', 24 },{'Х', 25},{'Ц', 26 },{'Ч', 27 },{'Ш', 28 },{'Щ', 29 },{'Ю', 30 },{'Я', 31 },{'Ь',  32 },
            {'а', 33 },{'б', 34 },{'в', 35 },{'г', 36 },{'д', 37 },{'е', 38},{'є', 39 },{'ж', 40 },{'з', 41 },{'и', 42 },{'і',  43 },{'ї',44 },{'й', 45 },
            {'к', 46 },{'л', 47 },{'м', 48 },{'н', 49 },{'о', 50 },{'п', 51},{'р', 52 },{'с', 53 },{'т', 54 },{'у', 55 },{'ф', 56 },{'х', 57 },{'ц', 58 },
            {'ч', 59 },{'ш', 60 }, {'щ', 61 },{'ю', 62 },{'я', 63 },{'ь', 64 }
        };

    public string CipherString(string inputString, string keyWord)
    {
        char[] splittedKeyWord = keyWord.ToCharArray();
        int[] keywordIndexLoop = GetIndexArr(keyWord);
        int curCharIndex, curKeyWordCharIndex, loopedIndex;

        Console.OutputEncoding = Encoding.UTF8;

        string cipheredString = string.Empty;
        for (int i = 0; i < inputString.Length; i++)
        {

            loopedIndex = keywordIndexLoop[i % keywordIndexLoop.Length];
            alphabet.TryGetValue(inputString[i], out curCharIndex);
            alphabet.TryGetValue(keyWord[loopedIndex], out curKeyWordCharIndex);
            int cipherCharIndex = (curCharIndex + curKeyWordCharIndex) % 64;
            if (cipherCharIndex == 0)
            {
                cipherCharIndex = 64;
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

        Console.OutputEncoding = Encoding.UTF8;

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
                cipherCharIndex = 64 - Math.Abs(curCharIndex - curKeyWordCharIndex);

            }
            
            cipheredString += alphabet.FirstOrDefault(x => x.Value == cipherCharIndex).Key;
        }
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
class Program
{



    static void Main()
    {
        Cipher cipher = new Cipher();
        Console.OutputEncoding = Encoding.UTF8;
        string str = PreformatInput("ЯкпаростьвиноградноїлозиПлекайтемовуПильнойненастанноПолітьбурянЧистішавідсльозиВонахайбудеВірноіслухняноНехайвонащоразуслужитьвамХочіживесвоїмживимжиттямПрислухайтесьякокеанспіваєНародговоритьІлюбовігнівУтомугомоніморськімНемаєМудрішихніжнародучителівУньогокожнеслово–цеперлинаЦепрацяценатхненняцелюдинаНебійтесьзаглядатиусловникЦепишнийяранесумнепровалляЗбирайтеякрозумнийсадівникДостиглийовочуГрінченкайДаляНемайтегнівудомоїхпорадІнелінуйтесьдоглядатьсвійсадСьогодні світ удвадцяте відзначає Міжнародний день рідної мови, проголошений на ХХХ сесії Генеральної конференції ЮНЕСКО. Не випадково, що гаслом цього дня ініціатори свята обрали вислів: «Мова – це важливо!» І якщо мова – душа народу, то природно, коли для більшості наших співгромадян вона – українська. З нагоди свята пропонуємо згадати заповіт, який залишив нам Максим Рильський, поезія та переклади якого неабияк сприяли розвитку української літературної мови.");
        string cipheredStr = cipher.CipherString(str, "МаксимРильський");
        Console.WriteLine(cipheredStr);
        Console.WriteLine(cipher.UncipherString(cipheredStr, "МаксимРильський"));
        Console.ReadKey();
        //Caeaser chifer = new Caeaser();
        //Console.WriteLine(chifer.UncipherInput("Йрнбстцмвщйврбтмзёпебрйзспмйопухйко"));
        //string cipheredMessage = chifer.CipherMessage("Инкапсуляциянаследованиеполиморфизм");
        //Console.WriteLine(cipheredMessage);
        //Console.ReadLine();
        //Caeaser.CipherCyrAplhabet();

    }

    static string PreformatInput(string input)
    {
        return Regex.Replace(input, @"[!@#$%^&*(),'.;?:{ }'|<>]", "");


    }
}
