using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NewWords.Core.Model;

namespace NewWords.Core.Manager
{
    public static class JsonManager
    {
        public static string ToJsonString(this List<Model.WordCard> wordList)
        {
            if (wordList.Count == 0) return string.Empty;
            var json = JsonConvert.SerializeObject(wordList);
            return json.TrimStart('[').TrimEnd(']') + ",";
        }

        public static List<Model.WordCard> ToWordCardList(this string jsonString)
        {
            if(string.IsNullOrWhiteSpace(jsonString)) return new List<WordCard>();
            return JsonConvert.DeserializeObject<List<Model.WordCard>>("[" + jsonString.TrimEnd(',') + "]");
        }
    }
}
