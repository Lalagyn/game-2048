using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2048_game{
    public partial class Field4x4_Form : Form
    {
        Field4x4 field;
        Score4x4 score;
        public Field4x4_Form()
        {
            InitializeComponent();
            field = new Field4x4();
            drawField();
            resetViewPanels();
            score = new Score4x4();  
        }


        private void drawField()
        {
            for (int i = 0; i <= this.tableLayoutPanel1.ColumnCount - 1; i++)
            {
                for (int j = 0; j <= this.tableLayoutPanel1.RowCount - 1; j++)
                {
                    Control c = this.tableLayoutPanel1.GetControlFromPosition(i, j);
                    if (field.gameField[i, j].getValue() > 0)
                        c.Text = field.gameField[i, j].getValue().ToString();
                    else
                        c.Text = " ";
                }
            }
            changeCellsBackColor();
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
        private void changeCellsBackColor()
        {
            int fieldValue = 0;
            for (int i = 0; i <= this.tableLayoutPanel1.ColumnCount - 1; i++)
            {
                for (int j = 0; j <= this.tableLayoutPanel1.RowCount - 1; j++)
                {
                    fieldValue = field.gameField[i, j].getValue();
                    Control c = this.tableLayoutPanel1.GetControlFromPosition(i, j);
                    changeColors(c, fieldValue);
                }
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

        private void resetGameButton_Click(object sender, EventArgs e)
        {
            field = new Field4x4();
            field.resetBoard();
            drawField();
            scoreLabel.Text = "0";
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
     
        private void backToMenuButton_Click(object sender, EventArgs e)
        { 
            Menu form5 = new Menu();
            form5.Show();
            this.Hide();
        }
    }
}

