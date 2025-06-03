using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Models;

public class Training(TimeSpan duration, short totalExercise) : ITraining
{
    private TimeSpan Duration { get; } = duration;
    private short TotalExercise { get; } = totalExercise;
    
    public virtual string GetTraining()
        => $"Training: total exercise: {TotalExercise}, time: {Duration}";
}
