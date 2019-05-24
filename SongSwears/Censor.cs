using System;
using System.IO;
using System.Text.RegularExpressions;

namespace SongSwears
{
    internal class Censor
    {
        string[] badWorlds;
        public Censor()
        {
            var profanitiesFile = File.ReadAllText("profanities.txt");
            profanitiesFile = profanitiesFile.Replace("*", "");
            profanitiesFile = profanitiesFile.Replace("(", "");
            profanitiesFile = profanitiesFile.Replace(")", "");
            profanitiesFile = profanitiesFile.Replace("\"", "");
            profanitiesFile = profanitiesFile.Replace(";", "");
            badWorlds = profanitiesFile.Split(',');

            //foreach (var word in badWorlds)
            //{
            //    Console.WriteLine(word);
            //}
        }

        public string Fix(string text)
        {
            // string[] wordArr = text.Split(' ');
            foreach (var word in badWorlds)
            {
                text = ReplaceBadWorld(text, word);
            }

            return text;
        }

        private static string ReplaceBadWorld(string text, string word)
        {
            var pattern = "\\b"+word+"\\b";
            return Regex.Replace(text, pattern, "*****", RegexOptions.IgnoreCase);
        }
    }
}