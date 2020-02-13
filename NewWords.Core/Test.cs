using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NewWords.Core.Model;

namespace NewWords.Core
{
    public class Test
    {
        public void TestFunction()
        {
            var wordstring = "[" + File.ReadAllText("Word.txt").TrimEnd(',') + "]";
            var words = JsonConvert.DeserializeObject<List<NewWords.Core.Model.WordCard>>(wordstring);
        }

        public void TestFunction2()
        {
            var wordList = new List<WordCard>
            {
                new WordCard {Count = 0, Difficulty = 1, Meaning = "我不知道", Remember = false, Word = "Test"},
                new WordCard {Count = 0, Difficulty = 1, Meaning = "我不知道", Remember = false, Word = "Test"}
            };
            var str = JsonConvert.SerializeObject(wordList);
            Console.WriteLine(str);
        }
    }
}
