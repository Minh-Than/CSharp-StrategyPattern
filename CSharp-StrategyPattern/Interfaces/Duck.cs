namespace CSharp_StrategyPattern.Interfaces;

public abstract class Duck
{
    public QuackBehavior QuackBehavior { get; set; }
    public FlyBehavior FlyBehavior { get; set; }

    public Duck()
    {
    }

    public abstract void Display();
    
    public void PerformQuack()
    {
        QuackBehavior.Quack();
    }

    public void PerformFly()
    {
        FlyBehavior.Fly();
    }

    public void Swim()
    {
        Console.WriteLine("it do be swimmin'");
    }
    
}