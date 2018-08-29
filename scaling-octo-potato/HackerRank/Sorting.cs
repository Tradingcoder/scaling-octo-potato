using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank
{
    [TestClass]
    public class Sorting
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        
        // Complete the maximumToys function below.
        static int maximumToys(int[] prices, int k)
        {


        }

        static void countSwaps(int[] a)
        {
            int count = 0;
            int n = a.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        count++;
                    }
                }
            }

            var b = a.ToList();

            Console.WriteLine($"Array is sorted in {count} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[a.Length - 1]}");
        }
    }
}
