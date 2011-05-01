using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace XNewwordPadCS
{
    public partial class QuizResult : Form
    {
        private QuizMain.Result m_result;

        public QuizResult( QuizMain.Result result )
        {
            InitializeComponent();

            m_result = result;

            int hour = (int)result.costTime.TotalHours;
            int minute = ((int)result.costTime.TotalSeconds - hour * 3600) / 60;
            int second = (int)result.costTime.TotalSeconds - minute * 60 - hour * 3600;

            // format result text
            this.resultText.Text = "CorrectRate: " + 100 * result.CorrectRate + "%\r\n"
                + "TotalTime: " + hour.ToString() + ":" + minute.ToString() + ":" + second.ToString();

            this.resultText.Text += "\r\n\r\n";
            this.resultText.Text += FormatResultDetailText();
            this.resultText.DeselectAll();
            this.resultText.SelectedText = "";

            this.overBtn.Focus();
        }

        private string FormatResultDetailText()
        {
            StringWriter bw = new StringWriter();
            if (m_result.wrongWords.Count > 0)
                bw.WriteLine("Wrong words:");

            foreach (NewWordItem wrongWord in m_result.wrongWords)
            {
                bw.Write(wrongWord.ToText());
                bw.WriteLine();
            }

            bw.WriteLine();
            return bw.ToString();
        }

        private void recoverBtn_Click(object sender, EventArgs e)
        {
            LogResult();
            QuizMain testDlg = new QuizMain();
            if ( testDlg.InitQuiz(m_result.wrongWords, m_result.wrongWordsOptions) )
            {
                Hide();
                Close();
                testDlg.ShowDialog(MainDlg.Instance);
            }
        }

        private void overBtn_Click(object sender, EventArgs e)
        {
            LogResult();
            Close();
        }

        private void againBtn_Click(object sender, EventArgs e)
        {
            LogResult();
            QuizSetting settingDlg = new QuizSetting();
            Hide();
            Close();
            settingDlg.ShowDialog(MainDlg.Instance);
        }

        private void LogResult()
        {
            /*
            //       d: 6/15/2008
            //       D: Sunday, June 15, 2008
            //       f: Sunday, June 15, 2008 9:15 PM
            //       F: Sunday, June 15, 2008 9:15:07 PM
            //       g: 6/15/2008 9:15 PM
            //       G: 6/15/2008 9:15:07 PM
            //       m: June 15
            //       o: 2008-06-15T21:15:07.0000000
            //       R: Sun, 15 Jun 2008 21:15:07 GMT
            //       s: 2008-06-15T21:15:07
            //       t: 9:15 PM
            //       T: 9:15:07 PM
            //       u: 2008-06-15 21:15:07Z
            //       U: Monday, June 16, 2008 4:15:07 AM
            //       y: June, 2008
            //       
            //       'h:mm:ss.ff t': 9:15:07.00 P
            //       'd MMM yyyy': 15 Jun 2008
            //       'HH:mm:ss.f': 21:15:07.0
            //       'dd MMM HH:mm:ss': 15 Jun 21:15:07
            //       '\Mon\t\h\: M': Month: 6
            //       'HH:mm:ss.ffffzzz': 21:15:07.0000-07:00
             */
            string logName = "quizResult_" 
                + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".txt";

            StreamWriter bw = new StreamWriter(logName);
            bw.AutoFlush = true;
            bw.WriteLine(DateTime.Now.ToLongDateString());
            bw.WriteLine(resultText.Text);

            bw.Write(FormatResultDetailText());

            bw.WriteLine();

            bw.Flush();
        }
    }
}
