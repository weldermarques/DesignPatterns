using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Decorators;

public class ArmyDecorator(ITraining training) : TrainingDecorator(training: training)
{
    public override string GetTraining()
    {
        var result = base.GetTraining();
        result += "\nToday is Army Training.";
        return result;
    }
}
