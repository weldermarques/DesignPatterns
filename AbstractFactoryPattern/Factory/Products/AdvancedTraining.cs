using AbstractFactoryPattern.Abstract.Enums;
using AbstractFactoryPattern.Abstract.Products;

namespace AbstractFactoryPattern.Factory.Products;

public class AdvancedTraining() : TrainingBase(TimeSpan.FromMinutes(25), 20)
{
    public override ETrainingType TrainingType => ETrainingType.Advanced;
}
