using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewWords.Core;
using NewWords.Core.Model;

namespace NewWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Test();
            test.TestFunction();
            
            while (true)
            {
                SaveWord();
            }
        }
        private static void SaveWord()
        {
            var word = new WordCard();
            Console.WriteLine("Word:");
            word.Word = Console.ReadLine();
            Console.WriteLine("Meaning:");

            var charArray = Console.ReadKey(true);

            Console.InputEncoding = System.Text.Encoding.Unicode;
            word.Meaning = Console.ReadLine();
            Console.WriteLine("Difficulty(1-4):");
            var input = Console.ReadLine();
            word.Difficulty = int.Parse(string.IsNullOrEmpty(input) ? "100" : input);
            var saveWord = new SaveWord();
            saveWord.SaveOneWord(word);
            Console.Clear();
        }
    }
}
