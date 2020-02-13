using System.IO;
using Newtonsoft.Json;
using NewWords.Fundation.Core.Model;

namespace NewWords.Fundation.Core
{
    public class SaveWord
    {
        public void SaveOneWord(WordCard word)
        {
            var jsonString = JsonConvert.SerializeObject(word);
            if (!File.Exists("Word.txt"))
            {
                File.Create("Word.txt");
            }
            File.AppendAllText("Word.txt", jsonString + ",");
        }
    }
}
