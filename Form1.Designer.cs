
namespace Giles_Lab6
{
    partial class FrmTranslator
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.lblTranslation = new System.Windows.Forms.Label();
            this.rbLatin = new System.Windows.Forms.RadioButton();
            this.rbGreek = new System.Windows.Forms.RadioButton();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter English text here:";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(15, 46);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(304, 100);
            this.tbInput.TabIndex = 2;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(15, 222);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(304, 100);
            this.tbOutput.TabIndex = 3;
            // 
            // lblTranslation
            // 
            this.lblTranslation.AutoSize = true;
            this.lblTranslation.Location = new System.Drawing.Point(12, 196);
            this.lblTranslation.Name = "lblTranslation";
            this.lblTranslation.Size = new System.Drawing.Size(10, 13);
            this.lblTranslation.TabIndex = 4;
            this.lblTranslation.Text = " ";
            // 
            // rbLatin
            // 
            this.rbLatin.AutoSize = true;
            this.rbLatin.Location = new System.Drawing.Point(15, 163);
            this.rbLatin.Name = "rbLatin";
            this.rbLatin.Size = new System.Drawing.Size(66, 17);
            this.rbLatin.TabIndex = 5;
            this.rbLatin.TabStop = true;
            this.rbLatin.Text = "Pig Latin";
            this.rbLatin.UseVisualStyleBackColor = true;
            this.rbLatin.CheckedChanged += new System.EventHandler(this.rbLatin_CheckedChanged);
            // 
            // rbGreek
            // 
            this.rbGreek.AutoSize = true;
            this.rbGreek.Location = new System.Drawing.Point(107, 163);
            this.rbGreek.Name = "rbGreek";
            this.rbGreek.Size = new System.Drawing.Size(72, 17);
            this.rbGreek.TabIndex = 6;
            this.rbGreek.TabStop = true;
            this.rbGreek.Text = "Pig Greek";
            this.rbGreek.UseVisualStyleBackColor = true;
            this.rbGreek.CheckedChanged += new System.EventHandler(this.rbGreek_CheckedChanged);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(15, 346);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 7;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(96, 346);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(266, 346);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 384);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.rbGreek);
            this.Controls.Add(this.rbLatin);
            this.Controls.Add(this.lblTranslation);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.label1);
            this.Name = "FrmTranslator";
            this.Text = "Pig Latin & Greek Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label lblTranslation;
        private System.Windows.Forms.RadioButton rbLatin;
        private System.Windows.Forms.RadioButton rbGreek;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

