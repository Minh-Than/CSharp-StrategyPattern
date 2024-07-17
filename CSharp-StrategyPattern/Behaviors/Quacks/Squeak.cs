using CSharp_StrategyPattern.Interfaces;

namespace CSharp_StrategyPattern.Behaviors.Quacks;

public class Squeak : QuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("i do be squeakin'");
    }
}