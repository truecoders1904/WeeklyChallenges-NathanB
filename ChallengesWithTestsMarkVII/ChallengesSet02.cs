using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
=======
>>>>>>> dcd7e7a236666c2adb986c86fac531575dc06e53

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
<<<<<<< HEAD
            if (Char.IsLetter(c) == true)
            {
                return true;
            }
            return false;
=======
            throw new NotImplementedException();
>>>>>>> dcd7e7a236666c2adb986c86fac531575dc06e53
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
<<<<<<< HEAD
            int countOfElements = vals.Length;
            return countOfElements % 2 == 0;
=======
            throw new NotImplementedException();
>>>>>>> dcd7e7a236666c2adb986c86fac531575dc06e53
        }

        public bool IsNumberEven(int number)
        {
<<<<<<< HEAD
           return number % 2 == 0;
=======
            throw new NotImplementedException();
>>>>>>> dcd7e7a236666c2adb986c86fac531575dc06e53
        }

        public bool IsNumberOdd(int num)
        {
<<<<<<< HEAD
            return num % 2 != 0;
=======
            throw new NotImplementedException();
>>>>>>> dcd7e7a236666c2adb986c86fac531575dc06e53
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
<<<<<<< HEAD
           if (numbers == null)
            {
                return 0;
            }
           return numbers.Max() + numbers.Min();
=======
            throw new NotImplementedException();
>>>>>>> dcd7e7a236666c2adb986c86fac531575dc06e53
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
<<<<<<< HEAD
            return Math.Min(str1.Length, str2.Length);
=======
            throw new NotImplementedException();
>>>>>>> dcd7e7a236666c2adb986c86fac531575dc06e53
        }

        public int Sum(int[] numbers)
        {
<<<<<<< HEAD

            if (numbers == null)
            {
                return 0;
            }
            return numbers.Sum();
=======
            throw new NotImplementedException();
>>>>>>> dcd7e7a236666c2adb986c86fac531575dc06e53
        }

        public int SumEvens(int[] numbers)
        {
<<<<<<< HEAD
            if (numbers == null)
            {
                return 0;
            }

            int sumOfEvens = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumOfEvens = sumOfEvens + numbers[i];
                }
            }
            return sumOfEvens;
            
=======
            throw new NotImplementedException();
>>>>>>> dcd7e7a236666c2adb986c86fac531575dc06e53
        }

        public bool IsSumOdd(List<int> numbers)
        {
<<<<<<< HEAD
            if (numbers == null)
            {
                return false;
            }

            int total = numbers.Sum();
            return total % 2 != 0;
=======
            throw new NotImplementedException();
>>>>>>> dcd7e7a236666c2adb986c86fac531575dc06e53
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
<<<<<<< HEAD
            if (number < 0)
            {
                return 0;
            }
            return number / 2; 
=======
            throw new NotImplementedException();
>>>>>>> dcd7e7a236666c2adb986c86fac531575dc06e53
        }
    }
}
