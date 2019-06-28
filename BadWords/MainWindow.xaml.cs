using Badwords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BadWords
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void listOrderedBestScores(Song song)
        {
            var tinder = new RapperTinder(App.rappers, song);
            var scores = tinder.GetMatches();

            int scoreTotal = 0;
            string word = "point";

            foreach (KeyValuePair<string, int> score in scores.OrderByDescending(key => key.Value))
            {
                scoreTotal += score.Value;

                if (score.Value > 0)
                    listBoxScores.Items.Add($"{score.Key}: {score.Value} {((score.Value == 1) ? word : (word + "s"))}");
            }

            if (scoreTotal == 0)
            {
                listBoxScores.Items.Add($"No matches, try again with a different lyrics!");
            }
        }

        private void ButtonFindBestScore_Click(object sender, RoutedEventArgs e)
        {
            listBoxScores.Items.Clear();
            listOrderedBestScores(new Song(TextBoxLyrics.Text));
        }

        private void ButtonFindLyricsOnline_Click(object sender, RoutedEventArgs e)
        {
            listBoxScores.Items.Clear();
            var song = new Song(TextBoxArtist.Text, TextBoxTitle.Text);
            if (song.lyrics == "")
            {
                listBoxScores.Items.Add($"Song couldn't be found, try again with a different one.");
            } else
            {
                listOrderedBestScores(song);
            }
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.Source is TabControl)
            {
                TextBoxArtist.Text = "";
                TextBoxTitle.Text = "";
                listBoxScores.Items.Clear();
            }
        }
    }
}
