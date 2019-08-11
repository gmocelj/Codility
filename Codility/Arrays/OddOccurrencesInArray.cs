using System.Collections.Generic;
using System.Linq;

namespace Codility.Arrays
{
    class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach (int number in A)
            {
                if (!keyValuePairs.ContainsKey(number))
                {
                    keyValuePairs.Add(number, 1);
                }
                else
                {
                    keyValuePairs[number] = keyValuePairs[number] + 1;
                }
            }

            return keyValuePairs.Where(x => x.Value % 2 != 0).Select(x => x.Key).FirstOrDefault();
        }
    }
}

