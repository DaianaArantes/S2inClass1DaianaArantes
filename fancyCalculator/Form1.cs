using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fancyCalculator
{
    public partial class FancyCalculator : Form
    {

        //Declaration
        string firstValue = "";
        string secondValue = "";
        char calcOperator;
        double result = 0.0;
        

        public FancyCalculator()
        {
            InitializeComponent();

            //set all buttons to disable, but on/off
            answerBox.Enabled = false;
            number0Button.Enabled = false;
            number1Button.Enabled = false;
            number2Button.Enabled = false;
            number3Button.Enabled = false;
            number4Button.Enabled = false;
            number5Button.Enabled = false;
            number6Button.Enabled = false;
            number7Button.Enabled = false;
            number8Button.Enabled = false;
            number9Button.Enabled = false;
            addButton.Enabled = false;
            sbtrButton.Enabled = false;
            divButton.Enabled = false;
            multButton.Enabled = false;
            EqualButton.Enabled = false;
            dotButton.Enabled = false;
            clearButton.Enabled = false;
            chgSignButton.Enabled = false;

        }


        
        private void onOffButton_Click(object sender, EventArgs e)
        {
            //set to on/off to green when cliked
            //enable all buttons but operators and equal
            if (onOffButton.BackColor == Color.Red)
            {
                onOffButton.BackColor = Color.Green;
                answerBox.Enabled = true;
                number0Button.Enabled = true;
                number1Button.Enabled = true;
                number2Button.Enabled = true;
                number3Button.Enabled = true;
                number4Button.Enabled = true;
                number5Button.Enabled = true;
                number6Button.Enabled = true;
                number7Button.Enabled = true;
                number8Button.Enabled = true;
                number9Button.Enabled = true;
                dotButton.Enabled = true;
                clearButton.Enabled = true;
                chgSignButton.Enabled = true;
            }
            //turn on/off button to red and disable all buttons
            else
            {
                onOffButton.BackColor = Color.Red;
                number0Button.Enabled = false;
                number1Button.Enabled = false;
                number2Button.Enabled = false;
                number3Button.Enabled = false;
                number4Button.Enabled = false;
                number5Button.Enabled = false;
                number6Button.Enabled = false;
                number7Button.Enabled = false;
                number8Button.Enabled = false;
                number9Button.Enabled = false;
                answerBox.Enabled = false;
                addButton.Enabled = false;
                sbtrButton.Enabled = false;
                divButton.Enabled = false;
                multButton.Enabled = false;
                EqualButton.Enabled = false;
                dotButton.Enabled = false;
                clearButton.Enabled = false;
                chgSignButton.Enabled = false;
                firstValue = "";
                secondValue = "";
                answerBox.Text = "";
            }
            
           
        }

        private void number0Button_Click(object sender, EventArgs e)
        {
            //Add 0 to answerBox when number 0 is clicked
            answerBox.Text += "0";
        }

        private void number1Button_Click(object sender, EventArgs e)
        {
            //Add 1 to answerBox when number 1 is clicked
            answerBox.Text += "1";
        }

        private void number2Button_Click(object sender, EventArgs e)
        {
            //Add 2 to answerBox when number 2 is clicked
            answerBox.Text += "2";
        }

        private void number3Button_Click(object sender, EventArgs e)
        {
            //Add 3 to answerBox when number 3 is clicked
            answerBox.Text += "3";
        }

        private void number4Button_Click(object sender, EventArgs e)
        {
            //Add 4 to answerBox when number 4 is clicked
            answerBox.Text += "4";
        }

        private void number5Button_Click(object sender, EventArgs e)
        {
            //Add 5 to answerBox when number 5 is clicked
            answerBox.Text += "5";
        }

        private void number6Button_Click(object sender, EventArgs e)
        {
            //Add 6 to answerBox when number 6 is clicked
            answerBox.Text += "6";
        }

        private void number7Button_Click(object sender, EventArgs e)
        {
            //Add 7 to answerBox when number 7 is clicked
            answerBox.Text += "7";
        }

        private void number8Button_Click(object sender, EventArgs e)
        {
            //Add 8 to answerBox when number 8 is clicked
            answerBox.Text += "8";
        }

        private void number9Button_Click(object sender, EventArgs e)
        {
            //Add 9 to answerBox when number 9 is clicked
            answerBox.Text += "9";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Add the operator + to calcOperator
            calcOperator = '+';
            firstValue = answerBox.Text;

            //enable other operator buttons
            sbtrButton.Enabled = false;
            divButton.Enabled = false;
            multButton.Enabled = false;
            addButton.Enabled = false;
            answerBox.Text = "";
        }

        private void sbtrButton_Click(object sender, EventArgs e)
        {
            //Add the operator - to calcOperator
            calcOperator = '-';

            //Transfer value from answerBox to firstValue
            firstValue = answerBox.Text;

            //enable other operator buttons
            divButton.Enabled = false;
            multButton.Enabled = false;
            addButton.Enabled = false;
            sbtrButton.Enabled = false;
            answerBox.Text = "";
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            //Add the operator * to calcOperator
            calcOperator = '*';

            //Transfer value from answerBox to firstValue
            firstValue = answerBox.Text;

            //enable other operator buttons
            sbtrButton.Enabled = false;
            divButton.Enabled = false;
            addButton.Enabled = false;
            multButton.Enabled = false;
            answerBox.Text = "";
            

        }

        private void divButton_Click(object sender, EventArgs e)
        {
            //Add the operator / to calcOperator
            calcOperator = '/';

            //Transfer value from answerBox to firstValue
            firstValue = answerBox.Text;

            //enable other operator buttons
            sbtrButton.Enabled = false;
            multButton.Enabled = false;
            addButton.Enabled = false;
            divButton.Enabled = false;
            answerBox.Text = "";
            

        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            
           //Clear all variables and enable all buttons but equal
            firstValue = "";
            secondValue = "";
            answerBox.Text = "";
            calcOperator = ' ';
            sbtrButton.Enabled = true;
            multButton.Enabled = true;
            divButton.Enabled = true;
            addButton.Enabled = true;
            number0Button.Enabled = true;
            number1Button.Enabled = true;
            number2Button.Enabled = true;
            number3Button.Enabled = true;
            number4Button.Enabled = true;
            number5Button.Enabled = true;
            number6Button.Enabled = true;
            number7Button.Enabled = true;
            number8Button.Enabled = true;
            number9Button.Enabled = true;
            dotButton.Enabled = true;
            chgSignButton.Enabled = true;
            EqualButton.Enabled = false;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            //Transfer value from answerBox to secondValue
            if (secondValue.Equals("")) { 
                secondValue = answerBox.Text;
            }

            answerBox.Text = "";

            //Disable all buttons but Clear and on/Off
            sbtrButton.Enabled = true;
            multButton.Enabled = true;
            divButton.Enabled = true;
            addButton.Enabled = true;
            number0Button.Enabled = true;
            number1Button.Enabled = true;
            number2Button.Enabled = true;
            number3Button.Enabled = true;
            number4Button.Enabled = true;
            number5Button.Enabled = true;
            number6Button.Enabled = true;
            number7Button.Enabled = true;
            number8Button.Enabled = true;
            number9Button.Enabled = true;
            EqualButton.Enabled = true;
            dotButton.Enabled = true;
            chgSignButton.Enabled = true;

            
            try
            {
                
                switch (calcOperator)
                {
                    //Sum firstValue and Second value
                    case '+':
                        result += double.Parse(firstValue) + 
                            double.Parse(secondValue);
                        answerBox.Text = result.ToString();
                        
                        break;
                    //Subtract firstValue and Second value
                    case '-':
                        result = double.Parse(firstValue) - 
                            double.Parse(secondValue);
                        answerBox.Text = result.ToString();
                        break;
                    //Multiply firstValue and Second value
                    case '*':
                        result = double.Parse(firstValue) * 
                            double.Parse(secondValue);
                        answerBox.Text = result.ToString();
                        break;
                    //Divide firstValue and Second value
                    case '/':
                        if (firstValue != "0" && secondValue != "0")
                        {
                            result = double.Parse(firstValue) / 
                                double.Parse(secondValue);
                            answerBox.Text = result.ToString();
                        }
                        //Show error message when divison is by zero
                        else
                        {
                            answerBox.Text = "Cannot divide by zero!";
                        }
                        break;
                }
            }
            catch (FormatException ex)
            {
                answerBox.Text = "Math Error";
            }
        }

        private void answerBox_TextChanged(object sender, EventArgs e)
        {
            //Equal button is enable when something is 
            //inserted in the answerBox
            if(!firstValue.Equals("") && !answerBox.Text.Equals(""))
            {
                EqualButton.Enabled = true;
            }
            //Enable the operator buttons when any value 
            //is typed in the firstBox
            else if (firstValue.Equals("") && !answerBox.Text.Equals(""))
            {
                addButton.Enabled = true;
                sbtrButton.Enabled = true;
                divButton.Enabled = true;
                multButton.Enabled = true;
            }
           
        }

        private void chgSignButton_Click(object sender, EventArgs e)
        {
            if(!answerBox.Text.Equals("") && !answerBox.Text.Equals("."))
            {
                answerBox.Text = (-double.Parse(answerBox.Text)).ToString();
            }
            
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            
            if(!answerBox.Text.Contains("."))
            {
                answerBox.Text += ".";
            }
        }
    }
}
