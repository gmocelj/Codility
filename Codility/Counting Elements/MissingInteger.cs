namespace Codility
{
    using System.Linq;
    
    class MissingInteger {
        public int solution(int[] A) {
            var AList = A.Distinct().Where(el=> el > 0).OrderBy(el=> el).ToList();
            switch (AList.Count)
            {
                case 0:
                    return 1;
                case 1:
                    return AList.ElementAt(0) == 1 ? 2 : 1;
            }

            if (!AList.Contains(1))
            {
                return 1;
            }
            
            var allNumbers = Enumerable.Range(1, AList.Count() + 1).ToList();
            for (var i = 0; i < AList.Count() - 1; i++)
            {
                if (AList.ElementAt(i) + 1 == AList.ElementAt(i + 1))
                {
                    continue;
                }
                
                return AList.ElementAt(i) == 0 ? 1 : allNumbers[i + 1];
            }
            
            return allNumbers.Last();
        }
    }
}