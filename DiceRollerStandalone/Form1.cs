using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRollerStandalone
{
    public partial class Form1 : Form
    {
        //Global Vars
        //Total quantity of dice to roll for every chosen dimension
        int numDiceTotal;
        //Total quantity declared per dimension
        int numD4;
        int numD6;
        int numD8;
        int numD10;
        int numD12;
        int numD20;
        int numDcustomDimension;
        int numDquant;

        public Form1()
        {
            InitializeComponent();
        }

        void Randomize(int quant, int dimen)
        {
            //Add D followed by chosen dimension to prefix roll in text box
            //Before increment so correct value is displayed
            txtOutput.Text += ("D" + dimen.ToString() + ": ");

            //increment chosen dimension so max value of roll is not truncated
            dimen++;

            Random r = new Random();

            //for loop per quantity of rolls with that die
            for (int i = 0; i < quant; i ++)
            {
                txtOutput.Text += (r.Next(1, dimen) + ", ");
            }

            txtOutput.Text += "\r\n";
        }

        //Boolean Validation function to check each number before rolling them
        //Similar to int.TryParse and even uses it, but prevents the number from being a negative
        bool Validate(string input)
        {
            //check if supplied number in string format is parsable
            if (int.TryParse(input, out int result))
            {
                if (result >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            /*TODO: make a for loop to go through each quanity selected
            Make another for loop inside that for loop, to randomize the dimensions selected
            Implement entire program as a tab in DMHelper program
            */

            //Validate Every Input box to determine what is being rolled, then roll each valid option
            if (Validate(txtD4.Text))
            {
                numD4 = int.Parse(txtD4.Text);
                Randomize(numD4, 4);
            }
            if (Validate(txtD6.Text))
            {
                numD6 = int.Parse(txtD6.Text);
                Randomize(numD6, 6);
            }
            if (Validate(txtD8.Text))
            {
                numD8 = int.Parse(txtD8.Text);
                Randomize(numD8, 8);
            }
            if (Validate(txtD10.Text))
            {
                numD10 = int.Parse(txtD10.Text);
                Randomize(numD10, 10);
            }
            if (Validate(txtD12.Text))
            {
                numD12 = int.Parse(txtD12.Text);
                Randomize(numD12, 12);
            }
            if (Validate(txtD20.Text))
            {
                numD20 = int.Parse(txtD20.Text);
                Randomize(numD20, 20);
            }
            //validate both dimension, and then quantity for custom dice before rolling it
            if (Validate(txtDdimen.Text))
            {
                if (Validate(txtDquant.Text))
                {
                    numDcustomDimension = int.Parse(txtDdimen.Text);
                    numDquant = int.Parse(txtDquant.Text);
                    Randomize(numDquant, numDcustomDimension);
                }
            }

            //Initialize total number of selected dice in every quantity
            numDiceTotal = (numD4 + numD6 + numD8 + numD10 + numD12 + numD20);

        }

        private void txtD4_TextChanged(object sender, EventArgs e)
        {
           /* if (txtD4.Text != "")
            {
                numD4 = int.Parse(txtD4.Text);
            }*/
        }

        private void txtD6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtD8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtD10_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtD12_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtD20_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDdimen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDquant_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
