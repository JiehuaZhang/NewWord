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
    public class WordArrangementManager
    {
        private readonly FileManager _fileManager;

        public WordArrangementManager(FileManager fileManager)
        {
            _fileManager = fileManager;
        }

        public void MergeWordToAll()
        {
            var files = _fileManager.GetFiles();
            var sb =new StringBuilder();
            foreach (var file in files)
            {
               sb.Append( _fileManager.GetWordString(Constants.Book.BookPath + file));
            }
            if(!string.IsNullOrEmpty(sb.ToString()))
                _fileManager.SaveJsonToFile(Constants.Book.AllWordFilePath, sb.ToString());
            SplitWordToBooks();
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

            var di = new DirectoryInfo(Constants.Book.BookPath);
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }

            var word10StringList = SplitWordsByCount(word10);
            var word20StringList = SplitWordsByCount(word20);
            var word30StringList = SplitWordsByCount(word30);
            var word40StringList = SplitWordsByCount(word40);
            var word50StringList = SplitWordsByCount(word50);
            var hardWordStringList = SplitWordsByCount(hardWord);

            SaveBooks(word10StringList,Constants.Book.BookPath + "Word_10");
            SaveBooks(word20StringList, Constants.Book.BookPath + "Word_20");
            SaveBooks(word30StringList, Constants.Book.BookPath + "Word_30");
            SaveBooks(word40StringList, Constants.Book.BookPath + "Word_40");
            SaveBooks(word50StringList, Constants.Book.BookPath + "Word_50");
            SaveBooks(hardWordStringList, Constants.Book.BookPath + "HardWord");

        }


        private void SaveBooks(List<string> bookStringList, string bookPath)
        {
            for (int i = 0; i < bookStringList.Count; i++)
            {
                _fileManager.SaveJsonToFile(bookPath+"-"+i +".txt", bookStringList[i]);
            }
        }
        private List<string> SplitWordsByCount(List<WordCard> wordList)
        {
            var result = new List<string>();
            if (wordList.Count == 0) return result;
            if (wordList.Count < Constants.Book.WordCount)
            {
                result.Add(wordList.ToJsonString());
            }
            else
            {
                var n = wordList.Count / Constants.Book.WordCount;
                var m = wordList.Count % Constants.Book.WordCount;
                var j = m == 0 ? n : n + 1;
                for (int i = 0; i < j; i++)
                {
                    if (i == j - 1 && m != 0)
                    {
                        result.Add(wordList.GetRange(i * 10, m).ToJsonString());
                    }
                    else
                    {
                        result.Add(wordList.GetRange(i*10, Constants.Book.WordCount).ToJsonString());
                    }
                }
            }

            return result;
        }
        public void SaveRememberStatus(List<WordCard> wordList, string bookPath)
        {
            if(wordList.Count >0)
                File.WriteAllText(bookPath, wordList.ToJsonString());
        }
    }
}
