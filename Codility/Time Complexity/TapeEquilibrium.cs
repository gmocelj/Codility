using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility.Time_Complexity
{
    public class TapeEquilibrium
    {
        public int solution(int[] A)
        {
            var results = new List<int>();
            int firstSum = 0;
            int secondSum = 0;
            Array.ForEach(A.Take(1).ToArray(), x => { firstSum += x; });
            Array.ForEach(A.Skip(1).ToArray(), x => { secondSum += x; });
            results.Add(Math.Abs(firstSum - secondSum));

            for (int i = 1; i < A.Length - 1; i++)
            {
                firstSum += A[i];
                secondSum -= A[i];

                results.Add(Math.Abs(firstSum - secondSum));
            }

            return results.Min();
        }
    }
}
