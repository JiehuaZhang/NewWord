using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewWords.Core.Manager;

namespace NewWords.Core.Model
{
    public class WordBook
    {
        private readonly string _originBookName;
        private readonly string _index;

        public WordBook(string originBookName, int? index)
        {
            _originBookName = originBookName;
            _index = index==null? string.Empty: "-"+index;
        }

        public List<WordCard> WordCardList { get; set; }
        public string BookName => _originBookName+ _index + "_(" + WordCardList.Count + ")";
        public string WordCardJsonString => WordCardList.ToJsonString();
        public string BookPath => Constants.Book.BookPath + BookName;
    }
}
