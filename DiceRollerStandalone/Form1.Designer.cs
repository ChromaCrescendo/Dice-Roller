namespace DiceRollerStandalone
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtD4 = new System.Windows.Forms.TextBox();
            this.txtD6 = new System.Windows.Forms.TextBox();
            this.txtD8 = new System.Windows.Forms.TextBox();
            this.txtD10 = new System.Windows.Forms.TextBox();
            this.txtD12 = new System.Windows.Forms.TextBox();
            this.txtD20 = new System.Windows.Forms.TextBox();
            this.txtDquant = new System.Windows.Forms.TextBox();
            this.txtDdimen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "d4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "d6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "d8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "d10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "d12";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "d20";
            // 
            // txtD4
            // 
            this.txtD4.Location = new System.Drawing.Point(123, 52);
            this.txtD4.Name = "txtD4";
            this.txtD4.Size = new System.Drawing.Size(100, 20);
            this.txtD4.TabIndex = 10;
            this.txtD4.TextChanged += new System.EventHandler(this.txtD4_TextChanged);
            // 
            // txtD6
            // 
            this.txtD6.Location = new System.Drawing.Point(124, 87);
            this.txtD6.Name = "txtD6";
            this.txtD6.Size = new System.Drawing.Size(100, 20);
            this.txtD6.TabIndex = 11;
            this.txtD6.TextChanged += new System.EventHandler(this.txtD6_TextChanged);
            // 
            // txtD8
            // 
            this.txtD8.Location = new System.Drawing.Point(123, 124);
            this.txtD8.Name = "txtD8";
            this.txtD8.Size = new System.Drawing.Size(100, 20);
            this.txtD8.TabIndex = 12;
            this.txtD8.TextChanged += new System.EventHandler(this.txtD8_TextChanged);
            // 
            // txtD10
            // 
            this.txtD10.Location = new System.Drawing.Point(123, 162);
            this.txtD10.Name = "txtD10";
            this.txtD10.Size = new System.Drawing.Size(100, 20);
            this.txtD10.TabIndex = 13;
            this.txtD10.TextChanged += new System.EventHandler(this.txtD10_TextChanged);
            // 
            // txtD12
            // 
            this.txtD12.Location = new System.Drawing.Point(124, 198);
            this.txtD12.Name = "txtD12";
            this.txtD12.Size = new System.Drawing.Size(100, 20);
            this.txtD12.TabIndex = 14;
            this.txtD12.TextChanged += new System.EventHandler(this.txtD12_TextChanged);
            // 
            // txtD20
            // 
            this.txtD20.Location = new System.Drawing.Point(124, 233);
            this.txtD20.Name = "txtD20";
            this.txtD20.Size = new System.Drawing.Size(100, 20);
            this.txtD20.TabIndex = 15;
            this.txtD20.TextChanged += new System.EventHandler(this.txtD20_TextChanged);
            // 
            // txtDquant
            // 
            this.txtDquant.Location = new System.Drawing.Point(124, 273);
            this.txtDquant.Name = "txtDquant";
            this.txtDquant.Size = new System.Drawing.Size(100, 20);
            this.txtDquant.TabIndex = 16;
            this.txtDquant.Text = "Custom Quantity";
            this.txtDquant.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDquant_MouseClick);
            this.txtDquant.TextChanged += new System.EventHandler(this.txtDquant_TextChanged);
            this.txtDquant.Leave += new System.EventHandler(this.txtDquant_Leave);
            // 
            // txtDdimen
            // 
            this.txtDdimen.Location = new System.Drawing.Point(23, 273);
            this.txtDdimen.Name = "txtDdimen";
            this.txtDdimen.Size = new System.Drawing.Size(95, 20);
            this.txtDdimen.TabIndex = 17;
            this.txtDdimen.Text = "Custom Dimension";
            this.txtDdimen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDdimen_MouseClick);
            this.txtDdimen.TextChanged += new System.EventHandler(this.txtDdimen_TextChanged);
            this.txtDdimen.Leave += new System.EventHandler(this.txtDdimen_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Dimensions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Quantity";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(23, 340);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(319, 209);
            this.txtOutput.TabIndex = 20;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(267, 270);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 21;
            this.btnGen.Text = "CALC";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(267, 231);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "d";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 561);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDdimen);
            this.Controls.Add(this.txtDquant);
            this.Controls.Add(this.txtD20);
            this.Controls.Add(this.txtD12);
            this.Controls.Add(this.txtD10);
            this.Controls.Add(this.txtD8);
            this.Controls.Add(this.txtD6);
            this.Controls.Add(this.txtD4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dice Roller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtD4;
        private System.Windows.Forms.TextBox txtD6;
        private System.Windows.Forms.TextBox txtD8;
        private System.Windows.Forms.TextBox txtD10;
        private System.Windows.Forms.TextBox txtD12;
        private System.Windows.Forms.TextBox txtD20;
        private System.Windows.Forms.TextBox txtDquant;
        private System.Windows.Forms.TextBox txtDdimen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label9;
    }
}

