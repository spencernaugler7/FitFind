using NpgsqlTypes;

namespace FitFind.Models;

public enum ExerciseLevel
{
    [PgName("beginner")]
    Beginner,
    [PgName("intermediate")]
    Intermediate,
    [PgName("expert")]
    Expert
}