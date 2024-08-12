using System.Collections.ObjectModel;

namespace GeneralaScoreKeeper
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Player> Players { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Players = [];
            PlayersList.ItemsSource = Players;
        }

        private void OnAddPlayer(object sender, EventArgs e)
        {
            Players.Add(new Player { Name = "" });
        }

        private void OnRemovePlayer(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            Player? player = button?.BindingContext as Player;
            _ = Players.Remove(player!);
        }

        private void OnStartGame(object sender, EventArgs e)
        {
            _ = Navigation.PushAsync(new GamePage(Players));
        }
    }

    public class Player
    {
        public required string Name { get; set; }
    }
}
