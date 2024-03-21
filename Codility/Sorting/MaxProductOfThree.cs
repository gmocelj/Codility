using System;
using System.Linq;

namespace Codility
{
    public class MaxProductOfThree
    {
        public int solution(int[] A) => getMaxValue(A) * getMaxValue(A) * getMaxValue(A);

        private int getMaxValue(int[] A)
        {
            var max = A.Max(b=> b);
            var maxIndex = Array.IndexOf(A, max);
            A[maxIndex] = Int32.MinValue;
            return max == 0 ? getMaxValue(A) : max;
        }
    }
}