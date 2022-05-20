using NpgsqlTypes;

namespace FitFind.Models;

public enum ExerciseMechanic
{
    [PgName("compound")]
    Compound,
    [PgName("isolation")]
    Isolation
}