using System;

namespace CountTheVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Word: ");
            string englishWord = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Number of vowels: {0}",CountVowels.CountVowelsInWord(englishWord));
        }
    }
}
