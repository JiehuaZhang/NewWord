using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
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
    public partial class WordControlTab : UserControl
    {
        public event EventHandler LoadNewBookToCardEvent;

        private readonly FileManager _fileManager;
        private readonly ReadCountBookSplit _readCountBookSplit;
        private readonly DifficultyBookSplit _difficultyBookSplit;

        public WordBook CurrentBook { get; set; }

        public WordControlTab(FileManager fileManager, ReadCountBookSplit readCountBookSplit, DifficultyBookSplit difficultyBookSplit)
        {
            _fileManager = fileManager;
            _readCountBookSplit = readCountBookSplit;
            _difficultyBookSplit = difficultyBookSplit;
            InitializeComponent();
        }


        private void BtnArrange1_Click(object sender, EventArgs e)
        {
            _fileManager.SaveJsonToFile(CurrentBook.BookPath, CurrentBook.WordCardJsonString);
            _fileManager.MergeWordToAll();
            var allWord = _fileManager.GetWordList(Constants.Book.AllWordFilePath);
            var rememberWordsString = allWord.Where(x => x.Remember && x.Count >= 50 || x.Difficulty == 0).Select(x => x).ToList().ToJsonString();
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
                CurrentBook.WordCardList = _fileManager.GetWordList(CurrentBook.BookPath);
                LoadNewBookToCardEvent?.Invoke(new TabTransferDataModel(CurrentBook,"WordControl"), null);
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
            if (CurrentBook != null && CurrentBook.WordCardList.Count>0 )
                _fileManager.SaveJsonToFile(Constants.Book.BookPath + CurrentBook.BookName , CurrentBook.WordCardJsonString);
            _fileManager.MergeWordToAll();
            _readCountBookSplit.SplitWordToBooks();

            lblSplit.Text = Constants.BuildArrangeText(Constants.FormText.TaskCompleteText);
            lblSplit.Visible = true;

            if (File.Exists(Constants.Book.BookPath + CurrentBook.BookName))
            {
                CurrentBook.WordCardList = _fileManager.GetWordList(Constants.Book.BookPath + CurrentBook.BookName);
            }
            else
            {
                var files = _fileManager.GetFiles();
                CurrentBook.BookName = files.Length > 0 ? files[0] : string.Empty;
                CurrentBook.WordCardList = string.IsNullOrEmpty(CurrentBook.BookName)
                    ? new List<NewWords.Core.Model.WordCard>()
                    : _fileManager.GetWordList(Constants.Book.BookPath + files[0]);
            }
            LoadNewBookToCardEvent?.Invoke(new TabTransferDataModel(CurrentBook,0,"SplitBooks"),null );
        }

        private void BtnSplitByDifficulty_Click(object sender, EventArgs e)
        {
            if (CurrentBook != null && CurrentBook.WordCardList.Count > 0)
                _fileManager.SaveJsonToFile(Constants.Book.BookPath + CurrentBook.BookName, CurrentBook.WordCardJsonString);
            _fileManager.MergeWordToAll();
            _difficultyBookSplit.SplitWordToBooks();

            lblSplit.Text = Constants.BuildArrangeText(Constants.FormText.TaskCompleteText);
            lblSplit.Visible = true;

            if (File.Exists(Constants.Book.BookPath + CurrentBook.BookName))
            {
                CurrentBook.WordCardList = _fileManager.GetWordList(Constants.Book.BookPath + CurrentBook.BookName);
            }
            else
            {
                var files = _fileManager.GetFiles();
                CurrentBook.BookName = files.Length > 0 ? files[0] : string.Empty;
                CurrentBook.WordCardList = string.IsNullOrEmpty(CurrentBook.BookName)
                    ? new List<NewWords.Core.Model.WordCard>()
                    : _fileManager.GetWordList(Constants.Book.BookPath + files[0]);
            }
            LoadNewBookToCardEvent?.Invoke(new TabTransferDataModel(CurrentBook, 0, "SplitBooks"), null);
        }
    }
}
