namespace XNewwordPadCS
{
    partial class QuizSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizSetting));
            this.wordPadsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.wordCountSpin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.familarityCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quizTypeCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRelDays = new System.Windows.Forms.ComboBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAllTime = new System.Windows.Forms.CheckBox();
            this.checkBoxRelativeMode = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wordCountSpin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordPadsCheckedListBox
            // 
            this.wordPadsCheckedListBox.CheckOnClick = true;
            this.wordPadsCheckedListBox.FormattingEnabled = true;
            this.wordPadsCheckedListBox.Location = new System.Drawing.Point(84, 12);
            this.wordPadsCheckedListBox.Name = "wordPadsCheckedListBox";
            this.wordPadsCheckedListBox.Size = new System.Drawing.Size(252, 68);
            this.wordPadsCheckedListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test Range";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(134, 376);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // wordCountSpin
            // 
            this.wordCountSpin.Location = new System.Drawing.Point(84, 103);
            this.wordCountSpin.Name = "wordCountSpin";
            this.wordCountSpin.Size = new System.Drawing.Size(50, 21);
            this.wordCountSpin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test Count";
            // 
            // familarityCombo
            // 
            this.familarityCombo.FormattingEnabled = true;
            this.familarityCombo.Location = new System.Drawing.Point(84, 142);
            this.familarityCombo.Name = "familarityCombo";
            this.familarityCombo.Size = new System.Drawing.Size(104, 20);
            this.familarityCombo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Familarity";
            // 
            // quizTypeCombo
            // 
            this.quizTypeCombo.FormattingEnabled = true;
            this.quizTypeCombo.Items.AddRange(new object[] {
            "Annocement",
            "Meaning"});
            this.quizTypeCombo.Location = new System.Drawing.Point(84, 178);
            this.quizTypeCombo.Name = "quizTypeCombo";
            this.quizTypeCombo.Size = new System.Drawing.Size(104, 20);
            this.quizTypeCombo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quiz Type";
            // 
            // comboBoxRelDays
            // 
            this.comboBoxRelDays.FormatString = "N0";
            this.comboBoxRelDays.FormattingEnabled = true;
            this.comboBoxRelDays.Items.AddRange(new object[] {
            "0",
            "3",
            "7",
            "14",
            "30"});
            this.comboBoxRelDays.Location = new System.Drawing.Point(111, 35);
            this.comboBoxRelDays.MaxDropDownItems = 4;
            this.comboBoxRelDays.Name = "comboBoxRelDays";
            this.comboBoxRelDays.Size = new System.Drawing.Size(121, 20);
            this.comboBoxRelDays.TabIndex = 5;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(116, 290);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.startDateTimePicker.TabIndex = 7;
            this.startDateTimePicker.Value = new System.DateTime(2011, 2, 1, 2, 20, 0, 0);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(116, 336);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.endDateTimePicker.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAllTime);
            this.groupBox1.Controls.Add(this.checkBoxRelativeMode);
            this.groupBox1.Controls.Add(this.comboBoxRelDays);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(2, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 158);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TimeRange";
            // 
            // checkBoxAllTime
            // 
            this.checkBoxAllTime.AutoSize = true;
            this.checkBoxAllTime.Location = new System.Drawing.Point(10, 60);
            this.checkBoxAllTime.Name = "checkBoxAllTime";
            this.checkBoxAllTime.Size = new System.Drawing.Size(66, 16);
            this.checkBoxAllTime.TabIndex = 6;
            this.checkBoxAllTime.Text = "allTime";
            this.checkBoxAllTime.UseVisualStyleBackColor = true;
            this.checkBoxAllTime.CheckedChanged += new System.EventHandler(this.checkBoxAllTime_CheckedChanged);
            // 
            // checkBoxRelativeMode
            // 
            this.checkBoxRelativeMode.AutoSize = true;
            this.checkBoxRelativeMode.Location = new System.Drawing.Point(10, 38);
            this.checkBoxRelativeMode.Name = "checkBoxRelativeMode";
            this.checkBoxRelativeMode.Size = new System.Drawing.Size(96, 16);
            this.checkBoxRelativeMode.TabIndex = 6;
            this.checkBoxRelativeMode.Text = "relativeMode";
            this.checkBoxRelativeMode.UseVisualStyleBackColor = true;
            this.checkBoxRelativeMode.CheckedChanged += new System.EventHandler(this.checkBoxRelativeMode_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "days before";
            // 
            // QuizSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 403);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.quizTypeCombo);
            this.Controls.Add(this.familarityCombo);
            this.Controls.Add(this.wordCountSpin);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wordPadsCheckedListBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuizSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuizSetting";
            ((System.ComponentModel.ISupportInitialize)(this.wordCountSpin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox wordPadsCheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.NumericUpDown wordCountSpin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox familarityCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox quizTypeCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRelDays;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxRelativeMode;
        private System.Windows.Forms.CheckBox checkBoxAllTime;
    }
}