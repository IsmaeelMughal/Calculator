using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calculator : Form
    {
        double primaryNumber = 0;
        double secondaryNumber = 0;
        double result = 0;
        char lastOperation;
        const string errorString = "ERROR!!!";

        const int MAX_LENGTH_OF_DIGITS = 12;

        public calculator()
        {
            InitializeComponent();
            primaryTextbox.Text = "0";
        }

        private double getPrimaryNumber()
        {
            return primaryNumber = Convert.ToDouble(primaryTextbox.Text);
        }

        private double getSecondaryNumber()
        {
            return secondaryNumber = Convert.ToDouble(secondaryTextbox.Text);
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isValidLength()
        {
            if(primaryTextbox.Text.Length < MAX_LENGTH_OF_DIGITS)
            {
                return true;
            }
            return false;
        }

        private void num_handler(object sender, EventArgs e)
        {
            if (isValidLength())
            {
                Button button = (Button)sender;
                if (button.Text == "0")
                {
                    if (primaryTextbox.Text != "0")
                    {
                        primaryTextbox.Text += button.Text;
                    }
                }
                else
                {
                    if (primaryTextbox.Text == "0")
                    {
                        primaryTextbox.Text = button.Text;
                    }
                    else
                    {
                        primaryTextbox.Text += button.Text;
                    }
                }
            }
        }

        private void signBtn_Click(object sender, EventArgs e)
        {
            if (!primaryTextbox.Text.Equals(string.Empty))
            {
                primaryNumber = getPrimaryNumber();
                if (primaryNumber != 0)
                {
                    primaryNumber *= -1;
                    primaryTextbox.Text = Convert.ToString(primaryNumber);
                }
            }
        }

        private bool isHasDot()
        {
            if(primaryTextbox.Text.Contains("."))
            {
                return true;
            }
            return false;
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            if(!isHasDot())
            {
                primaryTextbox.Text += ".";
            }
        }

        private void enableButtons()
        {
            modulusBtn.Enabled = true;
            inverseBtn.Enabled = true;
            button7.Enabled = true;
            SQRTBtn.Enabled = true;
            SQRTBtn.Enabled = true;
            Btn7.Enabled = true;
            Btn8.Enabled = true;
            btn9.Enabled = true;
            mulBtn.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            subBtn.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            addBtn.Enabled = true;
            signBtn.Enabled = true;
            Btn0.Enabled = true;
            dotBtn.Enabled = true;
            equalBtn.Enabled = true;
            divideBtn.Enabled = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (primaryTextbox.Text == errorString)
            {
                cBtn_Click(sender, e);
            }
            else if(primaryTextbox.Text != "0" && primaryTextbox.Text != "")
            {
                primaryTextbox.Text = primaryTextbox.Text.Substring(0, primaryTextbox.Text.Length - 1);
                if (primaryTextbox.Text.Equals(""))
                {
                    primaryTextbox.Text = "0";
                }
                enableButtons();
            }
        }

        private void ceBtn_Click(object sender, EventArgs e)
        {
            if(primaryTextbox.Text == errorString)
            {
                cBtn_Click((object)sender, e);
            }
            else
            {
                primaryTextbox.Text = "0";
                primaryNumber = 0;
                enableButtons();
            }
        }

        private void cBtn_Click(object sender, EventArgs e)
        {
            primaryTextbox.Text = "0";
            secondaryTextbox.Text = "";
            primaryNumber = 0;
            secondaryNumber = 0;
            enableButtons();
        }

        //private double performBasicOperation(double snum, double pnum, char op)
        //{
        //    double res = 0;
        //    switch (op)
        //    {
        //        case 'x':
        //            res = pnum * snum;
        //            break;
        //        case '-':
        //            res =  pnum - snum;
        //            break;
        //        case '+':
        //            res = pnum + snum;
        //            break;
        //        case '/':
        //            res = pnum / snum;
        //            break;
        //        default:
        //            break;
        //    }
        //    return res;
        //}

        private void disableButtons()
        {
            modulusBtn.Enabled = false;
            inverseBtn.Enabled = false;
            button7.Enabled = false;
            SQRTBtn.Enabled = false;
            SQRTBtn.Enabled = false;
            Btn7.Enabled = false;
            Btn8.Enabled = false;
            btn9.Enabled = false;
            mulBtn.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            subBtn.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            addBtn.Enabled = false;
            signBtn.Enabled = false;
            Btn0.Enabled = false;
            dotBtn.Enabled = false;
            equalBtn.Enabled = false;
            divideBtn.Enabled = false;
        }

        private void basic_operation_Click(object sender, EventArgs e)
        {
            Button opBtn = (Button)sender;
            if (secondaryTextbox.Text.Equals(string.Empty) && primaryTextbox.Text != "")
            {
                secondaryNumber = Convert.ToDouble(primaryTextbox.Text);
                lastOperation = Convert.ToChar(opBtn.Text);
                secondaryTextbox.Text = primaryTextbox.Text + " " + lastOperation;
                primaryTextbox.Text = "";
            }
            else if (!secondaryTextbox.Text.Equals(string.Empty))
            {
                if (!primaryTextbox.Text.Equals(string.Empty))
                {
                    if (lastOperation == '=')
                    {
                        secondaryNumber = Convert.ToDouble(primaryTextbox.Text);
                        lastOperation = Convert.ToChar(opBtn.Text);
                        secondaryTextbox.Text = primaryTextbox.Text + " " + lastOperation;
                        primaryTextbox.Text = "";
                    }
                    else
                    {
                        primaryNumber = Convert.ToDouble(primaryTextbox.Text);
                        if (primaryNumber == 0 && lastOperation == '/')
                        {
                            primaryTextbox.Text = errorString;
                            secondaryTextbox.Text = Convert.ToString(secondaryNumber) + " /";
                            primaryNumber = 0;
                            secondaryNumber = 0;
                            lastOperation = 'q';
                            disableButtons();
                        }
                        else
                        {
                            secondaryNumber = performBasicOperation(primaryNumber, secondaryNumber, lastOperation);
                            lastOperation = Convert.ToChar(opBtn.Text);
                            secondaryTextbox.Text = Convert.ToString(secondaryNumber) + " " + lastOperation;
                            primaryTextbox.Text = "";
                            if (Double.IsInfinity(secondaryNumber))
                            {
                                primaryTextbox.Text = errorString;
                                disableButtons();
                            }
                        }
                    }
                }
                else
                {
                    lastOperation = Convert.ToChar(opBtn.Text);
                    secondaryTextbox.Text = Convert.ToString(secondaryNumber) + " " + lastOperation;
                    primaryTextbox.Text = "";
                    if (Double.IsInfinity(secondaryNumber))
                    {
                        primaryTextbox.Text = errorString;
                        disableButtons();
                    }
                }
            }
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            Button opBtn = (Button)sender;
            if (secondaryTextbox.Text.Equals(string.Empty) && primaryTextbox.Text != "")
            {
                secondaryNumber = Convert.ToDouble(primaryTextbox.Text);
                lastOperation = Convert.ToChar(opBtn.Text);
                secondaryTextbox.Text = primaryTextbox.Text + " " + lastOperation;
            }
            else if (!secondaryTextbox.Text.Equals(string.Empty))
            {
                if (!primaryTextbox.Text.Equals(string.Empty))
                {
                    primaryNumber = Convert.ToDouble(primaryTextbox.Text);
                    if (primaryNumber == 0 && lastOperation == '/')
                    {
                        primaryTextbox.Text = errorString;
                        secondaryTextbox.Text = Convert.ToString(secondaryNumber) + " /";
                        primaryNumber = 0;
                        secondaryNumber = 0;
                        lastOperation = 'q';
                        disableButtons();
                    }
                    else if (lastOperation == '=')
                    {
                        secondaryNumber = Convert.ToDouble(primaryTextbox.Text);
                        lastOperation = Convert.ToChar(opBtn.Text);
                        secondaryTextbox.Text = primaryTextbox.Text + " " + lastOperation;
                    }
                    else
                    {
                        result = performBasicOperation(primaryNumber, secondaryNumber, lastOperation);
                        char prevOp = lastOperation;
                        lastOperation = Convert.ToChar(opBtn.Text);
                        secondaryTextbox.Text = Convert.ToString(secondaryNumber) + " " + prevOp+ " " + Convert.ToString(primaryNumber) + " =";
                        primaryTextbox.Text = Convert.ToString(result);
                        if (Double.IsInfinity(secondaryNumber))
                        {
                            primaryTextbox.Text = errorString;
                            disableButtons();
                        }
                    }
                }
            }
        }

        private void inverseBtn_Click(object sender, EventArgs e)
        {
            if (primaryTextbox.Text!= "")
            {
                if (primaryTextbox.Text == "0")
                {
                    primaryTextbox.Text = errorString;
                    secondaryTextbox.Text = "1/(0) = ";
                    primaryNumber = 0;
                    secondaryNumber = 0;
                    lastOperation = 'q';
                    disableButtons();
                }
                else
                {
                    primaryNumber = getPrimaryNumber();
                    secondaryNumber = performBasicOperation(primaryNumber, 1, '/');
                    secondaryTextbox.Text = "1/(" + Convert.ToString(secondaryNumber) + ")" + " =";
                    lastOperation = '=';
                    primaryTextbox.Text = Convert.ToString(secondaryNumber);
                    if (Double.IsInfinity(secondaryNumber))
                    {
                        primaryTextbox.Text = errorString;
                        disableButtons();
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (primaryTextbox.Text != "")
            {
                primaryNumber = getPrimaryNumber();
                secondaryNumber = primaryNumber * primaryNumber;
                secondaryTextbox.Text = "SQR(" + Convert.ToString(secondaryNumber) + ")" + " =";
                lastOperation = '=';
                primaryTextbox.Text = Convert.ToString(secondaryNumber);
                if (Double.IsInfinity(secondaryNumber))
                {
                    primaryTextbox.Text = errorString;
                    disableButtons();
                }
            }
        }

        private void SQRTBtn_Click(object sender, EventArgs e)
        {
            if (primaryTextbox.Text != "")
            {
                primaryNumber = getPrimaryNumber();
                secondaryNumber = Math.Sqrt(primaryNumber);
                secondaryTextbox.Text = "SQRT(" + Convert.ToString(secondaryNumber) + ")" + " =";
                lastOperation = '=';
                primaryTextbox.Text = Convert.ToString(secondaryNumber);
                if (Double.IsInfinity(secondaryNumber))
                {
                    primaryTextbox.Text = errorString;
                    disableButtons();
                }
            }
        }
    }
}
