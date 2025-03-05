namespace Codility.Sorting;

public class Triangle
{
    public int solution(int[] A) {
        if (A.Length < 3)
        {
            return 0;
        }

        int step = A.Length / 3;
        for(int i = 0; i<A.Length-2 * step; i++)
        {
            if((long)A[i] + A[i+step]>A[i+ 2 * step] &&
               (long)A[i+step] + A[i + 2 * step]> A[i] &&
               (long)A[i+ 2 * step] + A[i]> A[i+step])
            {
                return 1;
            }
        }
        
        return 0;   
    }
}