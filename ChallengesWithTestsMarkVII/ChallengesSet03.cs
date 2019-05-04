using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool value in vals)
            {
                if (value == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            int oddSum = 0;

            foreach (int num in numbers)
            {
                if (num % 2 != 0)
                {
                   oddSum += num;
                }
            }
            return oddSum % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            // I know this could be done in one line with linq, but I'm trying not to rely on it
            bool isDigit = false;
            bool isUpper = false;
            bool isLower = false;

            for (int i = 0; i < password.Length; i++)
            {

                if (char.IsDigit(password[i]))
                {
                    isDigit = true;
                }
                if (char.IsLower(password[i]))
                {
                    isLower = true;
                }               
                if (char.IsUpper(password[i]))
                {
                    isUpper = true;
                }
            }
            if (isDigit && isUpper && isLower)
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = Enumerable.Range(0, 100).Where(x => x % 2 == 1).ToArray();
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            return;
        }
    }
}
