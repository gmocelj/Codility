using System;

namespace Codility
{
    public class MaxProductOfThree
    {
        public int solution(int[] A)
        {
            if (A.Length < 3)
            {
                return 0;
            }
            
            Array.Sort(A);

     
            int n = A.Length;
            int maxProduct = Math.Max(
                A[n - 1] * A[n - 2] * A[n - 3],
                A[0] * A[1] * A[n - 1]
            );

            return maxProduct;
        }
    }
}