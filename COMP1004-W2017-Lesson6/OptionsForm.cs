using System;
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
    /// <summary>
    /// Options form controls all the optons for the calculator form
    /// </summary>
    public partial class OptionsForm : Form
    {
        /// <summary>
        /// Consutructor++++++++++++++++++++++===++++
        /// </summary>
        // Inastance variable
        //private String _calculatorLayout;
        //private bool _isSquareActive;
        //private bool _hasExponent;

        public OptionsForm()
        {
            InitializeComponent();
        }


        public String CalculatorLayout { get; set; }

        public int isSquareRootActive { get; set; }

        public int IsExponentActive { get; set; }

        public CalculatorForm PreviousForm { get; set; }

        //{
        //    get
        //    {
        //        return this._calculatorLayout;
        //    }

        //    set
        //    {
        //        this._calculatorLayout = value;
        //    }
        //}

        // PRIVATE METHODS++++++++++++++++++++++++++++
        // EVENT HANDLERS+++++++++++++++++++++++++++++

        /// <summary>
        /// CancelButton_Click enevt handler
        /// </summary>

        private void _cancelButton_Click(object sender, EventArgs e)
        {
            this.PreviousForm.CalculatorFormLayout = this.CalculatorLayout;
            this.Close();
        }

        /// <summary>
        /// AcceptButton_click event handlers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void _acceptButton_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        /// <summary>
        /// FontButton_click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _fontButton_Click(object sender, EventArgs e)
        {
            // Show font dialog result
            CalculatorFontDialog.ShowDialog();
        }

        private void _calculatorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton calculatorRadioButton = sender as RadioButton;
            this.CalculatorLayout = calculatorRadioButton.Text;
            Debug.WriteLine(this.CalculatorLayout);
        }
    }
}

