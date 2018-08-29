using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank
{
    [TestClass]
    public class ArrayManipulation
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[][] ar = new int[3][];

            ar[0] = new int[] { 1, 2, 100 };
            ar[1] = new int[] { 2, 5, 100 };
            ar[2] = new int[] { 3, 4, 100 };


            long result = arrayManipulation(5, ar);
        }


        static long arrayManipulation(int n, int[][] queries)
        {
            //long[] b = new long[n];

            //for (int i = 0; i < queries.Length; i++)
            //{
            //    for (int j = queries[i][0] - 1; j < queries[i][1]; j++)
            //        b[j] = b[j] + queries[i][2];
            //}

            //long max = 0;
            //for (int i = 0; i < b.Length; i++)
            //{
            //    if (b[i] > max)
            //        max = b[i];

            //}

            //return max;


            //ar[0] = new int[] { 1, 2, 100 };
            //ar[1] = new int[] { 2, 5, 100 };
            //ar[2] = new int[] { 3, 4, 100 };
              
            long[] numList = new long[n + 1];

            for (int i = 0; i < queries.Length; i++)
            {
                uint a = UInt32.Parse(queries[i][0].ToString());
                uint b = UInt32.Parse(queries[i][1].ToString());
                long k = long.Parse(queries[i][2].ToString());

                numList[a] = numList[a] + k;


                if (b + 1 <= n)
                {
                    numList[b + 1] = numList[b + 1] - k;
                }
            }

            long tempMax = 0;
            long max = 0;
            for (int i = 1; i <= n; i++)
            {
                tempMax += numList[i];
                if (tempMax > max) max = tempMax;
            }

            return max; 

        }

    }
}
