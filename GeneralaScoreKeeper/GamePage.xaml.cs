using System.Collections.ObjectModel;

namespace GeneralaScoreKeeper
{
    public partial class GamePage : ContentPage
    {
        public ObservableCollection<Player> Players { get; set; }

        public GamePage(ObservableCollection<Player> players)
        {
            InitializeComponent();
            Players = players;
            ScoreList.ItemsSource = Players;
        }
    }
}
