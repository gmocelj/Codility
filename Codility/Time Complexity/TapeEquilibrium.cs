using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility.Time_Complexity
{
    public class TapeEquilibrium
    {
        public int solution(int[] A)
        {
            List<int> results = new List<int>();
            for (int i = 0; i < A.Length - 2; i++)
            {
                results.Add(CalculateParts(i + 1, A));
            }

            return results.Min();
        }

        private int CalculateParts(int secondBegin, int[] A)
        {
            int firstResult = 0;
            int secondResult = 0;

            for (int i = 0; i < secondBegin; i++)
            {
                firstResult += A[i];
            }
            for (int y = secondBegin; y < A.Length; y++)
            {
                secondResult += A[y];
            }

            return Math.Abs(firstResult - secondResult);
        }
    }
}
