using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank
{
    [TestClass]
    public class AlternatingCharacters
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = alternatingCharacters("ABBABBAA");
        }




        static int alternatingCharacters(string s)
        {
            int charsRemoved = 0;
            char current = s[0];
            for (int i = 1; i < s.Length; i++)
            {
                if (current == s[i])
                    charsRemoved++;
                else
                    current = s[i]; 
            }
            
            return charsRemoved;
        }
    }
}
