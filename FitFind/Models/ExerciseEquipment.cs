using NpgsqlTypes;

namespace FitFind.Models;

public enum ExerciseEquipment
{
    [PgName("body only")]
    Body,
    [PgName("machine")]
    Machine,
    [PgName("other")]
    Other,
    [PgName("foam roll")]
    FoamRoll,
    [PgName("kettlebells")]
    KettleBells,
    [PgName("dumbbell")]
    Dumbbell,
    [PgName("cable")]
    Cable,
    [PgName("barbell")]
    Barbell,
    [PgName("bands")]
    Bands,
    [PgName("medicine ball")]
    MedicineBall,
    [PgName("exercise ball")]
    ExerciseBall,
    [PgName("e-z curl bar")]
    EZCurlBar
}
/*
 *  "body only", "machine", "other", "foam roll", "kettlebells", "dumbbell", "cable", "barbell", "bands", "medicine ball", "exercise ball", "e-z curl bar" 
*/