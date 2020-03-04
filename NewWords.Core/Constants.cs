using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWords.Core
{
    public static class  Constants
    {
        public static class Book
        {
            public static int WordCount = 10;
            public static string AllWordFilePath = "Library/"+BookName.AllWordsBook;
            public static string BookPath = "Library/Books/";
            public static string OkPath = "Library/Ok/";
        }
        public struct BookName
        {
            public const string NewWordBook = "NewWords";
            public const string AllWordsBook = "AllWords.txt";
        }

        public struct FormText
        {
            public const string TaskCompleteText = "Done!";
            public const string NoWord = "No words.";
            public const string NoRememberWord = "No remember words.";
            public const string TheEnd = "The End";
            public const string Next = "Next";
            public const string Previous = "Previous";
            public const string Yes = "Yes";
            public const string No = "No";
            public const string Cancel = "Cancel";
            public const string TestMode = "Test";
        }

        public static string BuildOkWordBookFilePath()
        {
            return Book.OkPath + "OKWord_" + DateTime.Now.Date.ToString("yyyy-MM-dd") + ".txt";
        }

        public static string BuildArrangeText(string text)
        {
            return text + " ( at" + DateTime.Now.ToString("HH:mm:ss") + ")";
        }

    }
}
