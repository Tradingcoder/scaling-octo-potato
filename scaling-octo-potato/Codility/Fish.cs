using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// https://app.codility.com/programmers/lessons/7-stacks_and_queues/fish/start/
namespace Codility
{
    [TestClass]
    public class Fish
    {
        [TestMethod]
        public void OriginalTestCase()
        {

            int result = solution(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 1, 0, 0, 0 });

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void OriginalTestCaseAllEaten()
        {

            int result = solution(new int[] { 5, 3, 2, 1, 4 }, new int[] { 1, 0, 0, 0, 0 });

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void OriginalTestCaseOnlyOne()
        {

            int result = solution(new int[] { 1 }, new int[] { 1 });

            Assert.AreEqual(1, result);
        }

        public int solution(int[] A, int[] B)
        {
            int alive = 0;
            Stack<int> fishEaters = new Stack<int>();

            if (B.Length == 1)
                return 1;

            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == 0)
                {
                    while (fishEaters.Count > 0)
                    {
                        if (fishEaters.Peek() > A[i])
                            break;
                        else
                            fishEaters.Pop();
                    }

                    if (fishEaters.Count == 0)
                        alive++;
                }
                else if (B[i] == 1)
                    fishEaters.Push(A[i]);
            }
            
            return alive + fishEaters.Count;
        }
    }
}