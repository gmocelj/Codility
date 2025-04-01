using System.Collections.Generic;

namespace Codility.Stacks_and_Queues;

public class Brackets
{
    public int solution(string S) {
        var stack = new Stack<char>();
        foreach (var c in S)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return 0;
                }

                var top = stack.Pop();
                if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '['))
                {
                    return 0;
                }
            }
        }
        return stack.Count == 0 ? 1 : 0;
    }
}