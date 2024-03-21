namespace Codility
{
    public class PassingCars
    {
        public int solution(int[] A) {
            var result = 0;
            var multiplayer = 0;
            var startCount = false;
            foreach (var car in A)
            {
                if(car == 0)
                {
                    startCount = true;
                    multiplayer++;
                }

                if(startCount && car == 1)
                {
                    result += 1 * multiplayer;
                }
            }
            
            if(result > 1000000000)
            {
                return -1;
            }

            return result; 
        }  
    }
}