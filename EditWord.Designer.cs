namespace XNewwordPadCS
{
    partial class EditWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWord));
            this.Cancel = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.MeaningRichEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AnnoucementEdit = new System.Windows.Forms.TextBox();
            this.WordNameEdit = new System.Windows.Forms.TextBox();
            this.proficiencyCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(25, 253);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(55, 23);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Confirm
            // 
            this.Confirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Confirm.Location = new System.Drawing.Point(25, 216);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(55, 23);
            this.Confirm.TabIndex = 11;
            this.Confirm.Text = "OK";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // MeaningRichEdit
            // 
            this.MeaningRichEdit.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MeaningRichEdit.Location = new System.Drawing.Point(89, 102);
            this.MeaningRichEdit.Multiline = true;
            this.MeaningRichEdit.Name = "MeaningRichEdit";
            this.MeaningRichEdit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MeaningRichEdit.Size = new System.Drawing.Size(183, 137);
            this.MeaningRichEdit.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Meaning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Annouce";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Word";
            // 
            // AnnoucementEdit
            // 
            this.AnnoucementEdit.Location = new System.Drawing.Point(89, 55);
            this.AnnoucementEdit.Name = "AnnoucementEdit";
            this.AnnoucementEdit.Size = new System.Drawing.Size(183, 21);
            this.AnnoucementEdit.TabIndex = 8;
            // 
            // WordNameEdit
            // 
            this.WordNameEdit.Location = new System.Drawing.Point(89, 14);
            this.WordNameEdit.Name = "WordNameEdit";
            this.WordNameEdit.Size = new System.Drawing.Size(183, 21);
            this.WordNameEdit.TabIndex = 5;
            // 
            // proficiencyCombobox
            // 
            this.proficiencyCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proficiencyCombobox.FormattingEnabled = true;
            this.proficiencyCombobox.Location = new System.Drawing.Point(89, 256);
            this.proficiencyCombobox.Name = "proficiencyCombobox";
            this.proficiencyCombobox.Size = new System.Drawing.Size(183, 20);
            this.proficiencyCombobox.TabIndex = 13;
            // 
            // EditWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.proficiencyCombobox);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.MeaningRichEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnnoucementEdit);
            this.Controls.Add(this.WordNameEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditWord";
            this.Text = "EditWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.TextBox MeaningRichEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AnnoucementEdit;
        private System.Windows.Forms.TextBox WordNameEdit;
        private System.Windows.Forms.ComboBox proficiencyCombobox;
    }
}