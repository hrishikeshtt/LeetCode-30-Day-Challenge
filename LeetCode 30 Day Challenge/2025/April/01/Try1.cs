
namespace BrainPower
{
    public class Try1
    {
        public long MostPoints(int[][] questions)
        {

            long maximumPoints = 0;
            bool isSkip = false;
            for (int i = 0; i < questions.Length; i++)
            {
                (long points, int nextIndex, long maximum) = GetPoints(questions, i, isSkip, 0, maximumPoints);
                if (maximum > maximumPoints)
                    maximumPoints = maximum;
                isSkip = true;
                (points, nextIndex, maximum) = GetPoints(questions, i, isSkip, 0, maximumPoints);
                if (maximum > maximumPoints)
                    maximumPoints = maximum;
            }
            return maximumPoints;
        }

        private (long, int, long) GetPoints(int[][] questions, int i, bool isSkip, int points, long maximumPoints)
        {
            if (i<questions.Length)
            {
                if (isSkip)
                {
                    (long geneartedPoints, int nextIndex, maximumPoints) = GetPoints(questions, i+1, false, points, maximumPoints);
                    if (geneartedPoints > maximumPoints)
                        maximumPoints = geneartedPoints;
                    (geneartedPoints, nextIndex, maximumPoints) = GetPoints(questions, i+1, true, points, maximumPoints);
                    if (geneartedPoints > maximumPoints)
                        maximumPoints = geneartedPoints;
                }
                points += questions[i][0];
                maximumPoints = points;
                for (int j = i+questions[i][1]+1; j < questions.Length; j++)
                {
                    (long geneartedPoints, int nextIndex, maximumPoints) = GetPoints(questions, j, false, points, maximumPoints);
                    if (geneartedPoints > maximumPoints)
                        maximumPoints = geneartedPoints;
                    (geneartedPoints, nextIndex, maximumPoints) = GetPoints(questions, j, true, points, maximumPoints);
                    if (geneartedPoints > maximumPoints)
                        maximumPoints = geneartedPoints;
                }
                return (points, i+questions[i][1], maximumPoints);
            }
            return (0, 0, 0);


        }
    }
}
