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

        void ChangeTheme(int themeNum)
        {
            //bool bgImgUsed;
            switch (themeNum)
            {
                //Default theme
                case 0:
                    defaultToolStripMenuItem.Checked = true;
                    darkToolStripMenuItem.Checked = false;
                    whiteToolStripMenuItem.Checked = false;

                    this.BackColor = SystemColors.Control;
                    this.ForeColor = Color.Black;
                    menuStrip1.BackColor = SystemColors.Control;
                    this.BackgroundImage = null;
                    break;
                //Dark marble theme
                case 1:
                    darkToolStripMenuItem.Checked = true;
                    whiteToolStripMenuItem.Checked = false;
                    defaultToolStripMenuItem.Checked = false;

                    menuStrip1.BackColor = Color.Transparent;
                    this.BackgroundImage = global::DiceRollerStandalone.Properties.Resources.black;
                    btnClear.FlatStyle = FlatStyle.Popup;
                    btnGen.FlatStyle = FlatStyle.Popup;
                    break;
                //White Marble theme
                case 2:
                    whiteToolStripMenuItem.Checked = true;
                    defaultToolStripMenuItem.Checked = false;
                    darkToolStripMenuItem.Checked = false;

                    menuStrip1.BackColor = Color.Transparent;
                    btnGen.FlatStyle = FlatStyle.Popup;
                    btnClear.FlatStyle = FlatStyle.Popup;
                    this.BackgroundImage = global::DiceRollerStandalone.Properties.Resources.white;
                    break;
            }
            //waterfall the form1 back color and fore color to other controls
            /*tbPack.ForeColor = Form1.ActiveForm.ForeColor;
            tbPack.BackColor = Form1.ActiveForm.BackColor;
            lbPossibles.ForeColor = Form1.ActiveForm.ForeColor;
            lbPossibles.BackColor = Form1.ActiveForm.BackColor;
            lbDraws.ForeColor = Form1.ActiveForm.ForeColor;
            lbDraws.BackColor = Form1.ActiveForm.BackColor;
            btnPick.ForeColor = Form1.ActiveForm.ForeColor;
            btnPick.BackColor = Form1.ActiveForm.BackColor;
            btnGen.ForeColor = Form1.ActiveForm.ForeColor;
            btnGen.BackColor = Form1.ActiveForm.BackColor;
            toolStrip1.BackColor = SystemColors.Control;
            toolStrip1.ForeColor = Color.Black;*/

                    //If custom font color...(ORIGINAL)
                    /*if (chosenColor != null)
                    {//Ask if the user wants to keep it
                        string keepColor = Prompt.ShowDialog("Would you like to keep your custom font color?", "Keep font color?").ToUpper();

                        if (keepColor == "YES")
                        {//User wants to keep his custom font color
                            rtb.ForeColor = Color.FromName(chosenColor);
                        }
                        else
                        {//User doesn't want to keep custom font color, trash custom color reference
                            chosenColor = null;
                        }
                    }*/
                    //If custom font color...
                    /* if (chosenColor != null)
                     {//Keep the custom font color
                         rtb.ForeColor = Color.FromName(chosenColor);
                     }*/
            }

            //Randomize function for rolling dice and printing output both
            private void Randomize(int quant, int dimen)
        {
            //set up a sub total for private use & add one to number of rolls
            //display sum total if two or more dice types are used
            int subTotal = 0;
            NumTypesRolled += 1;

            //Add D followed by chosen dimension to prefix roll in text box.
            //Postfix incrementation on dimen so max value of roll is not truncated
            //but correct value is displayed on d, incrementation is applied after this instruction
            //now using string builder instead of textbox+=string to increase efficiency
            StringBuilder sbRolls = new StringBuilder("d" + dimen++ + ": ");

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

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeTheme(2);
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
                    //write all text function writes a single string to an output file
                    //write all lines function writes an array to an output file, use with the textboxes for custom inputs
                    File.WriteAllText(filePath, txtOutput.Text, Encoding.UTF8);
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

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme(0);
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme(1);
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme(2);
        }
    }
}
