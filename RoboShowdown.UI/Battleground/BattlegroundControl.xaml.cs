using RoboShowdown.Logic;
using RoboShowdown.Logic.ViewModel;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace RoboShowdown.UI.Battleground
{
    public sealed partial class BattlegroundControl : UserControl
    {
        private BattlegroundControlViewModel ViewModel { get; }

        public BattlegroundControl()
        {
            this.InitializeComponent();

            this.ViewModel = new BattlegroundControlViewModel(
                new[] { new Player("Rookie", 2, 2) },
                new [] { new TraversableTile(5, 5) },
                new BattleManager());

            this.battleGrid.Reset(10, 10, this.ViewModel.BattlegroundObjects);
        }
    }
}
