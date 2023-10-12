// A Verifier Class to check for PrimeNumbers and Palindromes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestProject1
{
    public class Verifier
    {
        
        public bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public bool IsPalindrome(string word)
        {
            if (word.Length <= 1)
                return true;

            if (word[0] != word[word.Length - 1])
                return false;

            return IsPalindrome(word.Substring(1, word.Length - 2));
        }
    }
}