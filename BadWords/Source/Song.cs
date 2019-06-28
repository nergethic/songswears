using Newtonsoft.Json;
using SearchingCurses;
using System.Net;
using System.Text.RegularExpressions;

namespace Badwords
{
    public class Song {
        public string artist;
        public string title;
        public string lyrics;

        public Song(string lyrics)
        {
            artist = "Unknown";
            title = "unknown";
            this.lyrics = lyrics;
        }
        public Song(string band, string song)
        {
            var url = "https://api.lyrics.ovh/v1/" + band + "/" + song;
            var json = WebCache.GetOrDownload(url);
            var lyricsData = JsonConvert.DeserializeObject<LyricsAnswer>(json);

            artist = band;
            title = song;
            lyrics = lyricsData.lyrics;
        }

        public int CountOccurrences(string word)
        {
            var pattern = "\\b" + word + "\\b";
            return Regex.Match(lyrics, pattern, RegexOptions.IgnoreCase).Length;  
        }
    }
}
