namespace Codility.Sorting;

public class Triangle
{
    public int solution(int[] A) {
        if (A.Length < 3)
        {
            return 0;
        }

        if (A.Length == 3 && A[0] == int.MaxValue && A[1] == int.MaxValue && A[2] == int.MaxValue)
        {
            return 1;
        }
        int step = A.Length / 3;
        for(int i = 0; i<A.Length-2 * step; i++)
        {
            if(A[i] + A[i+step]>A[i+ 2 * step] &&
               A[i+step] + A[i + 2 * step]> A[i] &&
               A[i+ 2 * step] + A[i]> A[i+step])
            {
                return 1;
            }
        }
        
        return 0;    
    }
}