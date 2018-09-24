using RoboShowdown.Interfaces;

namespace RoboShowdown.Logic
{
    class GuidedRobot : IRobot
    {
        public int Health { get; private set; }

        public int XOffset { get; private set; }

        public int YOffset { get; private set; }

        public GuidedRobot (int initialX, int initialY)
        {
            this.XOffset = initialX;
            this.YOffset = initialY;
        }
    }
}
