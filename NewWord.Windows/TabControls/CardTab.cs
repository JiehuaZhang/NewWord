using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewWord.Windows.Model;
using NewWords.Core;
using NewWords.Core.Manager;
using NewWords.Core.Model;

namespace NewWord.Windows.TabControls
{
    public partial class CardTab : UserControl
    {
        public event EventHandler EndCardEvent;
        public event EventHandler EditWordEvent;

        private readonly FileManager _fileManager;
        public WordBook CurrentBook { get; set; } = new WordBook(null, null, null);
        public bool IsTest { get; set; }
        public int WordIndex;
        private readonly Color _rememberColor = Color.CornflowerBlue;
        private readonly Color _forgotColor = Color.DarkViolet;
        public CardTab(FileManager fileManager)
        {
            _fileManager = fileManager;
            InitializeComponent();
        }


        private void CardTab_Load(object sender, EventArgs e)
        {
            if (CurrentBook.WordCardList.Count == 0)
                NoNewWord();
            else
                CardBeginning();
        }

        #region Event
        private void BtnNo_Click(object sender, EventArgs e)
        {
            CurrentBook.WordCardList[WordIndex].Remember = false;
            CurrentBook.WordCardList[WordIndex].Count++;
            if (IsTest)
                txtWord.Visible = true;
            else
                lblHidden.Visible = true;
            btnYes.Visible = false;
            btnNo.Visible = false;
        }


        private async void BtnYes_Click(object sender, EventArgs e)
        {
            if (IsTest)
                txtWord.Visible = true;
            else
                lblHidden.Visible = true;
            btnYes.Visible = false;
            btnNo.Visible = false;
            lblNext.Visible = false;
            lblPrevious.Visible = false;
            CurrentBook.WordCardList[WordIndex].Remember = true;
            if (IsTest)
                await Task.Delay(1000);
            else
                await Task.Delay(500);
            CurrentBook.WordCardList[WordIndex].Count++;
            if (WordIndex == CurrentBook.WordCardList.Count - 1)
            {
                _fileManager.SaveJsonToFile(CurrentBook.BookPath, CurrentBook.WordCardJsonString);
                EndCardEvent?.Invoke(new TabTransferDataModel(CurrentBook, "Card"), e);
            }
            else
            {
                WordIndex++;
                ShowWordCard();
            }

        }

        private void TxtWord_Click(object sender, EventArgs e)
        {
            EditWordEvent?.Invoke(this, null);
        }
        private void LblPrevious_Click(object sender, EventArgs e)
        {
            WordIndex--;
            ShowWordCard();
        }

        private void LblNext_Click(object sender, EventArgs e)
        {
            WordIndex++;
            if (WordIndex == CurrentBook.WordCardList.Count)
            {
                
                EndCardEvent?.Invoke(new TabTransferDataModel(CurrentBook,"Card"), e);
            }
            else
            {
                ShowWordCard();
            }
        }

        private void LabelChangeColor_MouseHover(object sender, EventArgs e)
        {
            var label = (Label)sender;
            label.BackColor = Color.DarkGoldenrod;
            label.ForeColor = Color.White;
        }

        private void LabelChangeColor_MouseLeave(object sender, EventArgs e)
        {
            var label = (Label)sender;
            label.BackColor = Color.White;
            label.ForeColor = Color.Black;
        }

        #endregion

        #region Function
        private void ShowWordCard()
        {
            txtWord.Text = CurrentBook.WordCardList[WordIndex].Word;
            txtWord.ForeColor = CurrentBook.WordCardList[WordIndex].Remember ? _rememberColor : _forgotColor;
            lblDifficulty.Text = new string('*', CurrentBook.WordCardList[WordIndex].Difficulty);
            lblHidden.Text = CurrentBook.WordCardList[WordIndex].Meaning;
            lblBookName.Text = CurrentBook.BookName;
            lblIndex.Text = (WordIndex + 1) + "/" + CurrentBook.WordCardList.Count;
            btnYes.Visible = true;
            btnYes.Text = Constants.FormText.Yes;
            btnNo.Text = Constants.FormText.No;
            btnNo.Visible = true;
            lblDifficulty.Visible = true;
            lblHidden.Visible = IsTest;
            txtWord.Visible = !IsTest;
            lblIndex.Visible = true;
            lblCount.Visible = true;
            btnNo.Enabled = true;
            lblNext.Visible = true;
            lblPrevious.Visible = WordIndex != 0;
            lblCount.Text = CurrentBook.WordCardList[WordIndex].Count.ToString();
        }
        private void TheEnd()
        {
           
        }
        private void NoNewWord()
        {
            btnNo.Visible = false;
            btnYes.Visible = false;
            lblDifficulty.Visible = false;
            lblIndex.Visible = false;
            txtWord.Text = Constants.FormText.NoWord;
        }
        private void CardBeginning()
        {
            WordIndex = 0;
            ShowWordCard();
        }

        public void CardInitialization(object sender, EventArgs e)
        {
            if (sender != null)
            {
                var currentBook = (WordBook) sender;
                CurrentBook = currentBook;
                WordIndex = 0;
                ShowWordCard();
            }
           
            
        }

        public void CardLoadAgain(object sender, EventArgs e)
        {
            if (sender != null)
            {
                var transferData = (TabTransferDataModel) sender;
                IsTest = transferData.IsTestMode;
                WordIndex = transferData.RunningIndex;
                ShowWordCard();
            }
        }

        public void UpdateOneWord(object sender, EventArgs e)
        {
            if (sender != null)
            {
                var senderData = (TabTransferDataModel)sender;
                CurrentBook.WordCardList[WordIndex].Word = senderData.CurrentBook.WordCardList[senderData.RunningIndex].Word;
                CurrentBook.WordCardList[WordIndex].Meaning = senderData.CurrentBook.WordCardList[senderData.RunningIndex].Meaning;
                CurrentBook.WordCardList[WordIndex].Difficulty = senderData.CurrentBook.WordCardList[senderData.RunningIndex].Difficulty;
                ShowWordCard();
            }
        }

        #endregion

        
    }
}
