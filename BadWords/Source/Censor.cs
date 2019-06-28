using System.IO;
using System.Text.RegularExpressions;

namespace Badwords
{
    public class Censor
    {
        protected string[] badWords;
        public Censor()
        {
            string profanitiesFileName = "profanities.txt";
            string path = Path.Combine(System.Environment.CurrentDirectory, @"Resources\", profanitiesFileName);

            var profanitiesfile = File.ReadAllText(path);
            profanitiesfile = profanitiesfile.Replace("*", "");
            profanitiesfile = profanitiesfile.Replace("(", "");
            profanitiesfile = profanitiesfile.Replace(")", "");
            profanitiesfile = profanitiesfile.Replace("\"", "");
            //profanitiesfile = profanitiesfile.Replace(";", "");
            profanitiesfile = profanitiesfile.Replace("'", "");

            badWords = profanitiesfile.Split(',');
        }

        public string Fix(string tekst)
        {
            foreach (var word in badWords)
            {
                tekst = ReplaceBadWords(tekst, word);
            }
            return tekst;
        }

        private static string ReplaceBadWords(string tekst, string word)
        {
            var pattern = "\\b" + word + "\\b";
            return Regex.Replace(tekst, pattern, "*** ", RegexOptions.IgnoreCase);
        }
    }
}
