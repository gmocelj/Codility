using System.Collections.Generic;
using System.Linq;

namespace Codility
{
    class FrogRiverJmp
    {
        public int solution(int X, int[] A)
        {

            var expectedElements = new HashSet<int>();
            for (int i = 1; i <= X; i++)
            {
                expectedElements.Add(i);
            }

            for (int index = 0; index < A.Count(); index++)
            {
                if (A[index] <= X)
                {
                    expectedElements.Remove(A[index]);
                }

                if (!expectedElements.Any())
                {
                    return index;
                }
            }

            return -1;
        }
    }
}