namespace Codility.Arrays
{
    class CyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            if (A.Length == 0)
            {
                return A;
            }

            // write your code in C# 6.0 with .NET 4.5 (Mono)
            for (int numberOfTimes = 0; numberOfTimes < K; numberOfTimes++)
            {
                int firstPossition = A[A.Length - 1];
                for (int i = A.Length - 1; i > 0; i--)
                {
                    A[i] = A[i - 1];
                }
                A[0] = firstPossition;
            }

            return A;
        }
    }
}
