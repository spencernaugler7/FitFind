using NpgsqlTypes;

namespace FitFind.Models;

[PgName("catagorytype")]
public enum ExerciseCategory
{
    [PgName("strength")]
    Strength,
    [PgName("stretching")]
    Stretching,
    [PgName("plyometrics")]
    Plyometrics,
    [PgName("strongman")]
    Strongman,
    [PgName("powerlifting")]
    Powerlifting,
    [PgName("cardio")]
    Cardio,
    [PgName("olympic weightlifting")]
    OlympicWeightlifting
}
/*
 *  "strength", "stretching", "plyometrics", "strongman", "powerlifting", "cardio", "olympic weightlifting" 
*/