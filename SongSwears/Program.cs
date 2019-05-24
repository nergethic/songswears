using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongSwears
{
    class Program
    {
        static void Main(string[] args)
        {
            var tekst = "Programowanie jest w chuj fajne";
            var songAnalysis = new SongAnalysis("Kazik", "12 groszy");
            var censor = new Censor();
            tekst = censor.Fix(tekst);
            Console.WriteLine(tekst);
            Console.ReadKey();
        }
    }
}
