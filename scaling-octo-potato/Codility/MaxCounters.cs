using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility
{
    [TestClass]
    public class MaxCounters

    {
        [TestMethod]
        public void OriginalTestCase()
        {
            int[] result = solution(5, new int[] { 3, 4, 4, 6, 1, 4, 4 });

            CollectionAssert.AreEqual(new int[] { 3, 2, 2, 4, 2 }, result);
        }

        public int[] solution(int N, int[] A)
        {
            int maxCounter = N + 1;
            int maxOp = 0;
            int lastUpdate = 0;
            int[] b = new int[N];
            
            for (int i = 0; i < A.Length; i++)
            {
                int current = A[i];
                if (current >= maxCounter)
                {
                    lastUpdate = maxOp;
                    continue;
                }

                int pos = current - 1;

                b[pos]++;

                if (b[current - 1] > maxOp)
                    maxOp = b[current - 1];
            }
            
            return b;
        }
    }
}
