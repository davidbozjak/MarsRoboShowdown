using Windows.UI;

namespace RoboShowdown.Interfaces
{
    public interface IBattlegroundTile : IBattlegroundObject
    {
        IBattleEffect BattleEffect { get; }

        Color BackgroundColor { get; }

        IRobot Robot { get; set; }
    }
}
