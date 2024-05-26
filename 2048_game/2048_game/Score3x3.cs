using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _2048_game
{
    internal class Score3x3
    {
        int score;
        int bestScore = 0;
        public Score3x3()
        {
            resetScore();
        }

        public bool isScoreTheBest()
        {
            if (score > bestScore)
            {
                return true;
            }
            return false;
        }
        public void resetScore()
        {
            score = 0;
        }
        public void updateScore(int value)
        {
            score = value;
        }
        public void updateBestScore()
        {
            bestScore = score;
        }
        public void drawScore(Label label)
        {
            label.Text = score.ToString();
        }
    }
}
