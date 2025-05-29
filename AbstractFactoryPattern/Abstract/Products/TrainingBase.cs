using AbstractFactoryPattern.Abstract.Enums;

namespace AbstractFactoryPattern.Abstract.Products;

public abstract class TrainingBase(TimeSpan duration, short totalExercise)
{
    private TimeSpan Duration { get; } = duration;
    private short TotalExercise { get; } = totalExercise;
    public abstract ETrainingType TrainingType { get; }

    public string GetTraining()
        => $"Training type: {nameof(TrainingType)}, total exercise: {TotalExercise}, time: {Duration}";
}
