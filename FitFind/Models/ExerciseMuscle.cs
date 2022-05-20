using NpgsqlTypes;

namespace FitFind.Models;

public enum ExerciseMuscle
{
    [PgName("abdominals")]
    Abdominals,
    [PgName("hamstrings")]
    Hamstrings,
    [PgName("adductors")]
    Adductors,
    [PgName("quadriceps")]
    Quadriceps,
    [PgName("biceps")]
    Biceps,
    [PgName("shoulders")]
    Shoulders,
    [PgName("chest")]
    Chest,
    [PgName("middle back")]
    MiddleBack,
    [PgName("calves")]
    Calves,
    [PgName("glutes")]
    Glutes,
    [PgName("lower back")]
    LowerBack,
    [PgName("lats")]
    Lats,
    [PgName("triceps")]
    Triceps,
    [PgName("traps")]
    Traps,
    [PgName("forearms")]
    Forearms,
    [PgName("neck")]
    Neck,
    [PgName("abductors")]
    Abductors
}

/*
 *  "abdominals", "hamstrings", "adductors", "quadriceps", "biceps", "shoulders", "chest", "middle back", "calves", "glutes", "lower back", "lats", "triceps", "traps", "forearms", "neck", "abductors" 
*/