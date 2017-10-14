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
        int numDcustom;

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
        bool Validate(int quant)
        {
            if (quant >= 1)
            {
                if (int.TryParse(quant.ToString(), out int result))
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

            //Initialize a quantity for every dimension available            

            if (txtD4.Text != "")
            {
                numD4 = int.Parse(txtD4.Text);
            }

            if (txtD6.Text != "")
            {
                numD6 = int.Parse(txtD6.Text);
            }
            if (txtD8.Text != "")
            {
                numD8 = int.Parse(txtD8.Text);
            }
            if (txtD10.Text != "")
            {
                numD10 = int.Parse(txtD10.Text);
            }
            if (txtD12.Text != "")
            {
                numD12 = int.Parse(txtD12.Text);
            }
            if (txtD20.Text != "")
            {
                numD20 = int.Parse(txtD20.Text);
            }

            //Initialize total number of selected dice in every quantity
            numDiceTotal = (numD4 + numD6 + numD8 + numD10 + numD12 + numD20);

  
                if (Validate(numD4))
                {
                    Randomize(numD4, 4);
                }

                if (Validate(numD6))
                {
                    Randomize(numD6, 6);
                }

                if (Validate(numD8))
                {
                    Randomize(numD8, 8);
                }

                if (Validate(numD10))
                {
                    Randomize(numD10, 10);
                }

                if (Validate(numD12))
                {
                    Randomize(numD12, 12);
                }

                if (Validate(numD20))
                {
                    Randomize(numD20, 20);
                }


            //for loop to perform per dimension per quantity


            //custom roll for loop per quantity

            //randomize per dimension 
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
    }
}
