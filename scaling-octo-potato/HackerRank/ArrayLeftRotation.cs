using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank
{
    [TestClass]
    public class ArrayLeftRotation
    {
        [TestMethod]
        public void Usecase1()
        {
            int[] value = rotLeft(4, new int[] { 1, 2, 3, 4, 5 });

            CollectionAssert.AreEqual(new int[] { 5, 1, 2, 3, 4 }, value);
        }

        static int[] rotLeft(int d, int[] a)
        {
            int[] b = new int[a.Length];
            int right = a.Length - d;

            for (int i = 0; i < a.Length; i++)
            {
                int newloc = (i + right) % (a.Length);
                b[newloc] = a[i];
            }
            
            return b;
        }
    }
}
