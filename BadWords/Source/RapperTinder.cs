using System;
using System.Collections.Generic;

namespace Badwords
{
    public class RapperTinder
    {
        List<RapperSwearStats> rappers;
        Song unknownSong;
        SwearStats unknownSongSwearStats;
        Dictionary<string, int> scores;
        public RapperTinder(List<RapperSwearStats> rappers, Song unknownSong)
        {
            this.rappers = rappers;
            this.unknownSong = unknownSong;
            scores = new Dictionary<string, int>();

            unknownSongSwearStats = new SwearStats();
            unknownSongSwearStats.AddSwearsFrom(unknownSong);
        }

        public Dictionary<string, int> GetMatches()
        {
            foreach (var rapper in rappers)
            {
                int score = rapper.FindCommonSwearsScore(ref unknownSongSwearStats);
                scores.Add(rapper.name, score);                    
            }

            return scores;
        }
    }
}