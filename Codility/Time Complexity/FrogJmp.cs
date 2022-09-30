namespace Codility.Time_Complexity
{
    class FrogJmp
    {
        public int Solution(int X, int Y, int D)
        {
            decimal jumps = 0;
            if (X >= Y)
            {
                return (int)jumps;
            }

            jumps = (decimal)(Y - X - D) / D;
            jumps++; // because we removed first step in line above

            if (jumps % 1 != 0)
                jumps++;

            return (int)jumps;
        }
    }
}
