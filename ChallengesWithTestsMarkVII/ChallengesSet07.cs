using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet07
    {
        public int CountOfBusinessesWithNegativeNetProfit(List<Business> businesses)
        {
            if (businesses == null)
                return 0;
            int counter = 0;
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue < business.TotalExpenses)
                    counter++;
            }
            return counter;
        }

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {
            string profBiz = "";

            for (int i = businesses.Count-1; i >= 0; i--)
            {
                if (businesses[i].TotalRevenue < businesses[i].TotalExpenses)
                {
                    businesses.Remove(businesses[i]);
                }
            }

            if (businesses.Count == 0)
                return "";

            for (int i = 0; i < businesses.Count -1; i++)
            {
                profBiz = profBiz +businesses[i].Name + ",";
            }

            if (businesses[businesses.Count-1].TotalRevenue > businesses[businesses.Count-1].TotalExpenses)
            {
                profBiz = profBiz + businesses[businesses.Count-1].Name;
            }

            return profBiz;

        }

        public string GetNameOfHighestParentCompany(Business business)
        {
            if (business.ParentCompany == null)
            {
                return business.Name;
            }

            return GetNameOfHighestParentCompany(business.ParentCompany);
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            if (CheckForChar('X', finalBoard))
                return TicTacToeResult.X;
            if (CheckForChar('O', finalBoard))
                return TicTacToeResult.O;

            return TicTacToeResult.Draw;
        }
        private bool CheckForChar(char c, char [,] finalBoard)
        {
            if (finalBoard[0, 0] == finalBoard[0, 1] && finalBoard[0, 1] == finalBoard[0, 2] && finalBoard[0, 0] == c ||
                finalBoard[0, 0] == finalBoard[1, 1] && finalBoard[1, 1] == finalBoard[2, 2] && finalBoard[0, 0] == c ||
                finalBoard[0, 0] == finalBoard[1, 0] && finalBoard[1, 0] == finalBoard[2, 0] && finalBoard[0, 0] == c ||
                finalBoard[1, 0] == finalBoard[1, 1] && finalBoard[1, 1] == finalBoard[1, 2] && finalBoard[1, 0] == c ||
                finalBoard[2, 0] == finalBoard[2, 1] && finalBoard[2, 1] == finalBoard[2, 2] && finalBoard[2, 0] == c ||
                finalBoard[0, 1] == finalBoard[1, 1] && finalBoard[1, 1] == finalBoard[2, 1] && finalBoard[0, 1] == c ||
                finalBoard[0, 2] == finalBoard[1, 1] && finalBoard[1, 1] == finalBoard[2, 0] && finalBoard[0, 2] == c ||
                finalBoard[0, 2] == finalBoard[1, 2] && finalBoard[1, 2] == finalBoard[2, 2] && finalBoard[0, 2] == c)
                    return true;
            return false;
        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            bool containsTargetNumber = false;
            foreach (int[] array in numbers)
            {
                containsTargetNumber = false;
                foreach (int num in array)
                {
                    if (num == targetNumber)
                    {
                        containsTargetNumber = true;
                    }
                }
                if (containsTargetNumber == false)
                {
                    return false;
                }
            }
            return containsTargetNumber;
        }
    }
}
