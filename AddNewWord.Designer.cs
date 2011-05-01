namespace XNewwordPadCS
{
    partial class AddNewWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewWord));
            this.WordNameEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AnnoucementEdit = new System.Windows.Forms.TextBox();
            this.MeaningRichEdit = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WordNameEdit
            // 
            this.WordNameEdit.Location = new System.Drawing.Point(68, 23);
            this.WordNameEdit.Name = "WordNameEdit";
            this.WordNameEdit.Size = new System.Drawing.Size(154, 21);
            this.WordNameEdit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Annouce";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Meaning";
            // 
            // AnnoucementEdit
            // 
            this.AnnoucementEdit.Location = new System.Drawing.Point(68, 64);
            this.AnnoucementEdit.Name = "AnnoucementEdit";
            this.AnnoucementEdit.Size = new System.Drawing.Size(154, 21);
            this.AnnoucementEdit.TabIndex = 1;
            // 
            // MeaningRichEdit
            // 
            this.MeaningRichEdit.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MeaningRichEdit.Location = new System.Drawing.Point(68, 111);
            this.MeaningRichEdit.Multiline = true;
            this.MeaningRichEdit.Name = "MeaningRichEdit";
            this.MeaningRichEdit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MeaningRichEdit.Size = new System.Drawing.Size(154, 139);
            this.MeaningRichEdit.TabIndex = 2;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(4, 196);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(55, 23);
            this.Confirm.TabIndex = 3;
            this.Confirm.Text = "OK";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(4, 225);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(55, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddNewWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 262);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.MeaningRichEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnnoucementEdit);
            this.Controls.Add(this.WordNameEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddNewWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WordNameEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AnnoucementEdit;
        private System.Windows.Forms.TextBox MeaningRichEdit;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Cancel;
    }
}