using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWords.Core.Manager
{
    public class DifficultyBookSplit
    {
        private readonly FileManager _fileManager;
        private readonly WordsManager _wordsManager;

        public DifficultyBookSplit(FileManager fileManager, WordsManager wordsManager)
        {
            _fileManager = fileManager;
            _wordsManager = wordsManager;
        }

        public void SplitWordToBooks()
        {
            var allWords = _fileManager.GetWordList(Constants.Book.AllWordFilePath);
            var word0 = allWords.Where(x => x.Difficulty == 0 && !x.IsFamiliar).Select(x => x).ToList();
            var word1 = allWords.Where(x => x.Difficulty == 1 && !x.IsFamiliar).Select(x => x).ToList();
            var word2 = allWords.Where(x => x.Difficulty == 2 && !x.IsFamiliar).Select(x => x).ToList();
            var word3 = allWords.Where(x => x.Difficulty == 3 && !x.IsFamiliar).Select(x => x).ToList();
            var word4 = allWords.Where(x => x.Difficulty == 4 && !x.IsFamiliar).Select(x => x).ToList();
            var word5 = allWords.Where(x => x.Difficulty == 5 && !x.IsFamiliar).Select(x => x).ToList();
            var familiarWord = allWords.Where(x => x.IsFamiliar).Select(x => x).ToList();

            _fileManager.DeleteAllFilesInFolder(new DirectoryInfo(Constants.Book.BookPath));

            var word0Books = _wordsManager.SplitWordToBooks(word0, "0");
            var word1Books = _wordsManager.SplitWordToBooks(word1, "1");
            var word2Books = _wordsManager.SplitWordToBooks(word2, "2");
            var word3Books = _wordsManager.SplitWordToBooks(word3, "3");
            var word4Books = _wordsManager.SplitWordToBooks(word4, "4");
            var word5Books = _wordsManager.SplitWordToBooks(word5, "5");
            var familiarBook = _wordsManager.SplitWordToBooks(familiarWord, "familiar");

            _fileManager.SaveBook(word0Books);
            _fileManager.SaveBook(word1Books);
            _fileManager.SaveBook(word2Books);
            _fileManager.SaveBook(word3Books);
            _fileManager.SaveBook(word4Books);
            _fileManager.SaveBook(word5Books);
            _fileManager.SaveBook(familiarBook);

        }
    }
}
