using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

 
namespace CalculatorCsharp
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerfomed = false;
     //   private decimal firstNum = 0.0m;
    //    private decimal secondNum = 0.0m;
      //  private decimal result = 0.0m;
        //private int operatorType = (int)MathOperations.NoOperator;

    



        private void DigitBtn_Click(object sender, EventArgs e)
        {
            

            if ((DisplayTextBox.Text == "0")|| (isOperationPerfomed))
            {
                DisplayTextBox.Clear();
            }
            isOperationPerfomed = false;
            Button button = (Button)sender;
            if (button.Text == System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator)
            {
                if(!DisplayTextBox.Text.Contains(System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                    
            DisplayTextBox.Text = DisplayTextBox.Text + button.Tag;
            }
            else
            DisplayTextBox.Text = DisplayTextBox.Text + button.Tag;
        }

      /*  private void DotButton_Click(object sender, EventArgs e)
        {
            if (!DisplayTextBox.Text.Contains('.'))
            {
                DisplayTextBox.Text += ".";
            }
        }*/

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            if (!DisplayTextBox.Text.Contains('-'))
            {
                DisplayTextBox.Text = "-" + DisplayTextBox.Text;
            }
            else
            {
                DisplayTextBox.Text = DisplayTextBox.Text.Trim('-');
                   
            }
        }

    
        private void SqrtButton_Click(object sender, EventArgs e)
        {
            double k;
            k = Convert.ToDouble(DisplayTextBox.Text);
            DisplayTextBox.Text = Convert.ToString(Math.Sqrt(k));
          //  Save((int)MathOperations.Sqrt);
        }
        /*
        private void PowButton_Click(object sender, EventArgs e)
        {
            
        }
        */
        private void EqualButton_Click(object sender, EventArgs e)
        {
            Double operand1 = resultValue;
            Double operand2=0;
            Double.TryParse(DisplayTextBox.Text,NumberStyles.Float,System.Globalization.CultureInfo.InvariantCulture,out operand2);
         //   secondNum = Convert.ToDecimal(DisplayTextBox.Text);
            switch (operationPerformed)
            {
                case "+":
                    DisplayTextBox.Text = (operand1 + operand2).ToString();
                    break;
                
                case "-":
                    DisplayTextBox.Text = (operand1 - operand2).ToString();
                    break;
                case "*":
                    DisplayTextBox.Text = (operand1 * operand2).ToString();
                    break;
                case "/":
                    DisplayTextBox.Text = (operand1 / operand2).ToString();
                    break;
               /* case "^":
                    DisplayTextBox.Text = (Math.Pow(operand1,operand2)).ToString();
                    break;
               /* case "+":
                    DisplayTextBox.Text = (resultValue + Double.Parse(DisplayTextBox.Text)).ToString();
                    break;
                
                case "-":
                    DisplayTextBox.Text = (resultValue - Double.Parse(DisplayTextBox.Text)).ToString();
                 
                    break;
                case "*":
                    DisplayTextBox.Text = (resultValue * Double.Parse(DisplayTextBox.Text)).ToString();
                    break;
                case "/":
                    DisplayTextBox.Text = (resultValue / Double.Parse(DisplayTextBox.Text)).ToString();
                    break;
                case "^":
                    DisplayTextBox.Text = (Math.Pow(resultValue,Double.Parse(DisplayTextBox.Text))).ToString();
                    break;*/
                default:
                    break;
                    /*
                case  (int)MathOperations.Add: result = firstNum + secondNum; break;
                case (int)MathOperations.Minus: result = firstNum - secondNum; break;
                case (int)MathOperations.Divide: result = firstNum / secondNum; break;
                case (int)MathOperations.Multiply: result = firstNum * secondNum; break;
                case (int)MathOperations.Pow: result = (int)Math.Pow(Convert.ToDouble(firstNum),Convert.ToDouble(secondNum)); break;
             //   case (int)MathOperations.Sqrt: result = (int)Math.Sqrt(Convert.ToDouble(firstNum)); break;
                */
            }
         //   DisplayTextBox.Text = result.ToString();
        }

        private void CEButton_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = "0";
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = "0";
            resultValue = 0.0;
            labelCO.Text = "";
         
        }

        private void operator_Click(object sender, EventArgs e)
        {
            var culture = new CultureInfo("en-US");
            Button button = (Button)sender;
            operationPerformed = button.Text;
         resultValue = Double.Parse(DisplayTextBox.Text);
            labelCO.Text =  operationPerformed;
            isOperationPerfomed = true;
        }

      
    }
}

