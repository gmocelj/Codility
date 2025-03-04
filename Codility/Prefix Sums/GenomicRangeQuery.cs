
namespace Codility;

public class GenomicRangeQuery
{
        public int[] solution(string S, int[] P, int[] Q)
        {
                int N = S.Length;
                int M = P.Length;
                int[] result = new int[M];
                
                int[] prefixA = new int[N];
                int[] prefixC = new int[N];
                int[] prefixG = new int[N];
                
                if (S[0] == 'A') prefixA[0] = 1;
                if (S[0] == 'C') prefixC[0] = 1;
                if (S[0] == 'G') prefixG[0] = 1;
                
                for (int i = 1; i < N; i++)
                {
                        prefixA[i] = prefixA[i - 1];
                        prefixC[i] = prefixC[i - 1];
                        prefixG[i] = prefixG[i - 1];

                        if (S[i] == 'A') prefixA[i]++;
                        else if (S[i] == 'C') prefixC[i]++;
                        else if (S[i] == 'G') prefixG[i]++;
                }
                
                for (int k = 0; k < M; k++)
                {
                        int start = P[k];
                        int end = Q[k];
                        
                        if (prefixA[end] - (start > 0 ? prefixA[start - 1] : 0) > 0)
                                result[k] = 1; 
                        else if (prefixC[end] - (start > 0 ? prefixC[start - 1] : 0) > 0)
                                result[k] = 2;
                        else if (prefixG[end] - (start > 0 ? prefixG[start - 1] : 0) > 0)
                                result[k] = 3;
                        else
                                result[k] = 4;
                }

                return result;
        }
}
