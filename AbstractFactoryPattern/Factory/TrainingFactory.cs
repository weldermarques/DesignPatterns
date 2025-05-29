using AbstractFactoryPattern.Abstract;
using AbstractFactoryPattern.Abstract.Enums;
using AbstractFactoryPattern.Abstract.Products;
using AbstractFactoryPattern.Factory.Products;

namespace AbstractFactoryPattern.Factory;

public sealed class TrainingFactory : AbstractFactory
{
    public override TrainingBase CreateTraining(ETrainingType trainingType) => trainingType switch
    {
        ETrainingType.Beginner => new BeginnerTraining(),
        ETrainingType.Intermediate => new IntermediateTraining(),
        ETrainingType.Advanced => new AdvancedTraining(),
        _ => throw new ArgumentOutOfRangeException(nameof(trainingType), $"Not expected direction value: {trainingType}")
    };
}
