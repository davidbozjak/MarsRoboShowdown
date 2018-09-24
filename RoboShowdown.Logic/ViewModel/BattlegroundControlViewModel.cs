using RoboShowdown.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace RoboShowdown.Logic.ViewModel
{
    public class BattlegroundControlViewModel
    {
        public ICollection<IPlayer> Players { get; }

        public ICollection<IBattlegroundTile> Tiles { get; }

        public IBattleManager BattleManager { get; }

        public BattlegroundControlViewModel(
            IEnumerable<IPlayer> players,
            IEnumerable<IBattlegroundTile> tiles,
            IBattleManager battleManager)
        {
            this.Players = players.ToList().AsReadOnly();
            this.Tiles = tiles.ToList().AsReadOnly();

            this.BattleManager = battleManager;
        }
    }
}
