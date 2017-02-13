using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_Lesson6
{
    public partial class AbilityForm : Form
    {
        // create a new random object
        Random random = new Random();
        private int _health = 0;
        private int _karma = 0;
        private List<TextBox> _abilities;

        public AbilityForm()
        {
            InitializeComponent();

            // Initialize List (empty container)
            this._abilities = new List<TextBox>();
            this._intializeAbilities();
        }

        public SplashForm PreviousForm = new SplashForm();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void KarmaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method generate a number between 5 to 50
        /// </summary>
        /// <returns>
        /// This method return a number
        /// </returns>

        private int _roll5d10()
        {
            int result = 0;

            for (int count = 0; count < 5; count++)
            {
                result += random.Next(1, 11);
            }
            return result;
        }

        private void _intializeAbilities()
        {
            this._abilities.Add(FightingTextBox);
            this._abilities.Add(AgilityTextBox);
            this._abilities.Add(StrengthTextBox);
            this._abilities.Add(EnduranceTextBox);
            this._abilities.Add(ReasonTextBox);
            this._abilities.Add(IntutionTextBox);
            this._abilities.Add(PsycheTextBox);

        }
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            this._health = 0;
            this._karma = 0;
            
            // iterates through the textbox list
            for (int abilities = 0; abilities < this._abilities.Count; abilities++)
            {
                // roll 5d10 and assign the value
                int currentRoll = this._roll5d10();

                //if my abilities is physical
                if (abilities < 4)
                {
                    this._health += currentRoll;
                }
                else //otherwise add to karma
                {
                    this._karma += currentRoll;
                }
                
                // assign the current roll to the current abilities
                this._abilities[abilities].Text = currentRoll.ToString();
            }
            //tempValue = this._roll5d10();
            //this._health = tempValue;
            //FightingTextBox.Text = tempValue.ToString();
            HealthTextBox.Text = this._health.ToString();
            KarmaTextBox.Text = this._karma.ToString();
        }
        
    }
}
    
