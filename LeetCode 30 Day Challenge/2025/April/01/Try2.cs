
namespace BrainPower
{
    public class Try2
    {
        public long MostPoints(int[][] questions)
        {

            long points = 0;
            for (int i = 0;i<questions.Length;i++)
            {
                //bool isSkipCurrent = CheckForSkipOrTake(i,questions);
                int[] question = questions[i];
                long point = question[0];                
                int skips = question[1]; 
                bool skipThis = false;
                for (int j = i+1;j<i+skips && i+skips < questions.Length;j++)
                {
                    if (point < questions[j][0])
                    {
                        skipThis = true;
                    }
                }
                if(!skipThis)
                {
                    points += point;
                } 
            }
            return points;
        }

        
    }
}
