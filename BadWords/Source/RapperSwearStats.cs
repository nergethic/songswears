namespace Badwords
{
    public class RapperSwearStats : SwearStats
    {
        public string name;

        public RapperSwearStats(string name)
        {
            this.name = name;
        }

        public void addSong(string title)
        {
            var song = new Song(name, title);
            AddSwearsFrom(song);
        }
    }
}
