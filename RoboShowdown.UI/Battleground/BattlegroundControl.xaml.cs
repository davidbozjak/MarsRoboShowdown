using RoboShowdown.Logic;
using RoboShowdown.Logic.ViewModel;
using Windows.UI.Xaml.Controls;
using System.Linq;
using RoboShowdown.Interfaces;

namespace RoboShowdown.UI.Battleground
{
    public sealed partial class BattlegroundControl : UserControl
    {
        private BattlegroundControlViewModel ViewModel { get; }

        public BattlegroundControl()
        {
            this.InitializeComponent();

            var player = new Player("Rookie", 5, 5);

            this.ViewModel = new BattlegroundControlViewModel(
                new[] { player },
                new [] 
                {
                    new TraversableTile(5, 5) { Robot = player.Robot },
                    new TraversableTile(5, 4),
                    new TraversableTile(5, 3),
                    new TraversableTile(5, 6),
                    new TraversableTile(4, 3),
                },
                new BattleManager());

            this.battleGrid.Reset(10, 10);
            this.battleGrid.DrawBattleState(this.ViewModel.Tiles.Cast<IBattlegroundObject>());
        }
    }
}
