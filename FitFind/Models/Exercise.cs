namespace FitFind.Models;
public partial class Exercise
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public ExerciseForce? Force { get; set; }
    public ExerciseLevel Level { get; set; }
    public ExerciseMechanic? Mechanic { get; set; }
    public ExerciseCategory Category { get; set; }
    public ExerciseEquipment? Equipment { get; set; }
    public List<ExerciseMuscle> PrimaryMuscles { get; set; } = new();
    public List<ExerciseMuscle> SecondaryMuscles { get; set; } = new();
    public List<string>? Aliases { get; set; }
    public List<string>? Instructions { get; set; }
    public string? Description { get; set; }
    public List<string>? Tips { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
}