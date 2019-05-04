using System.Linq;
using System;


namespace ChallengesWithTestsMarkVII
{
    class Program
    {
        static void Main(string[] args)
        {
            ChallengesSet03 challengesSet03 = new ChallengesSet03();

            int[] odds = Enumerable.Range(0, 50).Where(x => x % 2 == 1).ToArray();
            foreach (var odd in odds)
            {
                Console.WriteLine(odd);

            }
        }
    }
}
