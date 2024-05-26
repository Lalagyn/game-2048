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
    public partial class Explanation3 : Form
    {
        public Explanation3()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Explanation2 form8 = new Explanation2();
            form8.Show();
            this.Hide();
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {

            Menu form5 = new Menu();
            form5.Show();
            this.Hide();
        }

        private void Game_Button_Click(object sender, EventArgs e)
        {

            Menu form5 = new Menu();
            form5.Show();
            this.Hide();
        }
    }
}
