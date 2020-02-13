using System;
using System.Text;
using NewWords.Fundation.Core;
using NewWords.Fundation.Core.Model;

namespace NewWordsRunner
{
    class Program
    {
        static void Main(string[] args)
        {
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
