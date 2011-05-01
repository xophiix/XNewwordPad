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
    public partial class EditWord : Form
    {
        private NewWordItem m_editingWord;
        private ListViewItem m_associateItemActive, m_associateItemInactive;
        public EditWord(NewWordItem word, ListViewItem associateItemActive, ListViewItem associateItemInactive )
        {
            InitializeComponent();
            
            m_editingWord = word;
            m_associateItemActive = associateItemActive;
            m_associateItemInactive = associateItemInactive;

            WordNameEdit.Text = m_editingWord.Name;
            AnnoucementEdit.Text = m_editingWord.Annoucement;
            MeaningRichEdit.Text = m_editingWord.Meaning;

            for (int i = 0; i < (int)NewWordItem.ProficiencyLevel.ProficiencyLevelCount; i++)
            {
                this.proficiencyCombobox.Items.Add(NewWordItem.ToProficiencyString((NewWordItem.ProficiencyLevel)i));
            }

            proficiencyCombobox.SelectedIndex = (int)m_editingWord.Proficiency;
        }

        private void UpdateAssociateListItem(ListViewItem listItem)
        {
            if (listItem == null)
                return;

            listItem.SubItems.Clear();
            listItem.Text = m_editingWord.Name;
            listItem.SubItems.Add(m_editingWord.Annoucement);
            listItem.SubItems.Add(m_editingWord.Meaning);
            listItem.SubItems.Add(m_editingWord.AddTime.ToString());
            listItem.SubItems.Add(NewWordItem.ToProficiencyString(m_editingWord.Proficiency));
        }

        private void Confirm_Click(object sender, EventArgs e)
        {            
            if (WordNameEdit.Text.Length == 0)
            {
                MessageBox.Show("Must Enter The Word!");
                return;
            }

            m_editingWord.Name = WordNameEdit.Text;
            m_editingWord.Annoucement = AnnoucementEdit.Text;
            m_editingWord.Meaning = MeaningRichEdit.Text;
            m_editingWord.Proficiency = (NewWordItem.ProficiencyLevel)proficiencyCombobox.SelectedIndex;

            UpdateAssociateListItem(m_associateItemActive);
            UpdateAssociateListItem(m_associateItemInactive);

            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
