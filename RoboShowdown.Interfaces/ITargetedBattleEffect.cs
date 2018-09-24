namespace RoboShowdown.Interfaces
{
    public interface ITargetedBattleEffect : IBattleEffect
    {
        int TargetDirectionX { get; }
        int TargetDirectionY { get; }
        int TargetDistance { get; }
    }
}
