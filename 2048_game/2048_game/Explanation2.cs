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
    public partial class Explanation2 : Form
    {
        public Explanation2()
        {
            InitializeComponent();
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {

            Menu form5 = new Menu();
            form5.Show();
            this.Hide();
        }

        private void back_button_Click(object sender, EventArgs e)
        {

            Explanation1 form7 = new Explanation1();
            form7.Show();
            this.Hide();
        }

        private void next_button_Click(object sender, EventArgs e)
        {

            Explanation3 form9 = new Explanation3();
            form9.Show();
            this.Hide();
        }
    }
}
