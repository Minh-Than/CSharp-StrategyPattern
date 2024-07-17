using CSharp_StrategyPattern.Behaviors.Flies;
using CSharp_StrategyPattern.Behaviors.Quacks;
using CSharp_StrategyPattern.Interfaces;

namespace CSharp_StrategyPattern.Models;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        QuackBehavior = new NormalQuack();
        FlyBehavior = new FlyWithWings();
    }

    public override void Display()
    {
        Console.WriteLine("i do be a Mallard duck");
    }
}