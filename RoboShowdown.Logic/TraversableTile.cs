using RoboShowdown.Interfaces;
using Windows.UI;

namespace RoboShowdown.Logic
{
    public class TraversableTile : IBattlegroundTile
    {
        public IBattleEffect BattleEffect { get; protected set; }

        public Color BackgroundColor { get; }

        public int XOffset { get; }

        public int YOffset { get; }

        public IRobot Robot { get; set; }

        protected TraversableTile(int x, int y, Color color)
        {
            this.XOffset = x;
            this.YOffset = y;
            this.BackgroundColor = color;
        }

        public TraversableTile (int x, int y)
            : this(x, y, Colors.Wheat)
        {
        }
    }
}
