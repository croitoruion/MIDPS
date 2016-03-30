using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

 
namespace CalculatorCsharp
{
  /*
    class RoundButton : Button
    {
        protected override void OnResize(EventArgs e)
        {
            using (var path = new GraphicsPath())
            {
                path.AddEllipse(new Rectangle(2, 2, this.Width - 5, this.Height - 5));
                this.Region = new Region(path);
            }
            base.OnResize(e);
        }
    }*/
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private decimal firstNum = 0.0m;
        private decimal secondNum = 0.0m;
        private decimal result = 0.0m;
        private int operatorType = (int)MathOperations.NoOperator;

        public enum MathOperations 
        {
            NoOperator = 0,
            Add= 1,
            Minus =2,
            Divide =3,
            Multiply =4,
            Pow =5,
         //   Sq5rt=6,
        }



        private void DigitBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (DisplayTextBox.Text == "0")
            {
                DisplayTextBox.Clear();
            }
            DisplayTextBox.Text +=  btn.Tag;
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (!DisplayTextBox.Text.Contains('.'))
            {
                DisplayTextBox.Text += ".";
            }
        }

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

        private void PlusButton_Click(object sender, EventArgs e)
        {
            Save((int)MathOperations.Add);
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            Save((int)MathOperations.Minus);
        }
        private void Save(int operation)
        {
            operatorType = operation;
            firstNum = Convert.ToDecimal(DisplayTextBox.Text);
            DisplayTextBox.Text = "0";
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            Save((int)MathOperations.Divide);
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            Save((int)MathOperations.Multiply);
        }

        private void SqrtButton_Click(object sender, EventArgs e)
        {
            double k;
            k = Convert.ToDouble(DisplayTextBox.Text);
            DisplayTextBox.Text = Convert.ToString(Math.Sqrt(k));
          //  Save((int)MathOperations.Sqrt);
        }

        private void PowButton_Click(object sender, EventArgs e)
        {
            Save((int)MathOperations.Pow);
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            secondNum = Convert.ToDecimal(DisplayTextBox.Text);
            switch (operatorType)
            {
                case (int)MathOperations.Add: result = firstNum + secondNum; break;
                case (int)MathOperations.Minus: result = firstNum - secondNum; break;
                case (int)MathOperations.Divide: result = firstNum / secondNum; break;
                case (int)MathOperations.Multiply: result = firstNum * secondNum; break;
                case (int)MathOperations.Pow: result = (int)Math.Pow(Convert.ToDouble(firstNum),Convert.ToDouble(secondNum)); break;
             //   case (int)MathOperations.Sqrt: result = (int)Math.Sqrt(Convert.ToDouble(firstNum)); break;

            }
            DisplayTextBox.Text = result.ToString();
        }

        private void CEButton_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = "0";
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = "0";
            firstNum = 0.0m;
            secondNum = 0.0m;
            result = 0;
            operatorType = (int)MathOperations.NoOperator;
        }
    }
}

