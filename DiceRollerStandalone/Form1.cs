using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DiceRollerStandalone
{
    public partial class Form1 : Form
    {
        //Global Vars
        //number of dice types rolled per calculation, for use with sum total
        int NumTypesRolled;
        //Total quantity declared per dimension
        int numD4;
        int numD6;
        int numD8;
        int numD10;
        int numD12;
        int numD20;
        int numDquant;
        //dimensions declared for custom die
        int numDcustomDimension;
        //bool for if user is using custom dice; unused
        //bool CustomUsed = false;

        //store default values for the custom die textboxes
        string Default1 = "Custom Dimension";
        string Default2 = "Custom Quantity";

        int SumTotal;

        /*bool rolled = false;
        bool FinishedRolls = false;*/

        public Form1()
        {
            InitializeComponent();
        }

        //Randomize function for rolling dice and printing output both
        private void Randomize(int quant, int dimen)
        {
            //set up a sub total for private use
            int subTotal = 0;
            NumTypesRolled += 1;

            //Add D followed by chosen dimension to prefix roll in text box.
            //Postfix incrementation on dimen so max value of roll is not truncated
            //but correct value is displayed on d, incrementation is applied after this instruction
            //now using string builder instead of textbox+=string to increase efficiency
            StringBuilder sbRolls = new StringBuilder("d" + dimen++.ToString() + ": ");

            //New Random number, created every Randomize(), placed right before for-loop to work properly
            Random r = new Random();

            //for loop per quantity of rolls with that die
            for (int i = 0; i < quant; i++)
            {//store rolled number in private int for reference
                int rolledNum = (r.Next(1, dimen));
                //output to textbox a random number from one to max dimensions available
                sbRolls.Append(rolledNum);
                //add to sub total
                subTotal += rolledNum;
                //only add plus if there's another roll coming
                if (i < (quant - 1))
                {
                    sbRolls.Append("+");
                }
            }
            if (quant > 1)
            {
                //add equals sign and sub total
                sbRolls.Append("=" + subTotal);
            }
            //Add new line after rolling all of one dice type
            sbRolls.Append("\r\n");
            txtOutput.Text += sbRolls;
            SumTotal += subTotal;
        }

        //Boolean Validation function to check each number before rolling them
        //Similar to int.TryParse and even uses it, but prevents the number from being a negative whole number
        bool Validate(string input)
        {
            //check if supplied number in string format is parsable
            if (int.TryParse(input, out int result))
            {//check if the number is not a negative or a zero to be valid
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
            /*TODO:
            Implement entire program as a tab in DMHelper program
            */

            //Reset sum total and number of types of dice rolled each button press
            SumTotal = 0;
            NumTypesRolled = 0;

            //add a new line to seperate rolls if rolls textbox not empty
            if (txtOutput.Text.Length > 0)
            {
                txtOutput.Text += "\r\n";
            }

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
            //numDiceTotal = (numD4 + numD6 + numD8 + numD10 + numD12 + numD20 + numDquant);

            //If rolling two or more dice display a sum total
            if (NumTypesRolled >= 2)
            {
                txtOutput.Text += "Sum Total=" + SumTotal + "\r\n";
            }

        }

        private void txtD4_TextChanged(object sender, EventArgs e)
        {

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
        //For both custom text fields, on mouse click, if set to defaul text value, clear it for immediate typing from user
        private void txtDdimen_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtDdimen.Text == Default1)
            {
                txtDdimen.Text = "";
            }
        }

        private void txtDquant_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtDquant.Text == Default2)
            {
                txtDquant.Text = "";
            }
        }
        //For both custom text fields, on focus leave, tell them what they did wrong and reset to default, or if nothing was entered, reset to default
        private void txtDdimen_Leave(object sender, EventArgs e)
        {
            if (Validate(txtDdimen.Text) != true && txtDdimen.Text != "")
            {
                MessageBox.Show("Make sure your custom dice dimensions (sides) is not a negative, and higher than zero");
                txtDdimen.Text = Default1;
            }
            else if (txtDdimen.Text == "")
            {
                txtDdimen.Text = Default1;
            }
        }

        private void txtDquant_Leave(object sender, EventArgs e)
        {
            if (Validate(txtDquant.Text) != true && txtDquant.Text != "")
            {
                MessageBox.Show("Make sure your custom dice quantity is not a negative, and higher than zero");
                txtDquant.Text = Default2;
            }
            else if (txtDquant.Text == "")
            {
                txtDquant.Text = Default2;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtD4.Text = "";
            txtD6.Text = "";
            txtD8.Text = "";
            txtD10.Text = "";
            txtD12.Text = "";
            txtD20.Text = "";
            txtDdimen.Text = Default1;
            txtDquant.Text = Default2;
            //no longer clears output, commented out
            //txtOutput.Text = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Text (*.txt)|*.txt";
            if (System.Windows.Forms.DialogResult.OK == savefile.ShowDialog())
            {
                //try to save file at path chosen in save file dialog
                try
                {
                    string filePath = savefile.FileName;
                    File.WriteAllText(filePath, txtOutput.Text);
                    MessageBox.Show("File Written to: " + filePath);
                }
                //throw error message for every exception
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] inputs = { txtD4.Text, txtD6.Text, txtD8.Text, txtD10.Text, txtD12.Text, txtD20.Text, txtDquant.Text, txtDdimen.Text };
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Text (*.txt)|*.txt";
            if (System.Windows.Forms.DialogResult.OK == savefile.ShowDialog())
            {
                //try to save file at path chosen in save file dialog
                try
                {
                    string filePath = savefile.FileName;
                    System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(filePath);
                    foreach (string item in inputs)
                    {
                        SaveFile.WriteLine(item);
                    }
                    MessageBox.Show("File Written to: " + filePath);
                }
                //throw error message for every exception
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}
