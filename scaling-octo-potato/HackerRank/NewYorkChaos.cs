using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank
{
    [TestClass]
    public class NewYorkChaos
    {
        [TestMethod]
        public void TestMethod1()
        {
                                //    1  2  3  4  5  6  7  8
            minimumBribes(new int[] { 1, 2, 5, 3, 7, 8, 6, 4 });
              // 3
        }

        [TestMethod]
        public void TestMethod2()
        {
            minimumBribes(new int[] { 2, 5, 1, 3, 4 });
             // Too chaotic
        }

        //void minimumBribes(vector<int> q)
        //{
        //    int ans = 0;
        //    for (int i = q.size() - 1; i >= 0; i--)
        //    {
        //        if (q[i] - (i + 1) > 2)
        //        {
        //            cout << "Too chaotic" << endl;
        //            return;
        //        }
        //        for (int j = max(0, q[i] - 2); j < i; j++)
        //            if (q[j] > q[i]) ans++;
        //    }
        //    cout << ans << endl;

        //}

        static void minimumBribes(int[] q)
        {
            //Print an integer denoting the minimum number of bribes needed to get the queue into its final state. Print Too chaotic if the state is invalid, i.e. it requires a person to have bribed more than  people.

            int minBribed = 0;
            bool tooChaotic = false;

            for (int i = 0; i < q.Length; i++)
            {
                int oneIndexed = i + 1;
                // In the same place, no bribes
                if (q[i] == oneIndexed)
                    continue;

                // Greater than index, *bribed*
                if (oneIndexed < q[i])
                {
                    int bribe =  q[i] - oneIndexed;

                    if (bribe > 2)
                    {
                        tooChaotic = true;
                        break;
                    }
                    continue;
                }

                // Briber
                int bribed = oneIndexed - q[i];

               

                minBribed = minBribed + bribed;
            }

            if (tooChaotic)
                Console.WriteLine("Too chaotic");
            else
                Console.Write(minBribed);

        }
    }
}
