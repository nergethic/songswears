using System;
using System.Collections.Generic;

namespace Badwords
{
    public class SwearStats : Censor
    {
        Dictionary<string, int> allSwears = new Dictionary<string, int>(); 
        public SwearStats()
        {

        }

        public void ShowSummary()
        {
            foreach (var item in allSwears)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }

        public void AddSwearsFrom(Song song)
        {
            foreach (var word in badWords) {
                var occurences = song.CountOccurrences(word);
                if (occurences > 0)
                {
                    if (!allSwears.ContainsKey(word))
                    {
                        allSwears.Add(word, 0);
                        allSwears[word] += occurences;
                    }
                }
            }      
        }

        public int FindCommonSwearsScore(ref SwearStats otherSwearStats)
        {
            int score = 0;
            foreach (var swear in this.allSwears)
            {
                if (otherSwearStats.allSwears.ContainsKey(swear.Key))
                {
                    score++;
                }
            }

            return score;
        }
    }
}
