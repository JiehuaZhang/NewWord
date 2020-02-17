using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NewWords.Core.Model;

namespace NewWords.Core.Manager
{
    public class WordCardManager
    {
        private readonly FileManager _fileManager;

        public WordCardManager(FileManager fileManager)
        {
            _fileManager = fileManager;
        }

        public void AddOneWord(WordCard word)
        {
            var newWordBookPath = Constants.Book.BookPath + Constants.BookName.NewWordBook;
            var jsonString = JsonConvert.SerializeObject(word);
            _fileManager.CheckFileIfExistThenCreate(newWordBookPath);
            File.AppendAllText(newWordBookPath, jsonString + ",");
        }
    }
}
