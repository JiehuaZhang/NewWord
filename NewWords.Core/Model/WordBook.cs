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
        private readonly string _bookType;
        private readonly string _index;
        private string _currentBookName;

        public WordBook(string bookType, int? index, string currentBookName)
        {
            _bookType = bookType;
            _index = index==null? string.Empty: "-"+index;
            _currentBookName = currentBookName;
        }

        public List<WordCard> WordCardList { get; set; } = new List<WordCard>();

        public string BookName
        {
            set=> _currentBookName = value;
            get
            {
                if (!string.IsNullOrEmpty(_bookType))
                {
                    return "Word_" + _bookType + "-" + _index + "_(" + WordCardList.Count + ")";
                }

                return _currentBookName;
            }
        }
        public string WordCardJsonString => WordCardList.ToJsonString();
        public string BookPath => Constants.Book.BookPath + BookName;
    }
}
