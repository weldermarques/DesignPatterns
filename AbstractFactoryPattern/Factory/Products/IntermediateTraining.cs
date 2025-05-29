using AbstractFactoryPattern.Abstract.Enums;
using AbstractFactoryPattern.Abstract.Products;

namespace AbstractFactoryPattern.Factory.Products;

public class IntermediateTraining() : TrainingBase(TimeSpan.FromMinutes(20), 15)
{
    public override ETrainingType TrainingType => ETrainingType.Intermediate;
}
