using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorGUI
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        string result = "N/A";
        bool isOperationDone = false;
        private void btnAllClear_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
            result = "N/A";
            listBoxHistory.Items.Clear();
            listBoxHistory.Items.Add("History removed");
        }

        private void btnNu0_Click(object sender, EventArgs e)
        {
            //to remove 0 and then btn number will be appended
            if ((textDisplay.Text == "0") || (isOperationDone))
            { textDisplay.Clear(); }

            isOperationDone = false;
            textDisplay.Text += "0";
        }

        private void btnNu1_Click(object sender, EventArgs e)
        {
            if((textDisplay.Text == "0") || (isOperationDone))
            { textDisplay.Clear(); }

            isOperationDone = false;
            textDisplay.Text += "1";
        }

        private void btnNu2_Click(object sender, EventArgs e)
        {
            if ((textDisplay.Text == "0") || (isOperationDone))
            { textDisplay.Clear(); }

            isOperationDone = false;
            textDisplay.Text += "2";
        }

        private void btnNu3_Click(object sender, EventArgs e)
        {
            if ((textDisplay.Text == "0") || (isOperationDone))
            { textDisplay.Clear(); }

            isOperationDone = false;

            textDisplay.Text += "3";
        }

        private void btnNu4_Click(object sender, EventArgs e)
        {
            if ((textDisplay.Text == "0") || (isOperationDone))
            { textDisplay.Clear(); }

            isOperationDone = false;

            textDisplay.Text += "4";
        }

        private void btnNu5_Click(object sender, EventArgs e)
        {
            if ((textDisplay.Text == "0") || (isOperationDone))
            { textDisplay.Clear(); }

            isOperationDone = false;

            textDisplay.Text += "5";
        }

        private void btnNu6_Click(object sender, EventArgs e)
        {
            if ((textDisplay.Text == "0") || (isOperationDone))
            { textDisplay.Clear(); }

            isOperationDone = false;

            textDisplay.Text += "6";
        }

        private void btnNu7_Click(object sender, EventArgs e)
        {
            if ((textDisplay.Text == "0") || (isOperationDone))
            { textDisplay.Clear(); }

            isOperationDone = false;

            textDisplay.Text += "7";
        }

        private void btnNu8_Click(object sender, EventArgs e)
        {
            if ((textDisplay.Text == "0") || (isOperationDone))
            { textDisplay.Clear(); }

            isOperationDone = false;

            textDisplay.Text += "8";
        }

        private void btnNu9_Click(object sender, EventArgs e)
        {
            if ((textDisplay.Text == "0") || (isOperationDone))
            { textDisplay.Clear(); }

            isOperationDone = false;

            textDisplay.Text += "9";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            //to contain . only for one time
            if (!textDisplay.Text.Contains("."))
            {
                textDisplay.Text += ".";
            }
            
        }

        private void btnSummation_Click(object sender, EventArgs e)
        {
            if (!textDisplay.Text.Contains("+"))
            {
                textDisplay.Text += "+";
            }
            
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            //to have -ve at first
            if (textDisplay.Text == "0")
            { textDisplay.Clear(); }

            if (!textDisplay.Text.Contains("-"))
            {
                textDisplay.Text += "-";
            };
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (!textDisplay.Text.Contains("*"))
            {
                textDisplay.Text += "*";
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (!textDisplay.Text.Contains("/"))
            {
                textDisplay.Text += "/";
            }
        }


        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                int operatorIndex = 0;

                if (textDisplay.Text.Contains("+"))
                {
                    operatorIndex = textDisplay.Text.IndexOf("+");
                }
                else if (textDisplay.Text.Contains("-"))
                {
                    operatorIndex = textDisplay.Text.IndexOf("-");
                }
                else if (textDisplay.Text.Contains("*"))
                {
                    operatorIndex = textDisplay.Text.IndexOf("*");
                }
                else if (textDisplay.Text.Contains("/"))
                {
                    operatorIndex = textDisplay.Text.IndexOf("/");
                }

                string operator_ = textDisplay.Text.Substring(operatorIndex, 1);
                double beforeOperator = Convert.ToDouble(textDisplay.Text.Substring(0, operatorIndex));
                double afterOperator = Convert.ToDouble(textDisplay.Text.Substring(operatorIndex + 1, textDisplay.Text.Length - operatorIndex - 1));

                if (operator_ == "+")
                {
                    listBoxHistory.Items.Add(textDisplay.Text + " = " + (beforeOperator + afterOperator));
                    result = (beforeOperator + afterOperator).ToString();
                    textDisplay.Text = result;
                }
                else if (operator_ == "-")
                {
                    listBoxHistory.Items.Add(textDisplay.Text + " = " + (beforeOperator - afterOperator));
                    result = (beforeOperator - afterOperator).ToString();
                    textDisplay.Text = result;
                }
                else if (operator_ == "*")
                {
                    listBoxHistory.Items.Add(textDisplay.Text + " = " + (beforeOperator * afterOperator));
                    result = (beforeOperator * afterOperator).ToString();
                    textDisplay.Text = result;
                }
                else if (operator_ == "/")
                {
                    listBoxHistory.Items.Add(textDisplay.Text + " = " + (beforeOperator / afterOperator));
                    result = (beforeOperator / afterOperator).ToString();
                    textDisplay.Text = result;
                }

                isOperationDone = true;
            }
            catch
            { textDisplay.Text = "Error!"; }

            textDisplay.Clear();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "Answer = " + result;
        }

        private void btnNameId_Click(object sender, EventArgs e)
        {
            listBoxHistory.Items.Clear();
            listBoxHistory.Items.Add("Created by - ");
            listBoxHistory.Items.Add("Afique Sadique");
            listBoxHistory.Items.Add("19 - 39708 - 1");
            listBoxHistory.Items.Add("OOP2 [H]");
        }
    }
}
