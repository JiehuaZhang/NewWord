using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewWord.Windows.Model;
using NewWord.Windows.TabControls;
using NewWords.Core;
using NewWords.Core.Manager;

namespace NewWord.Windows
{
    public partial class MainWindow : Form
    {

        //Manager
        private static readonly FileManager _fileManager = new FileManager();
        private static readonly WordsManager _wordsManager = new WordsManager();
        private static readonly WordCardManager _wordCardManager = new WordCardManager(_fileManager);

        private readonly DifficultyBookSplit _difficultyBookSplit = new DifficultyBookSplit(_fileManager, _wordsManager);
        private readonly ReadCountBookSplit _readCountBookSplit = new ReadCountBookSplit(_fileManager, _wordsManager);

        private CardTab _cardTab = new CardTab(_fileManager);
        private CardEndTab _cardEndTab = new CardEndTab();
        private WordTab _wordTab = new WordTab(_wordCardManager);
        private WordControlTab _wordControlTab = new WordControlTab();
        private BooksTab _booksTab = new BooksTab(_fileManager);

        public MainWindow()
        {
            TopMost = true;
            InitializeComponent();
            _cardTab.EndCardEvent += CardEndEvent;
            _cardTab.EditWordEvent += WordEditEvent;
            _cardTab.EditWordEvent += _wordTab.LoadWord;
            _cardTab.EditWordEvent += ChangeTabToEdit;

            _wordTab.UpdateWordEvent += _cardTab.UpdateOneWord;
            _wordTab.UpdateWordEvent += LoadAndTurnToTabCard_Event;

            _cardEndTab.TestModeEvent += _cardTab.CardLoadAgain;
            _cardEndTab.TestModeEvent += LoadTabCard_Event;



            _booksTab.ChooseBookEvent += LoadAndTurnToTabCard_Event;
            _booksTab.InitializeCardEvent += _cardTab.CardInitialization;
        }

        private void Window_Load(object sender, EventArgs e)
        {
            tabCard.Controls.Add(_cardTab);
            tabAdd.Controls.Add(_wordTab);
            tabWordControl.Controls.Add(_wordControlTab);
            tabBooks.Controls.Add(_booksTab);
            tabControls.SelectedTab = tabBooks;
        }

        private void Window_Closing(object sender, FormClosingEventArgs e)
        {
            if (_cardTab.CurrentBook.WordCardList.Count > 0) _fileManager.SaveJsonToFile(_cardTab.CurrentBook.BookPath, _cardTab.CurrentBook.WordCardJsonString);
            _fileManager.MergeWordToAll();
            _readCountBookSplit.SplitWordToBooks();
        }

        private void CardEndEvent(object sender, EventArgs e)
        {
            tabCard.Controls.Clear();
            _cardEndTab.CurrentBookName = _cardTab.CurrentBook.BookName;
            tabCard.Controls.Add(_cardEndTab);
            
        }

        private void WordEditEvent(object sender, EventArgs e)
        {
            if (sender != null)
            {
                var cardTabSender = (TabTransferDataModel)sender;
                _wordTab.CurrentBook = cardTabSender.CurrentBook;
                _wordTab.EditWordIndex = cardTabSender.RunningIndex;
            }
        }

        private void ChangeTabToEdit(object sender, EventArgs e)
        {
            tabControls.SelectedTab = tabAdd;
        }

        private void LoadAndTurnToTabCard_Event(object sender, EventArgs e)
        {
            _cardTab.CurrentBook = _booksTab.CurrentBook;
            _cardTab.IsTest = _cardEndTab.IsTest;
            tabCard.Controls.Clear();
            tabCard.Controls.Add(_cardTab);
            tabControls.SelectedTab = tabCard;
        }

        private void LoadTabCard_Event(object send, EventArgs e)
        {
            tabCard.Controls.Clear();
            tabCard.Controls.Add(_cardTab);
        }
    }
}
