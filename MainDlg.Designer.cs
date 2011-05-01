namespace XNewwordPadCS
{
    partial class MainDlg
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

        private void InitSingleWordList(System.Windows.Forms.ListView wordList)
        {

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDlg));
            this.WordList = new System.Windows.Forms.ListView();
            this.WordName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Announce = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Meaning = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Proficiency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuWord = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItemWord = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WordPadTree = new System.Windows.Forms.TreeView();
            this.contextMenuPad = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuWordPad = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchKeyEdit = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.NewWord = new System.Windows.Forms.Button();
            this.NewWordPad = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripCurWordPad = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelWordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuApp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.BtnImportKingsoft = new System.Windows.Forms.Button();
            this.openKingSoftFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.searchResultList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.quizBtn = new System.Windows.Forms.Button();
            this.timerSaveAll = new System.Windows.Forms.Timer(this.components);
            this.contextMenuWord.SuspendLayout();
            this.contextMenuPad.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.contextMenuApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // WordList
            // 
            this.WordList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.WordList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.WordName,
            this.Announce,
            this.Meaning,
            this.AddTime,
            this.Proficiency});
            this.WordList.ContextMenuStrip = this.contextMenuWord;
            this.WordList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WordList.FullRowSelect = true;
            this.WordList.GridLines = true;
            this.WordList.HotTracking = true;
            this.WordList.HoverSelection = true;
            resources.ApplyResources(this.WordList, "WordList");
            this.WordList.Name = "WordList";
            this.WordList.ShowItemToolTips = true;
            this.WordList.UseCompatibleStateImageBehavior = false;
            this.WordList.View = System.Windows.Forms.View.Details;
            this.WordList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.WordList_ColumnClick);
            this.WordList.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.WordList_ItemMouseHover);
            this.WordList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.WordList_MouseDoubleClick);
            // 
            // WordName
            // 
            resources.ApplyResources(this.WordName, "WordName");
            // 
            // Announce
            // 
            resources.ApplyResources(this.Announce, "Announce");
            // 
            // Meaning
            // 
            resources.ApplyResources(this.Meaning, "Meaning");
            // 
            // AddTime
            // 
            resources.ApplyResources(this.AddTime, "AddTime");
            // 
            // Proficiency
            // 
            resources.ApplyResources(this.Proficiency, "Proficiency");
            // 
            // contextMenuWord
            // 
            this.contextMenuWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItemWord,
            this.deleteToolStripMenuItem,
            this.moveToToolStripMenuItem});
            this.contextMenuWord.Name = "contextMenuWord";
            resources.ApplyResources(this.contextMenuWord, "contextMenuWord");
            this.contextMenuWord.Opened += new System.EventHandler(this.contextMenuWord_Opened);
            // 
            // editToolStripMenuItemWord
            // 
            this.editToolStripMenuItemWord.Name = "editToolStripMenuItemWord";
            resources.ApplyResources(this.editToolStripMenuItemWord, "editToolStripMenuItemWord");
            this.editToolStripMenuItemWord.Click += new System.EventHandler(this.editToolStripMenuItemWord_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItemWord_Click);
            // 
            // moveToToolStripMenuItem
            // 
            this.moveToToolStripMenuItem.Name = "moveToToolStripMenuItem";
            resources.ApplyResources(this.moveToToolStripMenuItem, "moveToToolStripMenuItem");
            // 
            // WordPadTree
            // 
            this.WordPadTree.ContextMenuStrip = this.contextMenuPad;
            this.WordPadTree.FullRowSelect = true;
            this.WordPadTree.HotTracking = true;
            this.WordPadTree.LabelEdit = true;
            resources.ApplyResources(this.WordPadTree, "WordPadTree");
            this.WordPadTree.Name = "WordPadTree";
            this.WordPadTree.ShowNodeToolTips = true;
            this.WordPadTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.PadTree_AfterLabelEdit);
            this.WordPadTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.WordPadTree_AfterSelect);
            // 
            // contextMenuPad
            // 
            this.contextMenuPad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.deleteToolStripMenuWordPad});
            this.contextMenuPad.Name = "contextMenuPad";
            resources.ApplyResources(this.contextMenuPad, "contextMenuPad");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Click += new System.EventHandler(this.hideWordPadTree);
            // 
            // deleteToolStripMenuWordPad
            // 
            this.deleteToolStripMenuWordPad.Name = "deleteToolStripMenuWordPad";
            resources.ApplyResources(this.deleteToolStripMenuWordPad, "deleteToolStripMenuWordPad");
            this.deleteToolStripMenuWordPad.Click += new System.EventHandler(this.deleteToolStripMenuWordPad_Click);
            // 
            // SearchKeyEdit
            // 
            resources.ApplyResources(this.SearchKeyEdit, "SearchKeyEdit");
            this.SearchKeyEdit.Name = "SearchKeyEdit";
            this.SearchKeyEdit.TextChanged += new System.EventHandler(this.SearchKeyEdit_TextChanged);
            // 
            // SearchBtn
            // 
            resources.ApplyResources(this.SearchBtn, "SearchBtn");
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // NewWord
            // 
            resources.ApplyResources(this.NewWord, "NewWord");
            this.NewWord.Name = "NewWord";
            this.NewWord.UseVisualStyleBackColor = true;
            this.NewWord.Click += new System.EventHandler(this.NewWord_Click);
            // 
            // NewWordPad
            // 
            resources.ApplyResources(this.NewWordPad, "NewWordPad");
            this.NewWordPad.Name = "NewWordPad";
            this.NewWordPad.UseVisualStyleBackColor = true;
            this.NewWordPad.Click += new System.EventHandler(this.NewWordPad_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripCurWordPad,
            this.toolStripStatusLabelWordCount});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            // 
            // statusStripCurWordPad
            // 
            this.statusStripCurWordPad.Name = "statusStripCurWordPad";
            resources.ApplyResources(this.statusStripCurWordPad, "statusStripCurWordPad");
            // 
            // toolStripStatusLabelWordCount
            // 
            this.toolStripStatusLabelWordCount.Name = "toolStripStatusLabelWordCount";
            resources.ApplyResources(this.toolStripStatusLabelWordCount, "toolStripStatusLabelWordCount");
            // 
            // contextMenuApp
            // 
            this.contextMenuApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.contextMenuApp.Name = "contextMenuApp";
            resources.ApplyResources(this.contextMenuApp, "contextMenuApp");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuApp_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toggleWordPadTreeShowMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuApp_Click);
            // 
            // BtnImportKingsoft
            // 
            resources.ApplyResources(this.BtnImportKingsoft, "BtnImportKingsoft");
            this.BtnImportKingsoft.Name = "BtnImportKingsoft";
            this.BtnImportKingsoft.UseVisualStyleBackColor = true;
            this.BtnImportKingsoft.Click += new System.EventHandler(this.BtnImportKingsoft_Click);
            // 
            // openKingSoftFileDlg
            // 
            this.openKingSoftFileDlg.FileName = "openKingSoftFileDlg";
            resources.ApplyResources(this.openKingSoftFileDlg, "openKingSoftFileDlg");
            this.openKingSoftFileDlg.Multiselect = true;
            this.openKingSoftFileDlg.RestoreDirectory = true;
            this.openKingSoftFileDlg.SupportMultiDottedExtensions = true;
            this.openKingSoftFileDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.openKingSoftFileDlg_FileOk);
            // 
            // searchResultList
            // 
            this.searchResultList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.searchResultList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.searchResultList.ContextMenuStrip = this.contextMenuWord;
            this.searchResultList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchResultList.FullRowSelect = true;
            this.searchResultList.GridLines = true;
            this.searchResultList.HotTracking = true;
            this.searchResultList.HoverSelection = true;
            resources.ApplyResources(this.searchResultList, "searchResultList");
            this.searchResultList.Name = "searchResultList";
            this.searchResultList.ShowItemToolTips = true;
            this.searchResultList.UseCompatibleStateImageBehavior = false;
            this.searchResultList.View = System.Windows.Forms.View.Details;
            this.searchResultList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.WordList_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // btnSaveAll
            // 
            resources.ApplyResources(this.btnSaveAll, "btnSaveAll");
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // quizBtn
            // 
            resources.ApplyResources(this.quizBtn, "quizBtn");
            this.quizBtn.Name = "quizBtn";
            this.quizBtn.UseVisualStyleBackColor = true;
            this.quizBtn.Click += new System.EventHandler(this.quizBtn_Click);
            // 
            // timerSaveAll
            // 
            this.timerSaveAll.Interval = 60000;
            this.timerSaveAll.Tick += new System.EventHandler(this.timerSaveAll_Tick);
            // 
            // MainDlg
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuApp;
            this.Controls.Add(this.quizBtn);
            this.Controls.Add(this.BtnImportKingsoft);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.NewWordPad);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.NewWord);
            this.Controls.Add(this.WordPadTree);
            this.Controls.Add(this.WordList);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchKeyEdit);
            this.Controls.Add(this.searchResultList);
            this.Name = "MainDlg";
            this.Resize += new System.EventHandler(this.MainDlg_Resize);
            this.contextMenuWord.ResumeLayout(false);
            this.contextMenuPad.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuApp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView WordList;
        private System.Windows.Forms.TreeView WordPadTree;
        private System.Windows.Forms.TextBox SearchKeyEdit;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button NewWord;
        private System.Windows.Forms.ColumnHeader WordName;
        private System.Windows.Forms.ColumnHeader Announce;
        private System.Windows.Forms.ColumnHeader Meaning;
        private System.Windows.Forms.ColumnHeader AddTime;
        private System.Windows.Forms.ColumnHeader Proficiency;
        private System.Windows.Forms.Button NewWordPad;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuWord;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItemWord;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuPad;
        private System.Windows.Forms.ContextMenuStrip contextMenuApp;
        private System.Windows.Forms.ToolTip wordTooltip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuWordPad;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripStatusLabel statusStripCurWordPad;
        private System.Windows.Forms.Button BtnImportKingsoft;
        private System.Windows.Forms.OpenFileDialog openKingSoftFileDlg;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelWordCount;
        private System.Windows.Forms.ListView searchResultList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Button quizBtn;
        private System.Windows.Forms.Timer timerSaveAll;
    }
}

