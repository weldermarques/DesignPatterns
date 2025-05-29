using AbstractFactoryPattern.Abstract.Enums;
using AbstractFactoryPattern.Abstract.Products;

namespace AbstractFactoryPattern.Factory.Products;

public class BeginnerTraining() : TrainingBase(TimeSpan.FromMinutes(12), 10)
{
    public override ETrainingType TrainingType => ETrainingType.Beginner;
}
