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
    public class FileManager
    {
        public List<NewWords.Core.Model.WordCard> GetWordList(string filePath)
        {
            var wordString = File.ReadAllText(filePath);
            if(string.IsNullOrEmpty(wordString)) return new List<WordCard>();
            return wordString.ToWordCardList();
        }
        public string GetWordString(string filePath)
        {
            return  File.ReadAllText(filePath); 
        }

        public string[] GetFiles()
        {
            //var path = Path.GetFullPath(@"Library\Books");
            var path = Path.GetFullPath(Constants.Book.BookPath);
            if (Directory.Exists(path))
            {
                var info = new DirectoryInfo(path);
                return info.GetFiles().Select(x => x.Name).ToArray();
            }

            Directory.CreateDirectory(path);
            return null;
        }

        public void SaveJsonToFile(string bookPath, string jsonString)
        {
            File.WriteAllText(bookPath, jsonString);
        }

        public bool CheckFileIfExistThenCreate(string filePath)
        {
            if (File.Exists(filePath)) return true;
            var file = File.Create(filePath);
            file.Close();
            return false;
        }
        public void SaveBooks(List<string> bookStringList, string bookPath)
        {
            for (int i = 0; i < bookStringList.Count; i++)
            {
                SaveJsonToFile(bookPath + "-" + i + ".txt", bookStringList[i]);
            }
        }

        public bool CheckPathIfExistThenCreate(string path)
        {
            if (Directory.Exists(path)) return true;
            Directory.CreateDirectory(path);
            return false;
        }

        public void MergeWordToAll()
        {
            var files = GetFiles();
            var sb = new StringBuilder();
            foreach (var file in files)
            {
                sb.Append(GetWordString(Constants.Book.BookPath + file));
            }
            if (!string.IsNullOrEmpty(sb.ToString()))
                SaveJsonToFile(Constants.Book.AllWordFilePath, sb.ToString());
        }

        public void DeleteAllFilesInFolder(DirectoryInfo directoryInfo)
        {
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                file.Delete();
            }
        }
    }
}
