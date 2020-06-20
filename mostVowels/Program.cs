using System;

namespace mostVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = " hello world this is Leonardo";
            string v = MostVowels(myString);
            Console.WriteLine(v);
        }
        static string MostVowels(string text)
        {
            string maxWord = "";
            int maxVoels = 0;
            string Vowels = "aeiouAEIUOU";
            string[] wordsArr = text.Split(" ");
            foreach (string word in wordsArr)
            {
                //Console.WriteLine(word);
                int counter = 0;
                foreach (char letter in word)
                {
                    //Console.WriteLine(letter);
                    if (Vowels.IndexOf(letter) > -1)
                    {
                        counter += 1;
                        if (counter > maxVoels)
                        {
                            maxVoels = counter;
                            maxWord = word;

                        }
                    }
                }

            }
            return ($"{maxWord} has {maxVoels} Vowles");
        }
    }
}
