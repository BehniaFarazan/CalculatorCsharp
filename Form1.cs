using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace FunCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clickednum(object sender, EventArgs e)
        {
            if (textBoxResultShow.Text.Equals("0"))
                textBoxResultShow.Clear(); 
            Button button = (Button)sender;
            textBoxResultShow.Text = textBoxResultShow.Text + button.Text;
            //  textBoxResultShow.Text = textBoxResultShow.Text + "1";
        }
        private void clickedMinus(object sender, EventArgs e)
        {

        }

        private void clickedX(object sender, EventArgs e)
        {

        }

        private void clickedDiv(object sender, EventArgs e)
        {

        }

        private void clickedC(object sender, EventArgs e)
        {

        }

        private void clickedEqual(object sender, EventArgs e)
        {

        }
        /*
     
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void clickedPlus(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
 private void Form1_Load_1(object sender, EventArgs e)
        {

        }
       
        */


       
       
    }
}
