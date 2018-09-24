using RoboShowdown.Interfaces;
using RoboShowdown.UI.Robot;
using RoboShowdown.UI.Surface;
using System;
using Windows.UI.Xaml;

namespace RoboShowdown.UI.Battleground
{
    class BattlegroundControlSelector
    {
        public UIElement GetControlForViewModel(IBattlegroundObject battlegroundObject)
        {
            if (battlegroundObject is IRobot)
            {
                return new RobotControl();
            }
            else if (battlegroundObject is IBattlegroundTile tile)
            {
                return new SurfaceControl
                {
                    Tile = tile
                };
            }

            return null;
        }
    }
}
