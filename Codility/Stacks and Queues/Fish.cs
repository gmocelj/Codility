using System.Collections.Generic;

namespace Codility.Stacks_and_Queues;

public class Fish
{
    public int solution(int[] A, int[] B) {
        Stack<int> downstream = new Stack<int>();
        int aliveCount = 0;
        
        for (int i = 0; i < A.Length; i++)
        {
            if (B[i] == 1)
            {
                downstream.Push(A[i]);
            }
            else
            {
                while (downstream.Count > 0)
                {
                    if (downstream.Peek() > A[i])
                    {
                        break;
                    }
                    else
                    {
                        downstream.Pop();
                    }
                }
                if (downstream.Count == 0)
                {
                    aliveCount++;
                }
            }
        }
        
        return aliveCount + downstream.Count;
    }
}