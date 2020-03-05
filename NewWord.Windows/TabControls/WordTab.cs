using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewWords.Core;
using NewWords.Core.Manager;
using NewWords.Core.Model;

namespace NewWord.Windows.TabControls
{
    public partial class WordTab : UserControl
    {

        public event EventHandler UpdateWordEvent;

        public WordBook CurrentBook { get; set; } = null;
        public int EditWordIndex { get; set; }
        private readonly WordCardManager _wordCardManager;

        public WordTab(WordCardManager wordCardManager)
        {
            _wordCardManager = wordCardManager;
            InitializeComponent();
        }

        public void LoadWord(object sender, EventArgs e)
        {
            if (CurrentBook != null)
            {
                txtNewWord.Text = CurrentBook.WordCardList[EditWordIndex].Word;
                txtMeaning.Text = CurrentBook.WordCardList[EditWordIndex].Meaning;
                numDifficulty.Value = CurrentBook.WordCardList[EditWordIndex].Difficulty;
                btnUpdate.Visible = true;
                btnCancel.Visible = true;
            }
        }

        private void EmptyForm()
        {
            txtNewWord.Text = string.Empty;
            txtMeaning.Text = string.Empty;
            numDifficulty.Value = 4;
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            UpdateWordEvent?.Invoke(null, null);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            CurrentBook.WordCardList[EditWordIndex].Word = txtNewWord.Text;
            CurrentBook.WordCardList[EditWordIndex].Meaning = txtMeaning.Text;
            CurrentBook.WordCardList[EditWordIndex].Difficulty = (int)numDifficulty.Value;
            UpdateWordEvent?.Invoke(CurrentBook.WordCardList[EditWordIndex], null);
            EmptyForm();
        }
        private void Difficulty_OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && btnUpdate.Visible == false)
            {
                SaveWordCard();
                EmptyForm();
                txtNewWord.Focus();
            }
        }

        private void SaveWordCard()
        {
            if (string.IsNullOrEmpty(txtNewWord.Text)) return;
            var word = new NewWords.Core.Model.WordCard
            {
                Word = txtNewWord.Text,
                Meaning = txtMeaning.Text,
                Difficulty = (int)numDifficulty.Value
            };
            if (CurrentBook.BookName == Constants.BookName.NewWordBook)
            {
                CurrentBook.WordCardList.Add(word);
            }
            _wordCardManager.AddOneWord(word);
        }
    }
}
