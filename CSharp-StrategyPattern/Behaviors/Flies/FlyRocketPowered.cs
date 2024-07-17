using CSharp_StrategyPattern.Interfaces;

namespace CSharp_StrategyPattern.Behaviors.Flies;

public class FlyRocketPowered : FlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("i do be rocketin'");
    }
}