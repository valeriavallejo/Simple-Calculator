using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Calculator
{
    public partial class calculator : Form
    {
        private decimal firstValue = 0.0m;
        private decimal secondValue = 0.0m;
        public decimal result = 0.0m;
        private string operators = "+";

        public calculator()
        {
            InitializeComponent();
        }

        private void TypeButton(String number) {
            if (TextBox.Text == "0")
            {
                TextBox.Text = number;
            }
            else
            {
                TextBox.Text += number;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "%";
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "0";
            }
            else {
                TextBox.Text += "0";
            }
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!TextBox.Text.Contains("."))
            {
                TextBox.Text += ".";
            }
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            TypeButton("1");
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            TypeButton("2");
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            TypeButton("3");
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            TypeButton("4");
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            TypeButton("5");
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            TypeButton("6");
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            TypeButton("7");
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            TypeButton("8");
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            TypeButton("9");
        }

        private void SubtractBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "-";
        }

        private void SignBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Contains("-"))
            {
                TextBox.Text = TextBox.Text.Trim('-');
            }
            else
            {
                TextBox.Text = "-" + TextBox.Text;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "+";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "x";
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "/";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operators) {
                case "+":
                    secondValue = decimal.Parse(TextBox.Text);
                    result = firstValue + secondValue;
                    TextBox.Text = result.ToString();
                    break;
                case "-":
                    secondValue = decimal.Parse(TextBox.Text);
                    result = firstValue - secondValue;
                    TextBox.Text = result.ToString();
                    break;
                case "x":
                    secondValue = decimal.Parse(TextBox.Text);
                    result = firstValue * secondValue;
                    TextBox.Text = result.ToString();
                    break;
                case "/":
                    secondValue = decimal.Parse(TextBox.Text);
                    result = firstValue / secondValue;
                    TextBox.Text = result.ToString();
                    break;
                case "%":
                    secondValue = decimal.Parse(TextBox.Text);
                    result = firstValue % secondValue;
                    TextBox.Text = result.ToString();
                    break;
                default:
                    break;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            TextBox.Text = "0";
        }
    }
}
