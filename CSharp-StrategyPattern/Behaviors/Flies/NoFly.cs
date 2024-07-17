using CSharp_StrategyPattern.Interfaces;

namespace CSharp_StrategyPattern.Behaviors.Flies;

public class NoFly : FlyBehavior
{
    public void Fly()
    {
        Console.Write("i dont be flyin'");
    }
}