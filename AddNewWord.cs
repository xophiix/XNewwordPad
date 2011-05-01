using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XNewwordPadCS
{
    public partial class AddNewWord : Form
    {
        public AddNewWord()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            NewWordItem newWord = new NewWordItem();

            if ( WordNameEdit.Text.Length == 0 )
            {                
                MessageBox.Show("Must Enter The Word!");
                return;
            }

            newWord.Name = WordNameEdit.Text;
            newWord.Annoucement = AnnoucementEdit.Text;
            newWord.Meaning = MeaningRichEdit.Text;

            MainDlg.Instance.AddNewWord( MainDlg.Instance.CurWordPad, newWord);
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
