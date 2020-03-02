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
            var word0 = allWords.Where(x => x.Difficulty == 0).Select(x => x).ToList();
            var word1 = allWords.Where(x => x.Difficulty == 1).Select(x => x).ToList();
            var word2 = allWords.Where(x => x.Difficulty == 2).Select(x => x).ToList();
            var word3 = allWords.Where(x => x.Difficulty == 3).Select(x => x).ToList();
            var word4 = allWords.Where(x => x.Difficulty == 4).Select(x => x).ToList();
            var word5 = allWords.Where(x => x.Difficulty == 5).Select(x => x).ToList();

            _fileManager.DeleteAllFilesInFolder(new DirectoryInfo(Constants.Book.BookPath));

            var word0StringList = _wordsManager.SplitWordList(word0);
            var word1StringList = _wordsManager.SplitWordList(word1);
            var word2StringList = _wordsManager.SplitWordList(word2);
            var word3StringList = _wordsManager.SplitWordList(word3);
            var word4StringList = _wordsManager.SplitWordList(word4);
            var word5StringList = _wordsManager.SplitWordList(word5);

            _fileManager.SaveBooks(word0StringList,Constants.Book.BookPath + "Word_0Remembered");
            _fileManager.SaveBooks(word1StringList,Constants.Book.BookPath + "Word_1Easy");
            _fileManager.SaveBooks(word2StringList,Constants.Book.BookPath + "Word_2Medium");
            _fileManager.SaveBooks(word3StringList,Constants.Book.BookPath + "Word_3LittleHard");
            _fileManager.SaveBooks(word4StringList,Constants.Book.BookPath + "Word_4Hard");
            _fileManager.SaveBooks(word5StringList, Constants.Book.BookPath + "Word_5VeryHard");
        }
    }
}
