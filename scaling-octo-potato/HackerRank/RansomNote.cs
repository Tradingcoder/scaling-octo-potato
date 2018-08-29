using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace HackerRank
{
    [TestClass]
    public class Ransomnote
    {
        [TestMethod]
        public void TestMethod1()
        {
            CheckMagazine(new string[] { "give", "me", "one", "grand", "today", "night" }, new string[] { "give", "one", "grand", "today" });
        }

        static void CheckMagazine(string[] magazine, string[] note)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
           
            for (int i = 0; i < magazine.Length; i++)
            {
                if (wordCount.ContainsKey(magazine[i]))
                    wordCount[magazine[i]]++;
                else
                    wordCount.Add(magazine[i], 1);

            }
            for (int i = 0; i < note.Length; i++)
            {
                if (!wordCount.ContainsKey(note[i]))
                {
                    Console.WriteLine("No");
                    return;
                }
                else {

                    if (wordCount[note[i]] > 0)
                        wordCount[note[i]]--;
                    else
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }
            }

            Console.WriteLine("Yes");

        }
    }
}
