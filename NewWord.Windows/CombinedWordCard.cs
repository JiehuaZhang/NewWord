using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using NewWords.Core;
using NewWords.Core.Manager;

namespace NewWord.Windows
{
    public partial class CombinedWordCard : Form
    {
        private List<NewWords.Core.Model.WordCard> _words = new List<NewWords.Core.Model.WordCard>();
        private int _count = 0;
        private readonly Color _rememberColor = Color.CornflowerBlue;
        private readonly Color _forgotColor = Color.DarkViolet;
        private static readonly FileManager _fileManager = new FileManager();
        private static readonly WordsManager _wordsManager = new WordsManager();
        private readonly ReadCountBookSplit _readCountBookSplit = new ReadCountBookSplit(_fileManager,_wordsManager);
        private readonly DifficultyBookSplit _difficultyBookSplit = new DifficultyBookSplit(_fileManager, _wordsManager);
        private readonly WordCardManager _wordCardManager = new WordCardManager(_fileManager);
        private string _currentBook = string.Empty;

        public CombinedWordCard()
        {
            TopMost = true;
            InitializeComponent();
        }
        private void WordCard_Load(object sender, EventArgs e)
        {
            GetAllBooks();
            tabControl1.SelectedTab = tabBooks;
            
            if (_words.Count == 0)
                NoNewWord();
            else
                CardBeginning();
        }
        private void Card_Closing(object sender, FormClosingEventArgs e)
        {
            if(_words.Count>0) _fileManager.SaveJsonToFile(Constants.Book.BookPath + _currentBook,_words.ToJsonString());
            _fileManager.MergeWordToAll();
            _readCountBookSplit.SplitWordToBooks();
        }

        #region Card

        #region Event

        private void BtnNo_Click(object sender, EventArgs e)
        {
                _words[_count].Remember = false;
                _words[_count].Count++;
                lblHidden.Visible = true;
                btnYes.Visible = false;
                btnNo.Visible = false;
        }

        private void BtnAgain_Click(object sender, EventArgs e)
        {
            CardBeginning();
        }

        private async void BtnYes_Click(object sender, EventArgs e)
        {
            lblHidden.Visible = true;
            btnYes.Visible = false;
            btnNo.Visible = false;
            lblNext.Visible = false;
            lblPrevious.Visible = false;
            _words[_count].Remember = true;
            await Task.Delay(800);
            _words[_count].Count++;
            if (_count == _words.Count - 1)
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
            tabControl1.SelectedTab = tabAdd;
            txtNewWord.Text = _words[_count].Word;
            txtMeaning.Text = _words[_count].Meaning;
            numDifficulty.Value = _words[_count].Difficulty;
            btnUpdate.Visible = true;
        }
        private void LblPrevious_Click(object sender, EventArgs e)
        {
            _count--;
            ShowWordCard();
        }

        private void LblNext_Click(object sender, EventArgs e)
        {
            _count++;
            if (_count == _words.Count)
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
            txtWord.Text = _words[_count].Word;
            txtWord.ForeColor = _words[_count].Remember ? _rememberColor : _forgotColor;
            lblDifficulty.Text = new string('*', _words[_count].Difficulty);
            lblHidden.Text = _words[_count].Meaning;
            lblBookName.Text = _currentBook;
            lblIndex.Text = (_count+1) + "/" + _words.Count;
            btnYes.Visible = true;
            btnYes.Text = Constants.FormText.Yes;
            btnNo.Text = Constants.FormText.No;
            btnNo.Visible = true;
            lblDifficulty.Visible = true;
            btnAgain.Visible = false;
            lblHidden.Visible = false;
            lblIndex.Visible = true;
            lblCount.Visible = true;
            btnNo.Enabled = true;
            lblNext.Visible = true;
            lblPrevious.Visible = _count !=0;
            lblCount.Text = _words[_count].Count.ToString();
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
            btnAgain.Visible = _words.Count > 0;
        }
        private void NoNewWord()
        {
            btnNo.Visible = false;
            btnYes.Visible = false;
            btnAgain.Visible = false;
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

        #endregion

        #region Add

        #region Event

        private void TabAdd_Click(object sender, EventArgs e)
        {
            txtNewWord.Focus();
        }
        private void SaveWordCard()
        {
            if (string.IsNullOrEmpty(txtNewWord.Text)) return;
            var word = new NewWords.Core.Model.WordCard
            {
                Word = txtNewWord.Text, Meaning = txtMeaning.Text, Difficulty = (int) numDifficulty.Value
            };
            if (_currentBook == Constants.BookName.NewWordBook)
            {
                _words.Add(word);
            }
            _wordCardManager.AddOneWord(word);
        }
        private void Difficulty_OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && btnUpdate.Visible == false)
            {
                SaveWordCard();
                txtNewWord.Text = string.Empty;
                txtMeaning.Text = string.Empty;
                numDifficulty.Value = 4;
                txtNewWord.Focus();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _words[_count].Word = txtNewWord.Text;
            _words[_count].Meaning = txtMeaning.Text;
            _words[_count].Difficulty = (int) numDifficulty.Value;
            txtNewWord.Text = string.Empty;
            txtMeaning.Text = string.Empty;
            numDifficulty.Value = 4;
            btnUpdate.Visible = false;
            tabControl1.SelectedTab = tabCard;
            _fileManager.SaveJsonToFile(Constants.Book.BookPath + _currentBook, _words.ToJsonString());
            ShowWordCard();
        }

        #endregion
       

        #region Functions

        

        #endregion

        #endregion

        #region Arrange

        #region Event

        private void BtnArrange1_Click(object sender, EventArgs e)
        {
            _fileManager.SaveJsonToFile(Constants.Book.BookPath + _currentBook,_words.ToJsonString());
            _fileManager.MergeWordToAll();
            var allWord = _fileManager.GetWordList(Constants.Book.AllWordFilePath);
            var rememberWordsString = allWord.Where(x => x.Remember && x.Count >= 50 || x.Difficulty == 0).Select(x=>x).ToList().ToJsonString();
            allWord.RemoveAll(x => x.Remember && x.Count >= 50 || x.Difficulty == 0);
            _fileManager.SaveJsonToFile(Constants.Book.AllWordFilePath, allWord.ToJsonString());
            _readCountBookSplit.SplitWordToBooks();
            var rememberWordFilePath = Constants.BuildOkWordBookFilePath();
            if (!File.Exists(rememberWordFilePath) && !string.IsNullOrWhiteSpace(rememberWordsString))
            {
                using (var sw = File.CreateText(rememberWordFilePath))
                {
                    sw.Write(rememberWordsString + ",");
                }
            }

            if (!string.IsNullOrWhiteSpace(rememberWordsString))
            {
                File.AppendAllText(rememberWordFilePath, rememberWordsString);
                _words = _fileManager.GetWordList(Constants.Book.BookPath + _currentBook);
                CardBeginning();
                lblArrange1.Visible = true;
                lblArrange1.Text = Constants.BuildArrangeText(Constants.FormText.TaskCompleteText);
            }
            else
            {
                lblArrange1.Visible = true;
                lblArrange1.Text = Constants.BuildArrangeText(Constants.FormText.NoRememberWord);
            }
        }
        private void BtnSplitWords_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(_currentBook) && _words.Count>0)
                _fileManager.SaveJsonToFile(Constants.Book.BookPath + _currentBook, _words.ToJsonString());
            _fileManager.MergeWordToAll();
            _readCountBookSplit.SplitWordToBooks();

            lblSplit.Text = Constants.BuildArrangeText(Constants.FormText.TaskCompleteText);
            lblSplit.Visible = true;

            if(File.Exists(Constants.Book.BookPath + _currentBook))
            { 
                _words = _fileManager.GetWordList(Constants.Book.BookPath + _currentBook);
            }
            else
            {
                var files = _fileManager.GetFiles();
                _currentBook = files.Length > 0 ? files[0] : string.Empty;
                _words = string.IsNullOrEmpty(_currentBook)
                    ? new List<NewWords.Core.Model.WordCard>()
                    : _fileManager.GetWordList(Constants.Book.BookPath + files[0]);
            }
            CardBeginning();
        }

        private void BtnSplitByDifficulty_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentBook) && _words.Count > 0)
                _fileManager.SaveJsonToFile(Constants.Book.BookPath + _currentBook, _words.ToJsonString());
            _fileManager.MergeWordToAll();
            _difficultyBookSplit.SplitWordToBooks();

            lblSplityByDifficulty.Text = Constants.BuildArrangeText(Constants.FormText.TaskCompleteText);
            lblSplityByDifficulty.Visible = true;

            if (File.Exists(Constants.Book.BookPath + _currentBook))
            {
                _words = _fileManager.GetWordList(Constants.Book.BookPath + _currentBook);
            }
            else
            {
                var files = _fileManager.GetFiles();
                _currentBook = files.Length > 0 ? files[0] : string.Empty;
                _words = string.IsNullOrEmpty(_currentBook)
                    ? new List<NewWords.Core.Model.WordCard>()
                    : _fileManager.GetWordList(Constants.Book.BookPath + files[0]);
            }
            CardBeginning();
        }

        #endregion

        #region Function

        #endregion

        #endregion

        #region Book

        #region Event

        private void Book_Fresh(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_currentBook))
            {
                _fileManager.SaveJsonToFile(Constants.Book.BookPath + _currentBook, _words.ToJsonString());
            }
            treeBooks.Nodes.Clear();
            GetAllBooks();
            lblCurrentBook.Text = _currentBook;
        }


        private void Book_Select(object sender, MouseEventArgs e)
        {
            _currentBook = treeBooks.SelectedNode.Text;
            _words = _fileManager.GetWordList(Constants.Book.BookPath + _currentBook);
            CardBeginning();
            tabControl1.SelectedTab = tabCard;
            lblCurrentBook.Text = _currentBook;
        }

        #endregion

        #region Function

        private void GetAllBooks()
        {
            var files = _fileManager.GetFiles();
            List<TreeNode> nodeList = new List<TreeNode>();
            if (files != null && files.Length > 0)
            {
                foreach (var file in files)
                {
                    nodeList.Add(new TreeNode(file));
                }

                if (string.IsNullOrEmpty(_currentBook))
                {
                    _words = _fileManager.GetWordList(Constants.Book.BookPath + files[0]);
                    _currentBook = files[0];
                }
                    
            }

            var treeNode = new TreeNode("Books", nodeList.ToArray());
            treeBooks.Nodes.Add(treeNode);
            treeBooks.ExpandAll();

        }



        #endregion

        #endregion

        private void LabelChangeColor_MouseHover(object sender, EventArgs e)
        {
            var label = (Label) sender;
            label.BackColor = Color.DarkGoldenrod;
            label.ForeColor = Color.White;
        }

        private void LabelChangeColor_MouseLeave(object sender, EventArgs e)
        {
            var label = (Label)sender;
            label.BackColor = Color.White;
            label.ForeColor = Color.Black;
        }
    }
}