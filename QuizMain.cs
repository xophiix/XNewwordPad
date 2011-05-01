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
    public partial class QuizMain : Form
    {
        public QuizMain()
        {
            InitializeComponent();

            m_testWordRatioButtons.Add(radioButtonOption1);
            m_testWordRatioButtons.Add(radioButtonOption2);
            m_testWordRatioButtons.Add(radioButtonOption3);
            m_testWordRatioButtons.Add(radioButtonOption4);

            labelProgress.Text = "";
        }

        public enum QuizType
        {
            QuizTypeAnnonce,
            QuizTypeMeaning,
        }

        private ArrayList m_testWordRatioButtons = new ArrayList();

        private ArrayList m_testWords = new ArrayList();
        private Dictionary<string, ArrayList> m_wordToOptionMap = new Dictionary<string, ArrayList>();
        private int m_curTestWordIndex = 0;
        private ArrayList m_correctWords = new ArrayList();
        private DateTime m_startTime = new DateTime();
        /**
         * @param proficiency 表示只选择这个熟练度以下（包括当前）的，当取ProficiencyCount时表示不限熟练度
         * @param bAllTime 选取全部时间范围的词
         */
        public bool InitQuiz(ArrayList wordPads, QuizType type, int testWordCount, NewWordItem.ProficiencyLevel proficiency, DateTime starDate, DateTime endDate, bool bAllTime = true)
        {
            HashSet<int> alreadyChoosedWordIndice = new HashSet<int>();
            ArrayList totalWords = new ArrayList();
            ArrayList totalWordsForOption = new ArrayList(); //不考虑时间的所有词，作为选项候选

            int totalWordCount = 0;
            System.Collections.IEnumerator iterator = wordPads.GetEnumerator();

            DateTime earliestTime = new DateTime(8000, 12, 31);
            DateTime latestTime = new DateTime(1000, 1, 1);
            while ( iterator.MoveNext() )
            {
                WordPad wordPad = iterator.Current as WordPad;

                totalWordsForOption.AddRange(wordPad.Words);

                if ( bAllTime )
                {
                    totalWordCount += wordPad.Words.Count;
                    totalWords.AddRange(wordPad.Words);
                }
                else
                {
                    ArrayList wordsWithinTimeRange = wordPad.GetWordsByTimeRange(starDate, endDate);
                    totalWordCount += wordsWithinTimeRange.Count;
                    totalWords.AddRange(wordsWithinTimeRange);

                    if (earliestTime.CompareTo(wordPad.EarliestAddTime) > 0)
                        earliestTime = wordPad.EarliestAddTime;

                    if (latestTime.CompareTo(wordPad.LatestAddTime) < 0)
                        latestTime = wordPad.LatestAddTime;
                }               
            }            

            if (!bAllTime &&
                (starDate.CompareTo(latestTime) > 0  // not in time range
                || endDate.CompareTo(earliestTime) < 0)
               )
            {
                MessageBox.Show("specified time range exceed all the words' total time range!");
                return false;
            }

            if ( totalWords.Count <= 3 )
            {
                MessageBox.Show("Not sufficient words for a valid test!");
                return false;
            }

            if (testWordCount > totalWords.Count)
            {
                testWordCount = totalWords.Count;
                MessageBox.Show("test word count is more than word count in all selected wordpads, so clamp to the actual count: " + totalWords.Count);
            }

            Random randGenerator = new Random(Convert.ToInt32(DateTime.Now.Millisecond));
            for (int i = 0; i < testWordCount; i++ )
            {
                int globalIndex = randGenerator.Next(0, totalWordCount);
                NewWordItem candidateWord = (NewWordItem)totalWords[globalIndex];
                
                // exclude words not fit condition
                while ( alreadyChoosedWordIndice.Contains(globalIndex) 
                    || candidateWord.Meaning == ""
                    || candidateWord.Proficiency > proficiency
                    || ( !bAllTime &&
                         (  candidateWord.AddTime.CompareTo(starDate) < 0  // not in time range
                         || candidateWord.AddTime.CompareTo(endDate) > 0 )
                       )
                    ) 
                {
                    globalIndex = randGenerator.Next(0, totalWordCount);
                    candidateWord = (NewWordItem)totalWords[globalIndex];
                }

                // add test word
                m_testWords.Add(totalWords[globalIndex]);

                // add meaning options for words
                HashSet<int> optionsChoosedForCurWord = new HashSet<int>();
                optionsChoosedForCurWord.Add(globalIndex);

                ArrayList optionWords = new ArrayList();
                for (int j = 0; j < 3; j++)
                {
                    int optionWordIndex = randGenerator.Next(0, totalWordsForOption.Count);
                    while (optionsChoosedForCurWord.Contains(optionWordIndex)
                        || ((NewWordItem)totalWordsForOption[optionWordIndex]).Meaning == "")
                    {
                        optionWordIndex = randGenerator.Next(0, totalWordsForOption.Count);
                    }

                    optionWords.Add(totalWordsForOption[optionWordIndex]);
                    optionsChoosedForCurWord.Add(optionWordIndex);
                }

                // insert correct word option
                int insertPos = randGenerator.Next(0, 3);
                optionWords.Insert(insertPos, totalWords[globalIndex]);                

                m_wordToOptionMap.Add( ((NewWordItem)totalWords[globalIndex]).Name, optionWords);
                alreadyChoosedWordIndice.Add(globalIndex);
            }

            m_curTestWordIndex = 0;
            m_startTime = DateTime.Now;
            UpdateWordUI();
            return true;
        }

        public bool InitQuiz( ArrayList testWords,  Dictionary<string, ArrayList> testWordOptions )
        {
            if (testWords.Count == 0)
                return false;

            m_curTestWordIndex = 0;
            m_startTime = DateTime.Now;

            m_testWords = (ArrayList)testWords.Clone();            

            for (int i = 0; i < m_testWords.Count; i++)
            {
                NewWordItem word = (NewWordItem)m_testWords[i];

                ArrayList optionWords;
                if (testWordOptions.TryGetValue(word.Name, out optionWords))
                {
                    for (int j = 0; j < optionWords.Count; j++)
                    {
                        if ( ((NewWordItem)optionWords[j]).Name == word.Name )
                        {
                            optionWords[j] = word;
                        }
                    }

                    m_wordToOptionMap.Add(word.Name, (ArrayList)optionWords.Clone());
                }
            }            

            UpdateWordUI();
            return true;
        }

        private void UpdateWordUI()
        {
            NewWordItem curTestWord = (NewWordItem)m_testWords[m_curTestWordIndex];
            this.wordTestLabel.Text = curTestWord.Name + "[" + curTestWord.Annoucement + "]";            

            ArrayList options;
            if ( m_wordToOptionMap.TryGetValue(curTestWord.Name, out options) )
            {
                int i = 0;
                foreach( object o in options )
                {
                    if (i < m_testWordRatioButtons.Count)
                    {
                        ((RadioButton)m_testWordRatioButtons[i]).Checked = false;
                        ((RadioButton)m_testWordRatioButtons[i]).Text = ((NewWordItem)o).Meaning;                        
                        //((RadioButton)m_testWordRatioButtons[i]).MouseHover = 
                        i++;
                    }
                }                
            }

            labelProgress.Text = (m_curTestWordIndex + 1).ToString() + "/" + m_testWords.Count.ToString();
        }

        public struct Result 
        {
            public int totalWords;
            public ArrayList correctWords;
            public ArrayList wrongWords;
            public Dictionary<string, ArrayList> wrongWordsOptions;

            public float CorrectRate { get { return correctWords.Count / (float)totalWords; } }
            public TimeSpan costTime;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            // check
            NewWordItem curTestWord = (NewWordItem)m_testWords[m_curTestWordIndex];

            int checkedIndex = -1;
            for (int i = 0; i < m_testWordRatioButtons.Count; i++ )
            {
                if (((RadioButton)m_testWordRatioButtons[i]).Checked)
                {
                    checkedIndex = i;
                    break;
                }
            }

            if (checkedIndex >= 0)
            {
                if (curTestWord.Meaning == ((RadioButton)m_testWordRatioButtons[checkedIndex]).Text)
                {
                    m_correctWords.Add(curTestWord);
                }
            }
            else
            {
                MessageBox.Show("You must choose one to proceed!");
                return;
            }

            m_curTestWordIndex++;
            if (m_curTestWordIndex < m_testWords.Count)
            {
                UpdateWordUI();
            }
            else
            {
                Result result;
                result.correctWords = (ArrayList)m_correctWords.Clone();
                result.totalWords = m_testWords.Count;
                result.wrongWords = new ArrayList();
                result.costTime = DateTime.Now - m_startTime;
                result.wrongWordsOptions = new Dictionary<string, ArrayList>();
                
                for (int i = 0; i < m_testWords.Count; i++)
                {
                    if (result.correctWords.Contains(m_testWords[i]))
                        continue;
                    
                    result.wrongWords.Add(((NewWordItem)m_testWords[i]).Clone());

                    ArrayList wrongWordOption;
                    if ( m_wordToOptionMap.TryGetValue( ((NewWordItem)m_testWords[i]).Name, out wrongWordOption) )
                    {
                        NewWordItem word = (NewWordItem)result.wrongWords[result.wrongWords.Count-1];

                        ArrayList optionWords = new ArrayList();
                        foreach ( NewWordItem optionWord in wrongWordOption )
                        {
                            optionWords.Add(optionWord);
                        }

                        result.wrongWordsOptions.Add(word.Name, optionWords);
                    }                    
                }
                
                QuizResult resultDlg = new QuizResult( result );
                this.Close();
                this.Hide();
                resultDlg.ShowDialog(MainDlg.Instance);
            }
        }

        private void radioButtonOption_MouseHover(object sender, EventArgs e)
        {            
            wordItemTooltip.Show(((RadioButton)sender).Text, (RadioButton)sender);
        }
    }
}
