using AbstractFactoryPattern.Abstract;
using AbstractFactoryPattern.Abstract.Enums;
using AbstractFactoryPattern.Factory;

AbstractFactory factory = new TrainingFactory();

var beginnerTraining = factory.CreateTraining(ETrainingType.Beginner);
Console.WriteLine(beginnerTraining.GetTraining());

var intermediateTraining = factory.CreateTraining(ETrainingType.Intermediate);
Console.WriteLine(intermediateTraining.GetTraining());

var advancedTraining = factory.CreateTraining(ETrainingType.Advanced);
Console.WriteLine(advancedTraining.GetTraining());


