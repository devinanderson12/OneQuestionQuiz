namespace OneQuestionQuiz
{
    partial class frmOneQuestionQuiz
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
            this.grpRadiobuttons = new System.Windows.Forms.GroupBox();
            this.rdoNO = new System.Windows.Forms.RadioButton();
            this.rdoYES = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpRadiobuttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "was devin born in winnipeg?";
            // 
            // grpRadiobuttons
            // 
            this.grpRadiobuttons.Controls.Add(this.rdoNO);
            this.grpRadiobuttons.Controls.Add(this.rdoYES);
            this.grpRadiobuttons.Location = new System.Drawing.Point(30, 48);
            this.grpRadiobuttons.Name = "grpRadiobuttons";
            this.grpRadiobuttons.Size = new System.Drawing.Size(200, 100);
            this.grpRadiobuttons.TabIndex = 1;
            this.grpRadiobuttons.TabStop = false;
            // 
            // rdoNO
            // 
            this.rdoNO.AutoSize = true;
            this.rdoNO.Location = new System.Drawing.Point(110, 20);
            this.rdoNO.Name = "rdoNO";
            this.rdoNO.Size = new System.Drawing.Size(37, 17);
            this.rdoNO.TabIndex = 1;
            this.rdoNO.TabStop = true;
            this.rdoNO.Text = "no";
            this.rdoNO.UseVisualStyleBackColor = true;
            this.rdoNO.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdoYES
            // 
            this.rdoYES.AutoSize = true;
            this.rdoYES.Location = new System.Drawing.Point(7, 20);
            this.rdoYES.Name = "rdoYES";
            this.rdoYES.Size = new System.Drawing.Size(41, 17);
            this.rdoYES.TabIndex = 0;
            this.rdoYES.TabStop = true;
            this.rdoYES.Text = "yes";
            this.rdoYES.UseVisualStyleBackColor = true;
            this.rdoYES.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(30, 155);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 2;
            // 
            // frmOneQuestionQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.grpRadiobuttons);
            this.Controls.Add(this.label1);
            this.Name = "frmOneQuestionQuiz";
            this.Text = "OneQuestionQuiz";
            this.grpRadiobuttons.ResumeLayout(false);
            this.grpRadiobuttons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpRadiobuttons;
        private System.Windows.Forms.RadioButton rdoNO;
        private System.Windows.Forms.RadioButton rdoYES;
        private System.Windows.Forms.Label lblResult;
    }
}

