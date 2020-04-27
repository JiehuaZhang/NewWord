using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewWords.Core.Model;

namespace NewWords.Core.Manager
{
    public class WordsManager
    {
        public List<string> SplitWordList(List<WordCard> wordList)
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
                        result.Add(wordList.GetRange(i * Constants.Book.WordCount, m).ToJsonString());
                    }
                    else
                    {
                        result.Add(wordList.GetRange(i * Constants.Book.WordCount, Constants.Book.WordCount).ToJsonString());
                    }
                }
            }

            return result;
        }

        public List<WordBook> SplitWordToBooks(List<WordCard> wordList, string bookType)
        {
            var result = new List<WordBook>();
            if (wordList.Count == 0) return result;
            if (wordList.Count <= Constants.Book.WordCount)
            {
                result.Add( new WordBook(bookType,null, string.Empty)
                {
                    WordCardList = wordList,
                });
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
                        result.Add(new WordBook(bookType, i, string.Empty)
                        {
                            WordCardList = wordList.GetRange(i * Constants.Book.WordCount, m),
                        });
                    }
                    else
                    {
                        result.Add(new WordBook(bookType, i,string.Empty)
                        {
                            WordCardList = wordList.GetRange(i * Constants.Book.WordCount, Constants.Book.WordCount)
                        });
                    }
                }
            }
            return result;
        }

        
    }
}
