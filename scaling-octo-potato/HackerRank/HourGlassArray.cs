using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank
{
    [TestClass]
    public class HourGlassArray
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[][] arr = new int[6][];

            arr[0] = new int[] { 1, 1, 1, 0, 0, 0 };
            arr[1] = new int[] { 0, 1, 0, 0, 0, 0 };
            arr[2] = new int[] { 1, 1, 1, 0, 0, 0 };
            arr[3] = new int[] { 0, 0, 2, 4, 4, 0 };
            arr[4] = new int[] { 0, 0, 0, 2, 0, 0 };
            arr[5] = new int[] { 0, 0, 1, 2, 4, 0 };


            int result = hourglassSum(arr);

            Assert.AreEqual(19, result);
        }

        [TestMethod]
        public void UseCaseTwo()
        {
            int[][] arr = new int[6][];

            arr[0] = new int[] { -1, -1,  0, -9, -2, -2 };
            arr[1] = new int[] { -2, -1, -6, -8, -2, -5 };
            arr[2] = new int[] { -1, -1, -1, -2, -3, -4 };
            arr[3] = new int[] { -1, -9, -2, -4, -4, -5 };
            arr[4] = new int[] { -7, -3, -3, -2, -9, -9 };
            arr[5] = new int[] { -1, -3, -1, -2, -4, -5 };


            int result = hourglassSum(arr);

            Assert.AreEqual(-6, result);
        }
        
        static int hourglassSum(int[][] arr)
        {
            int? maxSum = null;

            if (arr.Length < 3)
                return 0;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 1; j < arr[i].Length - 1; j++)
                {
                    int sum = arr[i][j - 1] + arr[i][j] + arr[i][j + 1];
                    sum = sum + arr[i + 1][j];
                    sum = sum + arr[i + 2][j - 1] + arr[i + 2][j] + arr[i + 2][j + 1];

                    if (!maxSum.HasValue)
                    {
                        maxSum = sum;
                        continue;
                    }

                    if (sum > maxSum)
                        maxSum = sum;
                }
            }
            
            return maxSum.Value;
        }
    }
}
