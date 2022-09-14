using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameService
{
    public class BowlingGameKata
    {
        public int CalculateScore(List<int> frames)
        {
            int score = 0;
            foreach (var throws in frames)
            {
                score += throws;
            }
            return score;
        }
    }
}
