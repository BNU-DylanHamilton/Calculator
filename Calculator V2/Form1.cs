﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_V2
{
    public partial class calculatorV2Form : Form
    {
        private double firstNumber, secondNumber;
        private string calculator;

        public calculatorV2Form()
        {
            InitializeComponent();
        }

        private void numberOne(object sender, EventArgs e)
        {
            resultsLabel.Text += "1";
        }

        private void numberTwo(object sender, EventArgs e)
        {
            resultsLabel.Text += "2";
        }

        private void numberThree(object sender, EventArgs e)
        {
            resultsLabel.Text += "3";
        }

        private void numberFour(object sender, EventArgs e)
        {
            resultsLabel.Text += "4";
        }

        private void numberFive(object sender, EventArgs e)
        {
            resultsLabel.Text += "5";
        }

        private void numberSix(object sender, EventArgs e)
        {
            resultsLabel.Text += "6";
        }

        private void numberSeven(object sender, EventArgs e)
        {
            resultsLabel.Text += "7";
        }

        private void numberEight(object sender, EventArgs e)
        {
            resultsLabel.Text += "8";
        }

        private void numberNine(object sender, EventArgs e)
        {
            resultsLabel.Text += "9";
        }

        private void numberZero(object sender, EventArgs e)
        {
            resultsLabel.Text += "0";
        }

        /// <summary>
        /// This sets the calculation, saves the current
        /// number on screen and clears the text.
        /// </summary>
        private void addingNumbers(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(resultsLabel.Text);
            resultsLabel.Text = "";
            calculator = "+";
        }

        /// <summary>
        /// This determines which calculation to do 
        /// depending on which button was pressed.
        /// </summary>
        private void calculationOutcome(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(resultsLabel.Text);

            if(calculator == "+")
            {
                resultsLabel.Text = (firstNumber + secondNumber).ToString();
            }
            else if(calculator == "-")
            {
                resultsLabel.Text = (firstNumber - secondNumber).ToString();
            }
            else if(calculator == "x")
            {
                resultsLabel.Text = (firstNumber * secondNumber).ToString();
            }
            else if(calculator == "/")
            {
                if(secondNumber == 0)
                {
                    MessageBox.Show("You should NOT divide by ZERO");
                }
                else
                {
                    resultsLabel.Text = (firstNumber / secondNumber).ToString();
                }
                
            }
            else
            {
                resultsLabel.Text = (Math.Pow(firstNumber,secondNumber)).ToString();
            }
        }

        /// <summary>
        /// This sets the calculation, saves the current
        /// number on screen and clears the text.
        /// </summary>
        private void subtractingNumbers(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(resultsLabel.Text);
            resultsLabel.Text = "";
            calculator = "-";
        }

        /// <summary>
        /// This sets the calculation, saves the current
        /// number on screen and clears the text.
        /// </summary>
        private void multiplyingNumbers(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(resultsLabel.Text);
            resultsLabel.Text = "";
            calculator = "x";
        }

        /// <summary>
        /// This sets the calculation, saves the current
        /// number on screen and clears the text.
        /// </summary>
        private void dividingNumbers(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(resultsLabel.Text);
            resultsLabel.Text = "";
            calculator = "/";
        }

        /// <summary>
        /// This sets the calculation, saves the current
        /// number on screen and clears the text.
        /// </summary>
        private void powerNumbers(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(resultsLabel.Text);
            resultsLabel.Text = "";
            calculator = "^";
        }

        /// <summary>
        /// This opens a start up screen before the actual
        /// program and once clicked, has a 2 second delay
        /// before the main program pops up.
        /// </summary>
        private void startScreen(object sender, EventArgs e)
        {
            startUpSplashScreen SScreen = new startUpSplashScreen();
            SScreen.ShowDialog();
            System.Threading.Thread.Sleep(2000);
            SScreen.Close();
        }

        private void clearLabel(object sender, EventArgs e)
        {
            resultsLabel.Text = "";
        }
    }
}
