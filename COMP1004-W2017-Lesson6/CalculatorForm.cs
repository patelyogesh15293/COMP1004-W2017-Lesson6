﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace COMP1004_W2017_Lesson6
{
    public partial class CalculatorForm : Form
    {
        //3. reference previous created form
        public Form previousForm;

        // PRIVATE INSTANCE VARIABLES
        private string _operand1;
        private string _operand2;
        private bool _isCalculatorClear;
        private string _calculatorFormLayout;

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// Default Constructor
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();

            this._clearCalculator();
            // AA baki rai gayu
            //this.CalculatorFormLayout();
        }

        //public properties++++++++++++++++++++++
        public string CalculatorFormLayout
        {
            get
            {
                return this._calculatorFormLayout;
            }
            set
            {
                this._calculatorFormLayout = value;
                Debug.WriteLine("Calculator Form Changed");

            }

        }

        /// <summary>
        /// This method clears the calculator app and resets the variables
        /// </summary>
        private void _clearCalculator()
        {
            this._operand1 = "";
            this._operand2 = "";
            this._isCalculatorClear = true;
            ResultTextBox.Text = "0";
        }


        /// <summary>
        /// Event Handler for all Calculator Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            Button CalculatorButton = sender as Button;

            switch (CalculatorButton.Tag.ToString())
            {
                case "Operand":
                    if (this._isCalculatorClear)
                    {
                        ResultTextBox.Text = CalculatorButton.Text;
                        this._isCalculatorClear = false;
                    }
                    else
                    {
                        ResultTextBox.Text += CalculatorButton.Text;
                    }
                    break;
                case "Operator":
                    break;
                case "Other":
                    break;
            }
        }

        private void CalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.previousForm.Close();
                //this.Show();
            }
            else
            {
                // This should exit the application
                e.Cancel = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.previousForm.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1.Create a new about form
            AboutForm aboutForm = new AboutForm();

            //2. show  the about form eith showdialog (a modal method to display the form)
            aboutForm.ShowDialog();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a dialog result container
            DialogResult result;

            //1. Create a new options form
            OptionsForm myOptionsForm = new OptionsForm();

            //2. set a reference to previous
            myOptionsForm.PreviousForm = this;

            myOptionsForm.CalculatorLayout = this.CalculatorFormLayout;

            //3. show  the options form eith showdialog (a modal method to display the form)
            result = myOptionsForm.ShowDialog();

            Debug.WriteLine(result.ToString());
        }
    }
}
