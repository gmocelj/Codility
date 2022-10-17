using System.Linq;

namespace Codility.Sorting
{
    public class Distinct
    {
        public int solution(int[] A) {
       
            var distinct = A.Distinct();

            return distinct.Count();
        }
    }
}