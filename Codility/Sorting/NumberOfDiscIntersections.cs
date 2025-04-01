using System;

namespace Codility.Sorting;

public class NumberOfDiscIntersections
{
    public int solution(int[] A) {
       
        int N = A.Length;
        long[] startPoints = new long[N];
        long[] endPoints = new long[N];

        for (int i = 0; i < N; i++)
        {
            startPoints[i] = (long)i - A[i];
            endPoints[i] = (long)i + A[i];
        }

        Array.Sort(startPoints);
        Array.Sort(endPoints);

        int intersections = 0;
        int activeCircles = 0;
        int endIndex = 0;

        for (int i = 0; i < N; i++)
        {
            while (endIndex < N && endPoints[endIndex] < startPoints[i])
            {
                activeCircles--;
                endIndex++;
            }

            intersections += activeCircles;
            if (intersections > 10_000_000) return -1;

            activeCircles++;
        }

        return intersections;
    }
    
}