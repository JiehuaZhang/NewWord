namespace NewWords.Core.Model
{
    public class WordCard
    {
        public string Word { get; set; }
        public string Meaning { get; set; }
        public int Difficulty { get; set; }
        public bool Remember { get; set; } = false;
        public int Count { get; set; } = 0;
        public string History { get; set; } = string.Empty;

        public bool IsFamiliar => GetIsFamiliar(History);

        public bool GetIsFamiliar(string history)
        {
            var arrHistory = history.ToCharArray();
            var sum = 0;
            if (arrHistory.Length > 10)
            {
                for (var i = arrHistory.Length - 10; i < arrHistory.Length; i++)
                {
                    var n = int.Parse(arrHistory[i].ToString());
                    sum += n;
                }

                if (sum >= 10) return true;
            }

            return false;
        }
    }
}
