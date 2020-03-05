using System.Collections.Generic;
using NewWords.Core.Model;

namespace NewWord.Windows.Model
{
    public class TabTransferDataModel
    {
        public TabTransferDataModel(WordBook currentBook, int runningIndex, string senderTabName, bool isTestMode)
        {
            CurrentBook = currentBook;
            RunningIndex = runningIndex;
            IsTestMode = isTestMode;
            SenderTabName = senderTabName;
        }
        public TabTransferDataModel(WordBook currentBook, int runningIndex, string senderTabName)
        {
            CurrentBook = currentBook;
            RunningIndex = runningIndex;
            SenderTabName = senderTabName;
        }
        public TabTransferDataModel(WordBook currentBook, string senderTabName)
        {
            CurrentBook = currentBook;
            SenderTabName = senderTabName;
        }
        public TabTransferDataModel(bool isTestMode, string senderTabName)
        {
            IsTestMode = isTestMode;
            SenderTabName = senderTabName;
        }

        public TabTransferDataModel(string senderTabName)
        {
            SenderTabName = senderTabName;
        }
        public WordBook CurrentBook { get; set; }
        public int RunningIndex { get; set; } = 0;
        public string SenderTabName { get; set; }
        public bool IsTestMode { get; set; } = false;
    }
}
