using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048_game
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void New_Game_Button_Click(object sender, EventArgs e)
        {
            Field_Form form1 = new Field_Form();
            form1.Show();
            this.Hide();
           
        }
       
        private void About_button_Click(object sender, EventArgs e)
        {
            History_game form6 = new History_game();
            form6.Show();
            this.Hide();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void explanation_button_Click(object sender, EventArgs e)
        {
            Explanation1 form7 = new Explanation1();
            form7.Show();
            this.Hide();
        }

    }
}
