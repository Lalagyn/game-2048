using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048_game
{
    public partial class Field3x3_Form : Form
    {

        Field3x3 field;
        Score3x3 score;
        public Field3x3_Form()
        {
            InitializeComponent();
            field = new Field3x3();
            drawField();
            resetViewPanels();
            score = new Score3x3();
        }

        private void drawField()
        {
            int rowCount = field.gameField.GetLength(0);
            int columnCount = field.gameField.GetLength(1);

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (i < tableLayoutPanel1.RowCount && j < tableLayoutPanel1.ColumnCount)
                    {
                        Control c = tableLayoutPanel1.GetControlFromPosition(j, i);
                        if (field.gameField[i, j].getValue() > 0)
                            c.Text = field.gameField[i, j].getValue().ToString();
                        else
                            c.Text = " ";
                        changeColors(c, field.gameField[i, j].getValue());
                    }
                }
            }
        }

        private void changeColors(Control control, int value)
        {
            switch (value)
            {
                case 0:
                    control.BackColor = ColorTranslator.FromHtml("#3399ff");
                    break;
                case 2:
                    control.BackColor = ColorTranslator.FromHtml("#e3e1af");
                    control.ForeColor = Color.Black;
                    break;
                case 4:
                    control.BackColor = ColorTranslator.FromHtml("#bdba7b");
                    control.ForeColor = Color.Black;
                    break;
                case 8:
                    control.BackColor = ColorTranslator.FromHtml("#c99534");
                    control.ForeColor = Color.White;
                    break;
                case 16:
                    control.BackColor = ColorTranslator.FromHtml("#d66829");
                    control.ForeColor = Color.White;
                    break;
                case 32:
                    control.BackColor = ColorTranslator.FromHtml("#c24621");
                    control.ForeColor = Color.White;
                    break;
                case 64:
                    control.BackColor = ColorTranslator.FromHtml("#e03314");
                    control.ForeColor = Color.White;
                    break;
                case 128:
                    control.BackColor = ColorTranslator.FromHtml("#a18c23");
                    control.ForeColor = Color.White;
                    break;
                case 256:
                    control.BackColor = ColorTranslator.FromHtml("#b89902");
                    control.ForeColor = Color.White;
                    break;
                case 512:
                    control.BackColor = ColorTranslator.FromHtml("#e8cd4a");
                    control.ForeColor = Color.White;
                    break;
                case 1024:
                    control.BackColor = ColorTranslator.FromHtml("#f0cf2e");
                    control.ForeColor = Color.White;
                    break;
                case 2048:
                    control.BackColor = ColorTranslator.FromHtml("#fad107");
                    control.ForeColor = Color.White;
                    break;
            }
        }
       
        private void resetViewPanels()
        {
            pressA.BackColor = Color.CornflowerBlue;
            pressD.BackColor = Color.CornflowerBlue;
            pressW.BackColor = Color.CornflowerBlue;
            pressS.BackColor = Color.CornflowerBlue;
        }

        private void MainForm_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (field.moveCellsLeft())
                {
                    resetViewPanels();
                    pressA.BackColor = Color.Goldenrod;
                    if (!field.isGameOver())
                    {
                        field.addNewField();
                        drawField();
                    }
                }
                else if (field.isGameOver())
                    gameOver();
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (field.moveCellsRight())
                {
                    resetViewPanels();
                    pressD.BackColor = Color.Goldenrod;
                    if (!field.isGameOver())
                    {
                        field.addNewField();
                        drawField();
                    }
                }
                else if (field.isGameOver())
                    gameOver();
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (field.moveCellsUp())
                {
                    resetViewPanels();
                    pressW.BackColor = Color.Goldenrod;
                    if (!field.isGameOver())
                    {
                        field.addNewField();
                        drawField();
                    }
                }
                else if (field.isGameOver())
                    gameOver();
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (field.moveCellsDown())
                {
                    resetViewPanels();
                    pressS.BackColor = Color.Goldenrod;
                    if (!field.isGameOver())
                    {
                        field.addNewField();
                        drawField();
                    }
                }
                else if (field.isGameOver())
                    gameOver();
            }
            if (field.takeBiggestTile() == 2048)
            {
                congratulations_label.Visible = true;
                Win_label.Visible = true;
                drawGameOver();
                return;
            }
            score.updateScore(field.getScoreValue());
            score.drawScore(scoreLabel);
        }
        private void drawGameOver()
        {
            gameOverPanel.Visible = true;
            gameOverPanel.Enabled = true;
        }
        private void gameOver()
        {
            drawGameOver();
            if (score.isScoreTheBest())
            {
                gameOverLabel.Visible = true;
                score.updateBestScore();
            }
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            gameOverPanel.Visible = false;
            gameOverPanel.Enabled = false;
            congratulations_label.Visible = false;
            Win_label.Visible = false;
            score.resetScore();
            score.drawScore(scoreLabel);
            field.resetBoard();
            drawField();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu form5 = new Menu();
            form5.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Field_Form form1 = new Field_Form();
            form1.Show();
            this.Hide();
        }

       private void resetGameButton_Click_1(object sender, EventArgs e)
        {
            field = new Field3x3();
           field.resetBoard();
            drawField();
            scoreLabel.Text = "0";
        }

      
    }
}
