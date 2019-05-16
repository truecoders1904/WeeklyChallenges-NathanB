using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            throw new NotImplementedException();
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            throw new NotImplementedException();
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers.Length == 1)
                {
                    return true;
                }

                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                } 
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string result = ""; 

            for (int i = 0; i < words.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(words[i]))
                {

                }
                else
                {
                    result = String.Join(" ", words);
                }
            }
            return result + ".";

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            {
                double[] empty = new double[0];
                return empty;
            }

            List<double> everyFourth = new List<double>();

            for (int i = 3; i < elements.Count; i+= 4)
            {
                everyFourth.Add(elements[i]);
            }

            return everyFourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
