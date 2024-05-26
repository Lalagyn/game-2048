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
    public partial class Field_Form : Form
    {
        public Field_Form()
        {
            InitializeComponent();
        }


        private void Start_game_button_Click(object sender, EventArgs e)
        {
            if (Small_RadioButton.Checked)
            {
                Field3x3_Form form2 = new Field3x3_Form();
                form2.Show();
                this.Hide();
            }
            else if (Classic_RadioButton.Checked)
            {
                Field4x4_Form form3 = new Field4x4_Form();
                form3.Show();
                this.Hide();
            }
            else if (Big_RadioButton.Checked)
            {
                Field5x5_Form form4 = new Field5x5_Form();
                form4.Show();
                this.Hide();
            }
        }
        private void Home_Button_Click(object sender, EventArgs e)
        {
            Menu form5 = new Menu();
            form5.Show();
            this.Hide();
        }
    }
}
