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
//
namespace FunCalculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void clickednum(object sender, EventArgs e)
        {
            if (textBoxResultShow.Text.Equals("0") || (isOperationPerformed))
                textBoxResultShow.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBoxResultShow.Text.Contains("."))
                {
                    textBoxResultShow.Text = textBoxResultShow.Text + button.Text;
                }
            }
            else
                textBoxResultShow.Text = textBoxResultShow.Text + button.Text;
            //  textBoxResultShow.Text = textBoxResultShow.Text + "1";
        }
        private void clickedOperator(object sender, EventArgs e)
        {
            try
            {

                Button button = (Button)sender;
                if (resultValue!=0)
                {

                    button1.PerformClick();
                    operationPerformed = button.Text;
                    labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                    isOperationPerformed = true;


                }
                else { 
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBoxResultShow.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
                textBoxResultShow.Clear();
           }
            }
            catch (Exception exp)
            {
            }
        }



        private void clickedC(object sender, EventArgs e)
        {
            textBoxResultShow.Clear();
            labelCurrentOperation.Text = "";
            resultValue = 0;
        }

        private void clickedEqual(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBoxResultShow.Text = (resultValue + Double.Parse(textBoxResultShow.Text)).ToString();
                    labelCurrentOperation.Text = "";

                    break;
                case "-":
                    textBoxResultShow.Text = (resultValue - Double.Parse(textBoxResultShow.Text)).ToString();
                    labelCurrentOperation.Text = "";

                    break;
                case "x":
                    textBoxResultShow.Text = (resultValue * Double.Parse(textBoxResultShow.Text)).ToString();
                    labelCurrentOperation.Text = "";

                    break;
                case "/":
                    textBoxResultShow.Text = (resultValue / Double.Parse(textBoxResultShow.Text)).ToString();
                    labelCurrentOperation.Text = "";

                    break;
                default:
                    labelCurrentOperation.Text = "";
                    break;
            }
            resultValue = Double.Parse(textBoxResultShow.Text);
            labelCurrentOperation.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
