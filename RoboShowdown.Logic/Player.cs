using RoboShowdown.Interfaces;

namespace RoboShowdown.Logic
{
    public class Player : IPlayer
    {
        public string Name { get; }

        public IRobot Robot { get; }

        public Player(string name, int initialX, int initialY)
        {
            this.Name = name;

            this.Robot = new GuidedRobot(initialX, initialY);
        }
    }
}
