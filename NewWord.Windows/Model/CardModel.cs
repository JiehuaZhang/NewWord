using System.Collections.Generic;

namespace NewWord.Windows.Model
{
    public class CardModel
    {
        public int WordCount { get; set; }
        public List<NewWords.Core.Model.WordCard> WordList { get; set; }
        public string CurrentBook { get; set; }
    }
}
