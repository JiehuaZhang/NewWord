using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NewWords.Core.Model;

namespace NewWords.Core.Manager
{
    public class ReadCountBookSplit
    {
        private readonly FileManager _fileManager;
        private readonly WordsManager _wordsManager;

        public ReadCountBookSplit(FileManager fileManager, WordsManager wordsManager)
        {
            _fileManager = fileManager;
            _wordsManager = wordsManager;
        }

        public void SplitWordToBooks()
        {
            var allWords = _fileManager.GetWordList(Constants.Book.AllWordFilePath);
            var word10 = allWords.Where(x => x.Count <= 10).Select(x => x).ToList();
            var word20 = allWords.Where(x => x.Count <= 20 && x.Count > 10 ).Select(x => x).ToList();
            var word30 = allWords.Where(x => x.Count <= 30 && x.Count > 20).ToList();
            var word40 = allWords.Where(x => x.Count <= 40 && x.Count > 30 ).Select(x => x).ToList();
            var word50 = allWords.Where(x => x.Count > 40).Select(x => x).ToList();

            _fileManager.DeleteAllFilesInFolder(new DirectoryInfo(Constants.Book.BookPath));

            var word10Books = _wordsManager.SplitWordToBooks(word10, "Word_10");
            var word20Books = _wordsManager.SplitWordToBooks(word20, "Word_20");
            var word30Books = _wordsManager.SplitWordToBooks(word30, "Word_30");
            var word40Books = _wordsManager.SplitWordToBooks(word40, "Word_40");
            var word50Books = _wordsManager.SplitWordToBooks(word50, "Word_50");

            _fileManager.SaveBook(word10Books);
            _fileManager.SaveBook(word20Books);
            _fileManager.SaveBook(word30Books);
            _fileManager.SaveBook(word40Books);
            _fileManager.SaveBook(word50Books);

        }
    }
}
