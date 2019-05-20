using System.Linq;
using System;


namespace ChallengesWithTestsMarkVII
{
    class Program
    {
        static void Main(string[] args)
        {
            ChallengesSet05 challengesSet05 = new ChallengesSet05();

            //var test = new[] { 5, -2, 4, 6, 8 };


            //Console.WriteLine(challengesSet05.TwoDifferentElementsInArrayCanSumToTargetNumber(test, 8));

            string[] test2 = new string[] {"this", "  ", "is", "a", "test", "."};

            string print = challengesSet05.TurnWordsIntoSentence(test2);

            Console.WriteLine(print);
        }
    }
}
