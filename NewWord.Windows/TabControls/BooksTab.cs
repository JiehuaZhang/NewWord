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
    public partial class BooksTab : UserControl
    {
        public event EventHandler ChooseBookEvent;
        public event EventHandler InitializeCardEvent;
        public WordBook CurrentBook { get; set; }  = new WordBook(null, null ,null);
        private readonly FileManager _fileManager;
        private bool _IsBegining;

        private TreeNode _treeNode;
        public BooksTab(FileManager fileManager)
        {
            _fileManager = fileManager;
            InitializeComponent();
        }

        private void BooksTab_Load(object sender, EventArgs e)
        {
            GetAllBooks();
        }
        public void GetAllBooks()
        {
            var files = _fileManager.GetFiles();
            List<TreeNode> nodeList = new List<TreeNode>();
            if (files != null && files.Length > 0)
            {
                foreach (var file in files)
                {
                    nodeList.Add(new TreeNode(file));
                }

                if (string.IsNullOrEmpty(CurrentBook.BookName))
                {
                    CurrentBook.WordCardList = _fileManager.GetWordList(Constants.Book.BookPath + files[0]);
                    CurrentBook.BookName = files[0];
                    lblCurrentBook.Text = files[0];
                    _IsBegining = true;
                }
            }
            treeBooks.Nodes.Clear();
            _treeNode = new TreeNode("Books", nodeList.ToArray());
            treeBooks.Nodes.Add(_treeNode);
            treeBooks.ExpandAll();

        }

        private void Book_Select(object sender, MouseEventArgs e)
        {
            CurrentBook.BookName = treeBooks.SelectedNode.Text;
            CurrentBook.WordCardList = _fileManager.GetWordList(CurrentBook.BookPath);
            lblCurrentBook.Text = treeBooks.SelectedNode.Text;
            ChooseBookEvent?.Invoke(new TabTransferDataModel(CurrentBook, "Books"), null);
        }

        private void Book_Leave(object sender, EventArgs e)
        {
            if (!_IsBegining) return;
            _IsBegining = false;
            InitializeCardEvent?.Invoke(new TabTransferDataModel(CurrentBook,  "Books"), null);
        }
    }
}
