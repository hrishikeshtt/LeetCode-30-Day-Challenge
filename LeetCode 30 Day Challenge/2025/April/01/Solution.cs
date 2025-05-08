namespace BrainPower
{
    public class Try5
    {
        public long MostPoints(int[][] questions)
        {
            
            long[] points = new long[questions.Length];
            for (int index = questions.Length - 1; index>=0; index--)
            {
                long solvePoint;
                long skipPoint;
                if (index+questions[index][1]+1 < questions.Length)
                {
                    solvePoint = questions[index][0]+points[index+questions[index][1]+1];
                    points[index] = questions[index][0] + points[index+questions[index][1]+1];
                }
                else
                {
                    solvePoint = questions[index][0];
                    points[index] = questions[index][0];
                }
                if (index == questions.Length -1)
                    skipPoint = 0;
                else
                    skipPoint = points[index+1];

                points[index] = Math.Max(skipPoint, solvePoint);
            }
            return points[0];
        }
    }
}
