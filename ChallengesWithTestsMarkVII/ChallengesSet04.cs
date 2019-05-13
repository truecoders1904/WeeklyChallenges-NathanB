using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            // w/o LINQ
            int total = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    total += num;
                }
                else
                {
                    total -= num;
                }
            }
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] strings = {str1, str2, str3, str4};

            int shortestString = strings[0].Length;
            for (int i = 0; i < 4; i++)
            {
                if (strings[i].Length <= shortestString)
                {
                    shortestString = strings[i].Length;
                }
            }
            return shortestString;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> numsList = new List<int>
            {
                number1,
                number2,
                number3,
                number4
            };

            int smallestNumber = numsList[0];
            for (int i = 0; i < numsList.Count; i++)
            {
                if(numsList[i] <= smallestNumber)
                {
                    smallestNumber = numsList[i];
                }
            }
            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 < sideLength2 + sideLength3
                && sideLength2 < sideLength1 + sideLength3
                && sideLength3 < sideLength2 + sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double i);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            List<object> objects = objs.ToList();

            int nullCounter = 0;
            foreach (var obj in objects)
            {
                if(obj == null)
                {
                    nullCounter += 1;
                }
            }
            return nullCounter > (objects.Count - nullCounter);  
        }

        public double AverageEvens(int[] numbers)
        {
            double sumOfEvens = 0;
            double evenCount = 0;

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sumOfEvens += num;
                    evenCount += 1;
                }
            }
            if (evenCount >= 1)
            {
                return sumOfEvens / evenCount;
            }
            return evenCount;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int factorial = 1;

            for (int i = 1; i < number +1; i++)
            {
                factorial = i * factorial;
            }
            return factorial;
        }
    }
}
