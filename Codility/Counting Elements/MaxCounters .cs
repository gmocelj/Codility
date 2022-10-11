namespace Codility
{
    class Solution
    {
        public int[] solution(int N, int[] A)
        {
            var previousMaxCount = 0;
            var maxCounter = 0;
            var outputElements = new int[N];
            foreach (var element in A)
            {
                if (1 <= element && element <= N)
                {
                    if (outputElements[element - 1] < previousMaxCount)
                    {
                        outputElements[element - 1] = previousMaxCount + 1;
                    }
                    else
                    {
                        outputElements[element - 1] += 1;
                    }

                    if (maxCounter < outputElements[element - 1])
                    {
                        maxCounter = outputElements[element - 1];
                    }
                }
                else
                {
                    previousMaxCount = maxCounter;
                }
            }

            for (var i = 0; i < N; i++)
            {
                if (outputElements[i] < previousMaxCount)
                {
                    outputElements[i] = previousMaxCount;
                }
            }

            return outputElements;
        }
    }
}