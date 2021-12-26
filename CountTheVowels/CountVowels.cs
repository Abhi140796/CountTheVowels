using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheVowels
{
    class CountVowels
    {
        public static int CountVowelsInWord(string enterEnglishLetter)
        {
            string EnglishLetterLowerCase = enterEnglishLetter.ToLower();
            int lengthOfString = enterEnglishLetter.Length;
            int countVowels = 0;
            for(int i = 0; i < lengthOfString; i++)
            {
                if(EnglishLetterLowerCase[i] == 'a' || EnglishLetterLowerCase[i] == 'e' || EnglishLetterLowerCase[i] == 'i' || EnglishLetterLowerCase[i] == 'o' || EnglishLetterLowerCase[i] == 'u')
                {
                    countVowels++;
                }
            }
            return countVowels;
        }
    }
}
