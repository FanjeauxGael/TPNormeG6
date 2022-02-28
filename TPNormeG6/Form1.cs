using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPNormeG6
{
    public partial class Form1 : Form
    {
        private double Result;
        private double Value1;
        private double Value2;
        private double Tmp;
        private String Operator;
        private bool IsZeroVirgule;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Value1 = new double();
            Value2 = new double();
            Operator = null;
            Result = new double();
            affichage.Text = Convert.ToString(Value1);
            IsZeroVirgule = false;

        }

        private void button(object sender, EventArgs e)
        {
            Button SenderButton = (Button)sender;
            if (affichage.Text == "0" && IsZeroVirgule == false || Tmp == Result && IsZeroVirgule == false)
            {

                if (SenderButton.Text == ",")
                {
                    affichage.Text = "0" + SenderButton.Text;
                    Tmp = Convert.ToDouble("0" + SenderButton.Text);
                    IsZeroVirgule = true;
                }
                else
                {
                    affichage.Text = SenderButton.Text;
                    Tmp = Convert.ToDouble(SenderButton.Text);
                }

            }
            else
            {
                affichage.Text = affichage.Text + SenderButton.Text;
                Tmp = Convert.ToDouble(affichage.Text);
            }


        }

        private void buttonOpe(object sender, EventArgs e)
        {
            Button SenderButton = (Button)sender;
            Operator = SenderButton.Text;
            Value1 = Convert.ToDouble(affichage.Text);
            affichage.Text = Convert.ToString(Value2);
        }

        private void buttonEqual(object sender, EventArgs e)
        {
            Value2 = Convert.ToDouble(affichage.Text);
            switch (Operator)
            {
                case "+":
                    Result = Value1 + Value2;
                    break;
                case "-":
                    Result = Value1 - Value2;
                    break;
                case "/":
                    Result = Value1 / Value2;
                    break;
                case "x":
                    Result = Value1 * Value2;
                    break;
                default:
                    break;

            }
            affichage.Text = Convert.ToString(Result);
            Value1 = Result;
            Value2 = 0;
            Tmp = Result;
            IsZeroVirgule = false;

        }
    }
}
