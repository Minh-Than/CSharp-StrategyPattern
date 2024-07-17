using CSharp_StrategyPattern.Behaviors.Flies;
using CSharp_StrategyPattern.Interfaces;
using CSharp_StrategyPattern.Models;

Duck mallard = new MallardDuck();
mallard.Display();
mallard.PerformFly();
mallard.PerformQuack();

Console.WriteLine("");

Duck model = new ModelDuck();
mallard.PerformFly();
mallard.FlyBehavior = new FlyRocketPowered();
mallard.PerformFly();
