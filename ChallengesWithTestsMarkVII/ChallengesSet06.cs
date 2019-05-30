using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {

            bool doesContain = false;
            if (words == null)
                return false;

            if (ignoreCase)
            {
                foreach (var wrd in words)
                {
                    if (wrd != null && wrd.ToLower() == word.ToLower())
                    {
                        doesContain = true;
                    }
                }
                return doesContain;
            }
            foreach (var wrd in words)
            {
                if (wrd != null && wrd == word)
                {
                    doesContain = true;
                }
            }
            return doesContain;
          
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str.Length == 1)
                return 0;

            for (int i = str.Length -1; i >= 0; i--)
            {
                if (str.IndexOf(str[i]) == str.LastIndexOf(str[i]))
                    return i;
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int consecutiveCounter = 1;
            int max = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    consecutiveCounter++;
                }
                else 
                {
                    consecutiveCounter = 1;
                }
                if (max < consecutiveCounter)
                {
                    max = consecutiveCounter;
                }
            }    
            return max;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0)
            {
                return new double[0];
            }

            List<double> everyNth = new List<double>();

            for (int i = (n - 1); i < elements.Count; i += n)
            {
                everyNth.Add(elements[i]);
            }

            return everyNth.ToArray(); ;
        }
    }
}
