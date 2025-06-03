using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Decorators;

public class TrainingDecorator(ITraining training): ITraining
{
    public virtual string GetTraining()
    {
        var result = training.GetTraining();
        return result;
    }
}
