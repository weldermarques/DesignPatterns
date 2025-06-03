using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Decorators;

public class BeginnerDecorator(ITraining training) : TrainingDecorator(training: training)
{
    public override string GetTraining()
    {
        var result = base.GetTraining();
        result += "\nBeginner Training";
        return result;
    }
}
