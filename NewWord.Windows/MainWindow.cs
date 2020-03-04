using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewWord.Windows.TabControls;
using NewWords.Core.Manager;

namespace NewWord.Windows
{
    public partial class MainWindow : Form
    {
        private List<NewWords.Core.Model.WordCard> _words = new List<NewWords.Core.Model.WordCard>();
        private int _count = 0;
        private bool _isTest = false;
        private readonly Color _rememberColor = Color.CornflowerBlue;
        private readonly Color _forgotColor = Color.DarkViolet;
        private static readonly FileManager _fileManager = new FileManager();
        private static readonly WordsManager _wordsManager = new WordsManager();
        private readonly ReadCountBookSplit _readCountBookSplit = new ReadCountBookSplit(_fileManager, _wordsManager);

        private readonly DifficultyBookSplit
            _difficultyBookSplit = new DifficultyBookSplit(_fileManager, _wordsManager);

        private readonly WordCardManager _wordCardManager = new WordCardManager(_fileManager);
        private string _currentBook = string.Empty;

        private UserControl _cardTab = new CardTab();
        private UserControl _cardEndTab = new CardEndTab();
        private UserControl _wordTab = new WordTab();
        private UserControl _wordControlTab = new WordControlTab();
        private UserControl _booksTab = new BooksTab();

        public MainWindow()
        {
            TopMost = true;
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            tabCard.Controls.Add(_cardTab);
            tabAdd.Controls.Add(_wordTab);
            tabWordControl.Controls.Add(_wordControlTab);
            tabBooks.Controls.Add(_booksTab);
        }

        private void Window_Closing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
