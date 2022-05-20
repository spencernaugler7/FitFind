using NpgsqlTypes;

namespace FitFind.Models;

public enum ExerciseForce
{
    [PgName("pull")]
    Static,
    [PgName("push")]
    Push,
    [PgName("static")]
    Pull
}