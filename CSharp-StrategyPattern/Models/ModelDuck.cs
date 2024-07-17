using CSharp_StrategyPattern.Behaviors.Flies;
using CSharp_StrategyPattern.Behaviors.Quacks;
using CSharp_StrategyPattern.Interfaces;

namespace CSharp_StrategyPattern.Models;

public class ModelDuck : Duck
{
    public ModelDuck()
    {
        QuackBehavior = new NormalQuack();
        FlyBehavior = new NoFly();
    }

    public override void Display()
    {
        Console.WriteLine("i do be a model duck");
    }
}