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
using NewWords.Core.Model;

namespace NewWord.Windows.TabControls
{
    public partial class CardTab : UserControl
    {
        public WordBook CurrentBook { get; set; }
        public bool IsTest { get; set; }
        private int _count;
        private readonly Color _rememberColor = Color.CornflowerBlue;
        private readonly Color _forgotColor = Color.DarkViolet;
        public CardTab()
        {
            InitializeComponent();
        }

        #region Event

        private void BtnNo_Click(object sender, EventArgs e)
        {
            CurrentBook.WordCardList[_count].Remember = false;
            CurrentBook.WordCardList[_count].Count++;
            if (IsTest)
                txtWord.Visible = true;
            else
                lblHidden.Visible = true;
            btnYes.Visible = false;
            btnNo.Visible = false;
        }

        private void BtnAgain_Click(object sender, EventArgs e)
        {
            IsTest = false;
            CardBeginning();
        }
        private void BtnTest_Click(object sender, EventArgs e)
        {
            IsTest = true;
            CardBeginning();
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
            CurrentBook.WordCardList[_count].Remember = true;
            if (IsTest)
                await Task.Delay(1000);
            else
                await Task.Delay(500);
            CurrentBook.WordCardList[_count].Count++;
            if (_count == CurrentBook.WordCardList.Count - 1)
            {
                TheEnd();
            }
            else
            {
                _count++;
                ShowWordCard();
            }

        }

        private void TxtWord_Click(object sender, EventArgs e)
        {
            

        }
        private void LblPrevious_Click(object sender, EventArgs e)
        {
            _count--;
            ShowWordCard();
        }

        private void LblNext_Click(object sender, EventArgs e)
        {
            _count++;
            if (_count == CurrentBook.WordCardList.Count)
            {
                TheEnd();
            }
            else
            {
                ShowWordCard();
            }
        }

        #endregion

        #region Function
        private void ShowWordCard()
        {
            txtWord.Text = CurrentBook.WordCardList[_count].Word;
            txtWord.ForeColor = CurrentBook.WordCardList[_count].Remember ? _rememberColor : _forgotColor;
            lblDifficulty.Text = new string('*', CurrentBook.WordCardList[_count].Difficulty);
            lblHidden.Text = CurrentBook.WordCardList[_count].Meaning;
            lblBookName.Text = CurrentBook.BookName;
            lblIndex.Text = (_count + 1) + "/" + CurrentBook.WordCardList.Count;
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
            lblPrevious.Visible = _count != 0;
            lblCount.Text = CurrentBook.WordCardList[_count].Count.ToString();
        }
        private void TheEnd()
        {
            btnNo.Visible = false;
            btnYes.Visible = false;
            lblHidden.Visible = false;
            lblDifficulty.Visible = false;
            lblIndex.Visible = false;
            lblNext.Visible = false;
            lblPrevious.Visible = false;
            lblCount.Visible = false;
            txtWord.ForeColor = Color.Black;
            txtWord.Text = Constants.FormText.TheEnd;
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
            _count = 0;
            ShowWordCard();
        }

        #endregion
    }
}
