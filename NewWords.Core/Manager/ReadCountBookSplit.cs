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
            var word10 = allWords.Where(x => x.Count <= 10 && x.Difficulty <5).Select(x => x).ToList();
            var word20 = allWords.Where(x => x.Count <= 20 && x.Count > 10 && x.Difficulty < 5).Select(x => x).ToList();
            var word30 = allWords.Where(x => x.Count <= 30 && x.Count > 20 && x.Difficulty < 5).Select(x => x).ToList();
            var word40 = allWords.Where(x => x.Count <= 40 && x.Count > 30 && x.Difficulty < 5).Select(x => x).ToList();
            var word50 = allWords.Where(x => (x.Count <= 50 && x.Count > 40 && x.Difficulty < 5) || (x.Count > 50 && x.Difficulty < 5)).Select(x => x).ToList();
            var hardWord = allWords.Where(x => x.Difficulty == 5).Select(x => x).ToList();

            _fileManager.DeleteAllFilesInFolder(new DirectoryInfo(Constants.Book.BookPath));

            var word10StringList = _wordsManager.SplitWordList(word10);
            var word20StringList = _wordsManager.SplitWordList(word20);
            var word30StringList = _wordsManager.SplitWordList(word30);
            var word40StringList = _wordsManager.SplitWordList(word40);
            var word50StringList = _wordsManager.SplitWordList(word50);
            var hardWordStringList = _wordsManager.SplitWordList(hardWord);

            _fileManager.SaveBooks(word10StringList,Constants.Book.BookPath + "Word_10");
            _fileManager.SaveBooks(word20StringList, Constants.Book.BookPath + "Word_20");
            _fileManager.SaveBooks(word30StringList, Constants.Book.BookPath + "Word_30");
            _fileManager.SaveBooks(word40StringList, Constants.Book.BookPath + "Word_40");
            _fileManager.SaveBooks(word50StringList, Constants.Book.BookPath + "Word_50");
            _fileManager.SaveBooks(hardWordStringList, Constants.Book.BookPath + "HardWord");
        }
    }
}
