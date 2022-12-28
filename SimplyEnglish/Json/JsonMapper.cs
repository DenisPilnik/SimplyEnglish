using Newtonsoft.Json;
using SimplyEnglish.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SimplyEnglish.Json
{
    public static class JsonMapper
    {
        private static string FileName => "Vocabulary.json";

        public static EnglishWord GetEnglishWordById(int id)
        {
            List<Word> words = LoadAllFromJson();
            Word word =  words.FirstOrDefault( x=> x.Id == id);
            EnglishWord english = new EnglishWord();

            english.Word = word.EnglishWords;
            english.AnswerVariable = word.UkrainianWords;

            return english;
        }

        public static List<Word> LoadAllFromJson()
        {
            string json = File.ReadAllText(FileName);

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            var wordList = JsonConvert.DeserializeObject<List<Word>>(json.ToString(), settings);

            return wordList ?? new List<Word>();
        }
    }
}
