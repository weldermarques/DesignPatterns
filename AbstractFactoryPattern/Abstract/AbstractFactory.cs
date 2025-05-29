using AbstractFactoryPattern.Abstract.Enums;
using AbstractFactoryPattern.Abstract.Products;

namespace AbstractFactoryPattern.Abstract;

public abstract class AbstractFactory
{
    public abstract TrainingBase CreateTraining(ETrainingType trainingType);
}
