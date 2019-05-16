using System.Linq;
using System;


namespace ChallengesWithTestsMarkVII
{
    class Program
    {
        static void Main(string[] args)
        {
            ChallengesSet05 challengesSet05 = new ChallengesSet05();

            string[] words = new string[5];
            words[0] = "This";
            words[1] = "is";
            words[2] = "";
            words[3] = " ";
            words[4] = "a";
           

            Console.WriteLine(challengesSet05.TurnWordsIntoSentence(words));
        }
    }
}
