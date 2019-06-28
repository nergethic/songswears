using Badwords;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BadWords
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static List<RapperSwearStats> rappers;
        [STAThread]
        public static void Main()
        {
            var eminemSwearStats = new RapperSwearStats("Eminem");
            eminemSwearStats.addSong("Stan");
            eminemSwearStats.addSong("Lose Yourself");
            eminemSwearStats.addSong("Not Afraid");
            eminemSwearStats.addSong("The Real Slim Shady");
            eminemSwearStats.addSong("When I'm gone");
            eminemSwearStats.addSong("Stan");
            eminemSwearStats.addSong("Rap God");
            eminemSwearStats.addSong("Killshot");
            eminemSwearStats.addSong("Venom");
            eminemSwearStats.addSong("My Name Is");
            eminemSwearStats.addSong("Hello");
            eminemSwearStats.addSong("Stan");
            eminemSwearStats.addSong("Fack");

            var twoPacStats = new RapperSwearStats("2Pac");
            twoPacStats.addSong("Changes");
            twoPacStats.addSong("Dear Mama");
            twoPacStats.addSong("Hail Mary");
            twoPacStats.addSong("I Get Around");
            twoPacStats.addSong("Hail Mary");
            twoPacStats.addSong("Hit 'Em Up");
            twoPacStats.addSong("Hail Mary");
            twoPacStats.addSong("Life Goes On");
            twoPacStats.addSong("Only God can Judge Me");
            twoPacStats.addSong("California Love");
            twoPacStats.addSong("Me Against The World");

            var jayzStats = new RapperSwearStats("Jay-Z");
            jayzStats.addSong("Ain’t No Nigga");
            jayzStats.addSong("Snoopy Track");
            jayzStats.addSong("Crazy in Love");
            jayzStats.addSong("Threat");
            jayzStats.addSong("A Week Ago");
            jayzStats.addSong("Dear Summer");
            jayzStats.addSong("So Ghetto");
            jayzStats.addSong("Imaginary Player");
            jayzStats.addSong("Where I’m From");
            jayzStats.addSong("99 Problems");
            jayzStats.addSong("U Don’t Know");

            var snoopStats = new RapperSwearStats("Snoop Dogg");
            snoopStats.addSong("Vapors");
            snoopStats.addSong("Lodi Dodi");
            snoopStats.addSong("Lay Low");
            snoopStats.addSong("Drop It like It’s Hot");
            snoopStats.addSong("Murder Was The Case");
            snoopStats.addSong("I Wanna Rock");
            snoopStats.addSong("Tha Shiznit");
            snoopStats.addSong("Gin and Juice");
            snoopStats.addSong("Young, Wild");
            snoopStats.addSong("Vato");
            snoopStats.addSong("Doggy Dogg World");

            var brockhamptonStats = new RapperSwearStats("Brockhampton");
            brockhamptonStats.addSong("SWEET");
            brockhamptonStats.addSong("BOOGIE");
            brockhamptonStats.addSong("BLEACH");
            brockhamptonStats.addSong("Gold");
            brockhamptonStats.addSong("NEW ORLEANS");
            brockhamptonStats.addSong("JUNKY");
            brockhamptonStats.addSong("STAR");
            brockhamptonStats.addSong("FACE");
            brockhamptonStats.addSong("1999 WILDFIRE");
            brockhamptonStats.addSong("RENTAL");
            brockhamptonStats.addSong("WASTE");
            brockhamptonStats.addSong("ZIPPER");

            rappers = new List<RapperSwearStats>();
            rappers.Add(eminemSwearStats);
            rappers.Add(twoPacStats);
            rappers.Add(jayzStats);
            rappers.Add(snoopStats);
            rappers.Add(brockhamptonStats);

            var application = new App();
            application.InitializeComponent();
            application.Run();
        }
    }
}
