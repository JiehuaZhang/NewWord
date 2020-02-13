namespace NewWords.Core.Model
{
    public class WordCard
    {
        public string Word { get; set; }
        public string Meaning { get; set; }
        public int Difficulty { get; set; }
        public bool Remember { get; set; } = false;
        public int Count { get; set; } = 0;
    }
}
