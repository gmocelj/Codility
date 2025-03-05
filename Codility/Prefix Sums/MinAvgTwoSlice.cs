using System;

namespace Codility;

public class MinAvgTwoSlice
{
    public int solution(int[] A) {
        int N = A.Length;
        int minIndex = 0;
        double minAvg = double.MaxValue;
        
        double[] prefixSum = new double[N + 1];
        for (int i = 0; i < N; i++) {
            prefixSum[i + 1] = prefixSum[i] + A[i];
        }
        
        for (int sliceSize = 2; sliceSize <= Math.Min(N, 5); sliceSize++) { // Limiting slice size for performance
            for (int i = 0; i <= N - sliceSize; i++) {
                double avg = (prefixSum[i + sliceSize] - prefixSum[i]) / sliceSize;
                if (avg < minAvg) {
                    minAvg = avg;
                    minIndex = i;
                }
            }
        }
        
        return minIndex;
    }
}