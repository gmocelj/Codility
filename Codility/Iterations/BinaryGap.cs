using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility
{
    class BinaryGap
    {
        public int Solution(int N)
        {
            string binary = Convert.ToString(N, 2);

            List<int> result = new List<int>();

            int counter = 0;
            foreach (char c in binary)
            {
                if (c == '1')
                {
                    if (counter != 0)
                        result.Add(counter);
                    counter = 0;
                }
                else
                {
                    counter++;
                }
            }

            if (result.Count == 0)
            {
                return 0;
            }

            return result.Max();
        }
    }
}
