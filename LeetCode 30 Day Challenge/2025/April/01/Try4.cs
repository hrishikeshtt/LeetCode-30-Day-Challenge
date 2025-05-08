
namespace BrainPower
{
    public class Try4
    {
        public long MostPoints(int[][] questions)
        {
            int point = 0;
            long points = GetPoints(questions, 0, true, point);
            long skipPoints = GetPoints(questions, 0, false, point);
            return points > skipPoints ? points : skipPoints;
        }

        public long GetPoints(int[][] questions, int index, bool isSolve, int point)
        {
            if (index < questions.Length)
            {                
                if (isSolve)
                {
                    if (index < questions.Length)
                        point += questions[index][0];
                    int skips = questions[index][1];
                    index = index+skips+1;                    
                }
                else
                {
                    index = index+1;
                }
                long solvePoints = GetPoints(questions, index, true, point);
                long skippedPoints = GetPoints(questions, index, false, point);                
                return solvePoints > skippedPoints ? solvePoints : skippedPoints;

            }
            else
                return point;
        }
    }
}
