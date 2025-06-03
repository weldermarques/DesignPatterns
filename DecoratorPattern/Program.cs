using DecoratorPattern.Decorators;
using DecoratorPattern.Interfaces;
using DecoratorPattern.Models;

ITraining training = new Training(TimeSpan.MaxValue, 10);

var beginnerTraining = new BeginnerDecorator(training);
var armyTraining = new ArmyDecorator(beginnerTraining);

Console.WriteLine(armyTraining.GetTraining());