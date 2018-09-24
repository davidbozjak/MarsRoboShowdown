namespace RoboShowdown.Interfaces
{
    public interface IPlayer
    {
        string Name { get; }

        IRobot Robot { get; }
    }
}
