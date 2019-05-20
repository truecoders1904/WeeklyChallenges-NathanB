using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            for (int i = startNumber; i < 10000000; i++)
            {
                if (i % n == 0 && i > startNumber)
                {
                    return i;
                }
            }
            return 0;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            Business business = new Business();

            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0d)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
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
            if (numbers == null)
                return 0;

            int SumOfElementsAfterAnEven = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    SumOfElementsAfterAnEven +=  numbers[i + 1];
                }
            }
            return SumOfElementsAfterAnEven;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            List<string> makeSentence = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(words[i]) == false)
                {
                    words[i] = words[i].Trim();
                    makeSentence.Add(words[i]);
                }
            }

            string result = "";

            for (int i = 0; i < makeSentence.Count - 1; i++)
            {
                result = result + makeSentence[i] + " ";
            }

            if (makeSentence.Count <= 1)
                return "";

            return result + makeSentence[makeSentence.Count - 1] + ".";
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
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = 1; k < nums.Length; k++)
                {
                    if(nums[i] + nums[k] == targetNumber && i != k)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
