using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hunt_Mortgage
{
    public partial class MorgageCalculator : Form
    {
        public MorgageCalculator()
        {
            InitializeComponent();
            //reset the form to orginal state
            FinNumLab.Visible = false;
            monpatLab.Visible = false;
            dobOTxtBx.Visible = false;
            sBadNum.Visible = false;
            RB30.Checked = true;
            dobIntrCombo.SelectedIndex = 0;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }

        private void RBO_CheckedChanged(object sender, EventArgs e)
        {
            //allow the user to see the "Other..." text box
            if (RBO.Checked == true)
            {
                RBO.Text = "Other";
                dobOTxtBx.Visible = true;
            }
            //return to normal
            else
            {
                RBO.Text = "Other...";
                dobOTxtBx.Visible = false;
            }
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            //tryparse wasn't working for me so i used this from here. it makes a boolean from tryparse so i can use it in an if statement.
            //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/how-to-determine-whether-a-string-represents-a-numeric-value

            double i = 0;
            bool cont = true;
            bool isNum = double.TryParse(dobPncTxtBx.Text, out i);
            while (cont)
            {
                if (isNum == true && cont)
                {
                    //remove "BadNum" line if previously triggered
                    sBadNum.Visible = false;

                    //create numeric variables for the three user inputs
                    //base price
                    double p = double.Parse(dobPncTxtBx.Text);
                    //term
                    double t = 30;
                    //intrest rate
                    double intr = double.Parse(dobIntrCombo.Text);
                    //final price
                    double finprice = 0;

                    //determine the term of the mortgage as a variable
                    if (RB15.Checked == true)
                    {
                        t = 15;
                    }
                    if (RB30.Checked == true)
                    {
                        t = 30;
                    }
                    if (RBO.Checked == true)
                    {
                        t = double.Parse(dobOTxtBx.Text);
                    }

                    //Monthly Payment = P[r/n]/[1-(1+[r/n])^-nt]
                    //P = principal / loan amount
                    //r = annual interest rate as a decimal
                    //n = number of payments made a year (always 12 because monthly)
                    //t = term of the loan

                    //convert intrest to a better decimal
                    double r = intr / 100;
                    double nt = 12 * t;

                    //run the equation
                    double upper = p * (r / 12);
                    double lowpart = 1 + (r / 12);
                    finprice = 25 / (1 - (Math.Pow(lowpart, -nt)));

                    //print payment
                    FinNumLab.Text = (finprice.ToString("C2"));
                    monpatLab.Visible = true;
                    FinNumLab.Visible = true;

                    cont = false;

                    break;
                }
                //ask user to give numbers only
                else
                {
                    sBadNum.Visible = true;
                    monpatLab.Visible = false;
                    FinNumLab.Visible = false;
                }
            }
        }

        private void RstBtn_Click(object sender, EventArgs e)
        {
            //reset the form to orginal state
            //dobPncTxtBx.Text = null;
            //RB30.Checked = true;
            //RBO.Text = "Other...";
            //dobOTxtBx.Text = null;
            //dobOTxtBx.Visible = false;
            //dobIntrCombo.SelectedIndex = 0;

            //the CalcBtn_clicked method wouold not run multiple times, but would always run properly the first time, so i had to make this as a work around

            Application.Restart();
        }
    }
}
