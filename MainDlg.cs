using System;
using System.Collections;
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
    public partial class MainDlg : Form
    {
        private Dictionary<string, WordPad> m_wordPads = new Dictionary<string, WordPad>();
        private static MainDlg _instance;

        public static MainDlg Instance { get { return _instance;  } }

        static public String WordPadSavePath = "./WordPads/";
        static public String WordPadExtesion = ".pad";

        private Point m_iniWordListRelativeLocation;
        private Size m_iniWordListMargin;

        // every word pad associates one word list to avoid list repaint blink
        private Dictionary<string, ListView> m_wordLists = new Dictionary<string, ListView>();

        public enum WordSortKeyType
        {
            WordSortKeyName,
            WordSortKeyAnnonce,
            WordSortKeyMeaning,
            WordSortKeyAddTime,
            WordSortKeyProficiency,            
        }
        
        public Dictionary<string, WordPad>.Enumerator WordPadEnumerator 
        { get { return m_wordPads.GetEnumerator();  } }

        public WordPad GetWordPadByName( string name )
        {
            WordPad curWordPad;
            if (m_wordPads.TryGetValue(name, out curWordPad))
                return curWordPad;
            else
                return null;            
        }

        public WordSortKeyType WordSortKey { get; set; }
        
        protected class WordListComparer
            : IComparer, IComparer<ListViewItem>
        {
            public WordSortKeyType SortKey {get;set;}
            public bool Ascending { get; set; }
            
            public int Compare(object x, object y)
            {
                if ( Ascending )
                    return Compare((ListViewItem)x, (ListViewItem)y);
                else
                    return Compare((ListViewItem)y, (ListViewItem)x);
            }

            public int Compare(ListViewItem x, ListViewItem y)
            {
                NewWordItem word1 = (NewWordItem)x.Tag;
                NewWordItem word2 = (NewWordItem)y.Tag;

                if ( SortKey == WordSortKeyType.WordSortKeyName )
                {
                    return word1.Name.CompareTo(word2.Name);
                }
                else if ( SortKey == WordSortKeyType.WordSortKeyAnnonce )
                {
                    return word1.Annoucement.CompareTo(word2.Annoucement);
                }
                else if ( SortKey == WordSortKeyType.WordSortKeyMeaning )
                {
                    return word1.Meaning.CompareTo(word2.Meaning);
                }
                else if ( SortKey == WordSortKeyType.WordSortKeyAddTime )
                {
                    return word1.AddTime.CompareTo(word2.AddTime);
                }
                else if ( SortKey == WordSortKeyType.WordSortKeyProficiency )
                {
                    return word1.Proficiency.CompareTo(word2.Proficiency);
                }

                return 0;
            }
        }

        /// <summary>
        /// get current active word list( orginal one or the search results )
        /// </summary>
        /// <returns></returns>
        public ListView ActiveWordList {
            get
            {
                if (WordList.Visible)
                    return WordList;
                if (searchResultList.Visible)
                    return searchResultList;
                return null;
            }
        }

        /// <summary>
        /// get current inactive word list( orginal one or the search results )
        /// </summary>
        /// <returns></returns>
        public ListView InactiveWordList
        {
            get
            {
                if (!WordList.Visible)
                    return WordList;
                if (!searchResultList.Visible)
                    return searchResultList;
                return null;
            }
        } 

        public MainDlg()
        {
            WordPadSavePath = Directory.GetCurrentDirectory() + "./WordPads/";
            if (!Directory.Exists(WordPadSavePath))
                Directory.CreateDirectory(WordPadSavePath);

            InitializeComponent();

            WordPadTree.TopNode = WordPadTree.Nodes.Add("All WordPad");

            // 加载生词本
            string[] fileNames = Directory.GetFiles(WordPadSavePath, "*" + WordPadExtesion);

            string strErrMsg = "";
            foreach ( string fileName in fileNames )
            {
                // 很遗憾, .pad2 也会被.pad匹配
                if ( Path.GetExtension(fileName) != WordPadExtesion )
                    continue;

                string rawFileName = Path.GetFileNameWithoutExtension(fileName);
                if (m_wordPads.ContainsKey(rawFileName))
                {
                    strErrMsg += "same name word pad of " + rawFileName + " already exists! errfile: " + fileName + "\n";
                    continue;
                }

                WordPad wp = new WordPad(rawFileName);

                if ( wp.Load(fileName) )
                {                    
                    m_wordPads.Add( wp.Name, wp );
                    WordPadTree.TopNode.Nodes.Add(wp.Name);

                    ListView wordList = new ListView();
                    
                    m_wordLists.Add(wp.Name, WordList);
                }
            }

            if (strErrMsg != "")
                MessageBox.Show(strErrMsg);

            if (m_wordPads.Count == 0)
            {                
                AddNewWordPad("Default", true);
            }

            WordPadTree.TopNode.Expand();

            WordPad firstWordPad;
            if ( m_wordPads.TryGetValue(WordPadTree.TopNode.FirstNode.Text, out firstWordPad) )
                UpdateWordListFromWordPad( firstWordPad );

            if (_instance == null)
                _instance = this;

            WordListComparer sorter = new WordListComparer();
            sorter.Ascending = true;
            sorter.SortKey = WordSortKeyType.WordSortKeyAddTime;
            WordList.ListViewItemSorter = (IComparer)sorter;

            // timer to save all words every little while
            timerSaveAll.Enabled = true;

            int relX = WordList.Bounds.Location.X - Bounds.Location.X;
            int relY = WordList.Bounds.Location.Y - Bounds.Location.Y;
            m_iniWordListRelativeLocation  = new Point( relX, relY );

            m_iniWordListMargin = new Size();
            m_iniWordListMargin.Width = Bounds.Right - WordList.Bounds.Right;
            m_iniWordListMargin.Height = Bounds.Bottom - WordList.Bounds.Bottom;
        }
        
        protected void UpdateWordListFromWordPad( WordPad wp )
        {
            UpdateWordListByWordList(WordList, wp.Words);
            statusStripCurWordPad.Text = "Current word pad: " + wp.Name;
        }

        protected void UpdateWordListByWordList(ListView list, ArrayList wordList)
        {
            list.Items.Clear();

            foreach (NewWordItem newWord in wordList)
            {
                AddWordItemToList(list, newWord);
            }

            toolStripStatusLabelWordCount.Text = "total words: " + wordList.Count.ToString();
            AutoArrangeWordListColumns(list);
        }

        protected void AddWordItemToList( ListView list, NewWordItem wordItem )
        {
            ListViewItem item = new ListViewItem();
            item.Text = wordItem.Name;
            item.SubItems.Add(wordItem.Annoucement);
            item.SubItems.Add(wordItem.Meaning);
            item.SubItems.Add(wordItem.AddTime.ToString());
            item.SubItems.Add(NewWordItem.ToProficiencyString(wordItem.Proficiency));

            foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
            {                
                subItem.Tag = wordItem;
            }

            item.Tag = wordItem;            

            list.Items.Add(item);
        }

        public void SaveAllWordPads( bool bCreateBackup = false )
        {
            Dictionary<string, WordPad>.Enumerator i = m_wordPads.GetEnumerator();
            while (i.MoveNext())
            {
                string savePath = WordPadSavePath + i.Current.Key + WordPadExtesion;
                if (bCreateBackup)
                {
                    string saveBkPath = savePath + ".bak";
                    try
                    {
                        System.IO.File.Delete(saveBkPath);
                        // 不删就不能Copy成功，真恶心
                        System.IO.File.Copy(savePath, saveBkPath);
                    }
                    catch(System.Exception e)
                    {
                        Console.Write(e);
                    }
                }


                i.Current.Value.Save(savePath);
            }
        }

        protected override void OnClosed(System.EventArgs e)
        {
            SaveAllWordPads(false);
            base.OnClosed(e);
        }

        private void NewWord_Click(object sender, EventArgs e)
        {
            AddNewWord dlg = new AddNewWord();
            dlg.ShowDialog( this );
        }

        public bool AddNewWord( WordPad wordPad, NewWordItem newWord )
        {
            if (wordPad == null)
                return false;

            if ( wordPad.FindWord( newWord.Name ) != null )
            {
                MessageBox.Show("you already add this word!");
                return false;
            }

            bool result = wordPad.AddWord(newWord);
            if ( result )
            {
                AddWordItemToList( WordList, newWord);                
            }

            return result;
        }

        public bool AddNewWordPad( string name, bool switchTo )
        {
            if (m_wordPads.ContainsKey(name))
                return false;

            WordPad newPad = new WordPad( name );
            m_wordPads.Add(name, newPad);
            TreeNode newNode = WordPadTree.TopNode.Nodes.Add(name);
            newNode.Tag = newPad;

            // 选中新加生词本
            if ( switchTo )
            {
                newNode.Expand();
            }

            return true;
        }

        private void PadTree_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            e.CancelEdit = false;
            if (e.Label == null)
            {
                e.CancelEdit = true;

                if ( AddingNewPad )
                {
                    // 删掉刚加的节点
                    e.Node.Remove();
                    AddingNewPad = false;
                }

                return;
            }

            WordPad targetPad;
            if (m_wordPads.TryGetValue(e.Node.Text, out targetPad))
            {
                string preName = targetPad.Name;
                targetPad.Name = e.Label;
                m_wordPads.Add(targetPad.Name, targetPad);
                m_wordPads.Remove(preName);                
            }
            else
            {
                if ( AddingNewPad )
                {
                    WordPad newPad = new WordPad(e.Label);
                    m_wordPads.Add(e.Label, newPad);
                    e.Node.Tag = newPad;
                    AddingNewPad = false;
                }
                else
                    e.CancelEdit = true;
            }            
        }

        private void WordPadTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            WordPad targetPad;
            if (!m_wordPads.TryGetValue(e.Node.Text, out targetPad))
                return;

            WordList.Show();
            searchResultList.Hide();
            UpdateWordListFromWordPad(targetPad);
        }

        public WordPad CurWordPad
        {
            get
            {
                if (WordPadTree.SelectedNode == null)
                    WordPadTree.SelectedNode = WordPadTree.TopNode.FirstNode;

                WordPad curWordPad;
                if (m_wordPads.TryGetValue(WordPadTree.SelectedNode.Text, out curWordPad))
                    return curWordPad;
                else
                    return null;
            }
        }

        private void SearchWord( WordPad wordPad, string wordKey )
        {
            if (wordPad == null)
                return;

            if ( wordKey == null || wordKey.Length == 0 )
            {
                searchResultList.Hide();
                WordList.Show();

                UpdateWordCount();                
                return;
            }

            ArrayList searchResult = new ArrayList();
            for (int i = 0; i < wordPad.Words.Count; i++)
            {
                NewWordItem word = (NewWordItem)wordPad.Words[i];
                if ( word.Name.Contains(wordKey) )
                    searchResult.Add(wordPad.Words[i]);
            }

            UpdateWordListByWordList(searchResultList, searchResult);

            searchResultList.Show();
            WordList.Hide();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchWord(CurWordPad, SearchKeyEdit.Text);
        }

        private void SearchKeyEdit_TextChanged(object sender, EventArgs e)
        {
            SearchWord( CurWordPad, SearchKeyEdit.Text);
        }

        private void WordList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            WordListComparer comparer = ((WordListComparer)ActiveWordList.ListViewItemSorter);
            comparer.SortKey = (WordSortKeyType)e.Column;
            comparer.Ascending = !comparer.Ascending;
            
            ActiveWordList.Sort();
        }

        private void WordList_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            NewWordItem wordItem = (NewWordItem)e.Item.Tag;
            string tooltip = wordItem.Name + "\r\n" + wordItem.Annoucement + "\r\n\r\n" + wordItem.Meaning;
            e.Item.ToolTipText = tooltip;
        }

        public bool AddingNewPad { get; set; }
        private void NewWordPad_Click(object sender, EventArgs e)
        {
            WordPadTree.Focus();
            TreeNode node = WordPadTree.TopNode.Nodes.Add("");
            node.Expand();
            node.BeginEdit();
            AddingNewPad = true;            
        }

        private void editToolStripMenuItemWord_Click(object sender, EventArgs e)
        {
            if (ActiveWordList.FocusedItem == null)
                return;

            NewWordItem wordItem = (NewWordItem)ActiveWordList.FocusedItem.Tag;
            ListViewItem anotherListItem = InactiveWordList.FindItemWithText(wordItem.Name);
            EditWord dlg = new EditWord(wordItem, ActiveWordList.FocusedItem, anotherListItem);
            dlg.ShowDialog(this);
        }

        public void UpdateWordCount()
        {
            toolStripStatusLabelWordCount.Text = "total words: " + ActiveWordList.Items.Count.ToString();
        }

        private void deleteToolStripMenuItemWord_Click(object sender, EventArgs e)
        {
            if (ActiveWordList.FocusedItem == null)
                return;

            // 确认
            DialogResult result = MessageBox.Show("Are you sure want to delte the word?", "Confirm", MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK)
                return;

            if (CurWordPad.DelWord(ActiveWordList.FocusedItem.Text))
            {
                ActiveWordList.FocusedItem.Remove();
                InactiveWordList.Items.RemoveByKey(ActiveWordList.FocusedItem.Text);
                UpdateWordCount();
            }
        }

        private void deleteToolStripMenuWordPad_Click(object sender, EventArgs e)
        {
            if (WordPadTree.SelectedNode == null)
                return;

            if ( CurWordPad != null )
            {
                // 确认
                DialogResult result = MessageBox.Show("Are you sure want to delte the wordpad?", "Confirm", MessageBoxButtons.OKCancel);
                if (result != DialogResult.OK)
                    return;

                string name = CurWordPad.Name;
                m_wordPads.Remove(CurWordPad.Name);
                WordPadTree.SelectedNode.Remove();

                // 删除文件
                File.Delete(WordPadSavePath + name + WordPadExtesion);
            }
        }

        private void exitToolStripMenuApp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuApp_Click(object sender, EventArgs e)
        {
            AboutBox dlg = new AboutBox();
            dlg.ShowDialog(this);
        }

        private void toggleWordPadTreeShowMenuItem_Click(object sender, EventArgs e)
        {
            if ( WordPadTree.Visible )
            {
                WordPadTree.Hide();
                WordList.SetBounds(WordPadTree.Bounds.X, WordPadTree.Bounds.Y,
                    WordList.Bounds.Right - WordPadTree.Bounds.X, WordList.Bounds.Bottom - WordPadTree.Bounds.Y);
            }
            else
            {
                WordPadTree.Show();
                WordList.SetBounds(WordPadTree.Bounds.Right + 5, WordList.Bounds.Y,
                    WordList.Bounds.Right - WordPadTree.Bounds.Right - 5, WordList.Bounds.Height );
            }
        }

        private void hideWordPadTree(object sender, EventArgs e)
        {
            WordPadTree.Hide();
            WordList.SetBounds(WordPadTree.Bounds.X, WordList.Bounds.Y,
                WordList.Bounds.Right - WordPadTree.Bounds.X, WordList.Bounds.Height );
        }

        private void BtnImportKingsoft_Click(object sender, EventArgs e)
        {
            openKingSoftFileDlg.ShowDialog(this);
        }

        private void openKingSoftFileDlg_FileOk(object sender, CancelEventArgs e)
        {
            if ( !e.Cancel)
            {                               
                if ( CurWordPad == null )
                {
                    if (!AddNewWordPad("Default", true))
                        return;                    
                }

                foreach( string filename in openKingSoftFileDlg.FileNames )
                {
                    CurWordPad.LoadFromKingsoftWordpad(filename, true);
                }

                UpdateWordListFromWordPad(CurWordPad);
            }
        }

        private void AutoArrangeWordListColumns(ListView wordList)
        {
            WordList.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            WordList.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            WordList.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            WordList.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void MainDlg_Resize(object sender, EventArgs e)
        {
            if (m_iniWordListRelativeLocation == null)
                return;

            // ATTENTION!! this is the screen pos!
            Rectangle mainRect = Bounds;
                        


            Rectangle wordListRect = new Rectangle(
                m_iniWordListRelativeLocation.X,
                m_iniWordListRelativeLocation.Y,
                0, 0
                );

            if (WordPadTree.Visible == false)
            {
                wordListRect = new Rectangle(WordPadTree.Bounds.Left, WordPadTree.Bounds.Top, 0, 0);
            }

            wordListRect.Width = mainRect.Width - m_iniWordListMargin.Width - wordListRect.Left;
            wordListRect.Height = mainRect.Height - m_iniWordListMargin.Height - wordListRect.Top;
            
            WordList.Bounds = wordListRect;
            searchResultList.Bounds = wordListRect;

            AutoArrangeWordListColumns(WordList);
            AutoArrangeWordListColumns(searchResultList);

            Rectangle wordTreeRect = WordPadTree.Bounds;
            wordTreeRect.Height = mainRect.Bottom - 3 - WordPadTree.Bounds.Y;
            WordPadTree.Bounds = wordTreeRect;
        }

        private void contextMenuWord_Opened(object sender, EventArgs e)
        {
            moveToToolStripMenuItem.DropDownItems.Clear();

            Dictionary<string, WordPad>.Enumerator i = m_wordPads.GetEnumerator();
            
            while (i.MoveNext())
            {
                if ( i.Current.Value != CurWordPad )
                {
                    ToolStripMenuItem item = new ToolStripMenuItem();
                    item.Text = i.Current.Value.Name;
                    item.Tag = i.Current.Value;
                    
                    moveToToolStripMenuItem.DropDownItems.Add(item);

                    item.Click += new EventHandler(this.contextMenuWord_ItemClicked);
                }
            }            
        }

        private void contextMenuWord_ItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = null;
            if (sender.GetType() == typeof(ToolStripMenuItem))
            {
                menuItem = (ToolStripMenuItem)sender;
            }

            if ( menuItem.Tag.GetType() == typeof(WordPad) )
            {
                WordPad destWordPad = (WordPad)menuItem.Tag;
                if (destWordPad == null)
                    return;

                if (WordList.SelectedItems.Count > 0)
                {
                    if (CurWordPad == null)
                        AddNewWordPad("Default", true);

                    foreach (ListViewItem item in WordList.SelectedItems)
                    {
                        NewWordItem word = (NewWordItem)item.Tag;
                        destWordPad.AddWord(word);
                        CurWordPad.Words.Remove(word);
                    }

                    foreach (ListViewItem item in WordList.SelectedItems)
                    {
                        WordList.Items.Remove(item);
                    }
                }
            }
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            SaveAllWordPads();
        }

        private void quizBtn_Click(object sender, EventArgs e)
        {
            QuizSetting settingDlg = new QuizSetting();
            settingDlg.ShowDialog(this);            
        }

        private void WordList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ActiveWordList.FocusedItem != null)
            {
                ListViewHitTestInfo hitInfo = ActiveWordList.HitTest(e.Location);
                if ( hitInfo.SubItem != null )
                {
                    NewWordItem wordItem = (NewWordItem)hitInfo.SubItem.Tag;
                    if (hitInfo.SubItem.Text == NewWordItem.ToProficiencyString(wordItem.Proficiency))
                    {
                        // modify proficiency
                        wordItem.IncProficiency();
                        hitInfo.SubItem.Text = NewWordItem.ToProficiencyString(wordItem.Proficiency);
                        return;
                    }
                }
                
                editToolStripMenuItemWord_Click(sender, e);
            }
        }

        private void timerSaveAll_Tick(object sender, EventArgs e)
        {
            SaveAllWordPads(true);
        }
    }
}
