namespace BrainPower
{
    public class Try3
    {
        public long MostPoints(int[][] questions)
        {
            long maximumPoints = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                long point = questions[i][0];
                int skips = questions[i][1];
                bool solveThis = false;
                long ifSolvedThisPoint = 0;
                if (i+skips+1 < questions.Length)
                {
                    ifSolvedThisPoint = point + questions[i+skips+1][0];
                }
                else
                    solveThis = true;

                for (int j = i+questions[i][1]+1; j < questions.Length; j++)
                {
                    if (questions[j][0] < ifSolvedThisPoint)
                        solveThis = true;
                }
                if (solveThis)
                {
                    maximumPoints += point;
                    i+= skips;
                }

            }
            return maximumPoints;

        }
    }
}
