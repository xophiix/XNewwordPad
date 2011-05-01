using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XNewwordPadCS
{
    public partial class QuizSetting : Form
    {
        public QuizSetting()
        {
            InitializeComponent();

            // add word pad list
            MainDlg mainDlg = MainDlg.Instance;
            Dictionary<string, WordPad>.Enumerator wordPadEnumerator = mainDlg.WordPadEnumerator;
            while ( wordPadEnumerator.MoveNext() )
            {
                this.wordPadsCheckedListBox.Items.Add(wordPadEnumerator.Current.Key, false);                
            }

            for (int i = 0; i < (int)NewWordItem.ProficiencyLevel.ProficiencyLevelCount; i++ )
            {
                this.familarityCombo.Items.Add(NewWordItem.ToProficiencyString((NewWordItem.ProficiencyLevel)i));
            }

            this.familarityCombo.Items.Add("All");
            this.familarityCombo.SelectedIndex = 0;
            this.quizTypeCombo.SelectedIndex = 1;

            this.comboBoxRelDays.SelectedIndex = 0;

            checkBoxRelativeMode.Checked = true;
            checkBoxAllTime.Checked = false;
        }        

        private void startBtn_Click(object sender, EventArgs e)
        {
            int wordCount = Decimal.ToInt32( wordCountSpin.Value );
            if (wordCount <= 0)
            {
                MessageBox.Show("Must choose at least one word for test!");
                return;
            }

            int testType = this.quizTypeCombo.SelectedIndex;
            int familarity = this.familarityCombo.SelectedIndex;

            ArrayList candidateWordPads = new ArrayList();
            foreach( string wordPadName in wordPadsCheckedListBox.CheckedItems )
            {
                WordPad wordPad = MainDlg.Instance.GetWordPadByName( wordPadName );
                candidateWordPads.Add(wordPad);
            }

            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now;

            if (!checkBoxAllTime.Checked)
            {
                if (checkBoxRelativeMode.Checked)
                {
                    int daysBefore = Convert.ToInt32(comboBoxRelDays.Text);
                    startDate = endDate.AddDays(Math.Min(0, -daysBefore));
                }
                else
                {
                    startDate = startDateTimePicker.Value;
                    endDate = endDateTimePicker.Value;

                    if (startDate.CompareTo(endDate) > 0)
                        startDate = new DateTime(endDate.Year, endDate.Month, endDate.Day);                    
                }
            }

            TimeSpan tp = new TimeSpan(startDate.Hour, startDate.Minute, startDate.Second);
            startDate = startDate.Subtract(tp);
            tp = new TimeSpan(endDate.Hour, endDate.Minute, endDate.Second);
            endDate = endDate.Subtract(tp);

            QuizMain quizDlg = new QuizMain();
            if ( !quizDlg.InitQuiz(candidateWordPads, (QuizMain.QuizType)testType, wordCount,
                (NewWordItem.ProficiencyLevel)familarity,
                startDate, endDate, checkBoxAllTime.Checked ) )
            {
                return;
            }
            Hide();
            this.Close();
            quizDlg.ShowDialog(MainDlg.Instance);            
        }

        private void checkBoxRelativeMode_CheckedChanged(object sender, EventArgs e)
        {            
            startDateTimePicker.Enabled = !checkBoxRelativeMode.Checked;
            endDateTimePicker.Enabled = !checkBoxRelativeMode.Checked;
            comboBoxRelDays.Enabled = checkBoxRelativeMode.Checked;
        }

        private void checkBoxAllTime_CheckedChanged(object sender, EventArgs e)
        {
            startDateTimePicker.Enabled = !checkBoxAllTime.Checked;
            endDateTimePicker.Enabled = !checkBoxAllTime.Checked;
            comboBoxRelDays.Enabled = !checkBoxAllTime.Checked;
            checkBoxRelativeMode.Enabled = !checkBoxAllTime.Checked;
        }
    }
}
