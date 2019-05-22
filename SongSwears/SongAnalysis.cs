using System;
using System.Net;

namespace SongSwears
{
    internal class SongAnalysis
    {

        public SongAnalysis(string band, string songName)
        {
            var browser = new WebClient();
            string url = "https://api.lyrics.ovh/v1/"+band+"/"+songName;
            var json = browser.DownloadString(url);
            Console.Write(json);
            Console.ReadKey();
        }
    }
}