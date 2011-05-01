namespace XNewwordPadCS
{
    partial class QuizResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizResult));
            this.resultText = new System.Windows.Forms.TextBox();
            this.againBtn = new System.Windows.Forms.Button();
            this.recoverBtn = new System.Windows.Forms.Button();
            this.overBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // resultText
            // 
            this.resultText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.resultText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resultText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.resultText.Location = new System.Drawing.Point(12, 12);
            this.resultText.MaxLength = 655350;
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultText.Size = new System.Drawing.Size(389, 292);
            this.resultText.TabIndex = 0;
            // 
            // againBtn
            // 
            this.againBtn.Location = new System.Drawing.Point(166, 310);
            this.againBtn.Name = "againBtn";
            this.againBtn.Size = new System.Drawing.Size(75, 23);
            this.againBtn.TabIndex = 1;
            this.againBtn.Text = "Again";
            this.againBtn.UseVisualStyleBackColor = true;
            this.againBtn.Click += new System.EventHandler(this.againBtn_Click);
            // 
            // recoverBtn
            // 
            this.recoverBtn.Location = new System.Drawing.Point(12, 310);
            this.recoverBtn.Name = "recoverBtn";
            this.recoverBtn.Size = new System.Drawing.Size(75, 23);
            this.recoverBtn.TabIndex = 2;
            this.recoverBtn.Text = "Recover";
            this.recoverBtn.UseVisualStyleBackColor = true;
            this.recoverBtn.Click += new System.EventHandler(this.recoverBtn_Click);
            // 
            // overBtn
            // 
            this.overBtn.Location = new System.Drawing.Point(314, 310);
            this.overBtn.Name = "overBtn";
            this.overBtn.Size = new System.Drawing.Size(75, 23);
            this.overBtn.TabIndex = 1;
            this.overBtn.Text = "Over";
            this.overBtn.UseVisualStyleBackColor = true;
            this.overBtn.Click += new System.EventHandler(this.overBtn_Click);
            // 
            // QuizResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 348);
            this.Controls.Add(this.recoverBtn);
            this.Controls.Add(this.overBtn);
            this.Controls.Add(this.againBtn);
            this.Controls.Add(this.resultText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuizResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuizResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Button againBtn;
        private System.Windows.Forms.Button recoverBtn;
        private System.Windows.Forms.Button overBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}