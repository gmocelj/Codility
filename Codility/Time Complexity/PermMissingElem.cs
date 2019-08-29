using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Time_Complexity
{
    public class PermMissingElem
    {
        public int solution(int[] A)
        {
            if (A.Length == 0)
                return 1;

            if (A.Length == 1)
            {
                if (A[0] > 1)
                    return 1;
                else
                    return A[0] + 1;
            }

            Array.Sort(A);
            if (A[A.Length - 1] == A.Length)
            {
                return A.Length + 1;
            }

            for (int index = 0; index < A.Length - 1; index++)
            {
                if (A[index] + 1 != A[index + 1])
                {
                    return A[index] + 1;
                }
            }

            return 1;
        }
    }
}
