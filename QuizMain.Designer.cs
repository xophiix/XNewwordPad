namespace XNewwordPadCS
{
    partial class QuizMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizMain));
            this.nextBtn = new System.Windows.Forms.Button();
            this.wordTestLabel = new System.Windows.Forms.Label();
            this.wordItemTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.radioButtonOption1 = new System.Windows.Forms.RadioButton();
            this.radioButtonOption2 = new System.Windows.Forms.RadioButton();
            this.radioButtonOption3 = new System.Windows.Forms.RadioButton();
            this.radioButtonOption4 = new System.Windows.Forms.RadioButton();
            this.labelProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(133, 252);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 0;
            this.nextBtn.Text = "next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // wordTestLabel
            // 
            this.wordTestLabel.AutoSize = true;
            this.wordTestLabel.Location = new System.Drawing.Point(12, 13);
            this.wordTestLabel.Name = "wordTestLabel";
            this.wordTestLabel.Size = new System.Drawing.Size(29, 12);
            this.wordTestLabel.TabIndex = 2;
            this.wordTestLabel.Text = "Word";
            // 
            // radioButtonOption1
            // 
            this.radioButtonOption1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonOption1.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonOption1.Location = new System.Drawing.Point(14, 46);
            this.radioButtonOption1.Name = "radioButtonOption1";
            this.radioButtonOption1.Size = new System.Drawing.Size(330, 29);
            this.radioButtonOption1.TabIndex = 3;
            this.radioButtonOption1.TabStop = true;
            this.radioButtonOption1.Text = "radioButton1";
            this.radioButtonOption1.UseVisualStyleBackColor = true;
            this.radioButtonOption1.MouseHover += new System.EventHandler(this.radioButtonOption_MouseHover);
            // 
            // radioButtonOption2
            // 
            this.radioButtonOption2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonOption2.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonOption2.Location = new System.Drawing.Point(14, 81);
            this.radioButtonOption2.Name = "radioButtonOption2";
            this.radioButtonOption2.Size = new System.Drawing.Size(330, 29);
            this.radioButtonOption2.TabIndex = 3;
            this.radioButtonOption2.TabStop = true;
            this.radioButtonOption2.Text = "radioButton1";
            this.radioButtonOption2.UseVisualStyleBackColor = true;
            this.radioButtonOption2.MouseHover += new System.EventHandler(this.radioButtonOption_MouseHover);
            // 
            // radioButtonOption3
            // 
            this.radioButtonOption3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonOption3.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonOption3.Location = new System.Drawing.Point(14, 121);
            this.radioButtonOption3.Name = "radioButtonOption3";
            this.radioButtonOption3.Size = new System.Drawing.Size(330, 29);
            this.radioButtonOption3.TabIndex = 3;
            this.radioButtonOption3.TabStop = true;
            this.radioButtonOption3.Text = "radioButton1";
            this.radioButtonOption3.UseVisualStyleBackColor = true;
            this.radioButtonOption3.MouseHover += new System.EventHandler(this.radioButtonOption_MouseHover);
            // 
            // radioButtonOption4
            // 
            this.radioButtonOption4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonOption4.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonOption4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonOption4.Location = new System.Drawing.Point(14, 159);
            this.radioButtonOption4.Name = "radioButtonOption4";
            this.radioButtonOption4.Size = new System.Drawing.Size(330, 29);
            this.radioButtonOption4.TabIndex = 3;
            this.radioButtonOption4.TabStop = true;
            this.radioButtonOption4.Text = "radioButton1";
            this.radioButtonOption4.UseVisualStyleBackColor = true;
            this.radioButtonOption4.MouseHover += new System.EventHandler(this.radioButtonOption_MouseHover);
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(304, 257);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(29, 12);
            this.labelProgress.TabIndex = 4;
            this.labelProgress.Text = "1/20";
            // 
            // QuizMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(356, 287);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.radioButtonOption4);
            this.Controls.Add(this.radioButtonOption3);
            this.Controls.Add(this.radioButtonOption2);
            this.Controls.Add(this.radioButtonOption1);
            this.Controls.Add(this.wordTestLabel);
            this.Controls.Add(this.nextBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuizMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuizMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label wordTestLabel;
        private System.Windows.Forms.ToolTip wordItemTooltip;
        private System.Windows.Forms.RadioButton radioButtonOption1;
        private System.Windows.Forms.RadioButton radioButtonOption2;
        private System.Windows.Forms.RadioButton radioButtonOption3;
        private System.Windows.Forms.RadioButton radioButtonOption4;
        private System.Windows.Forms.Label labelProgress;
    }
}