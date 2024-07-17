using CSharp_StrategyPattern.Interfaces;

namespace CSharp_StrategyPattern.Behaviors.Flies;

public class FlyWithWings : FlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("i do be flyin' with wings");
    }
}