using System;
using System.Collections.Generic;
using FitFind.Data;
using FitFind.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Npgsql;

namespace FitFind.Data;
public partial class ExercisesdbContext : DbContext
{
    public ExercisesdbContext()
    {
        MapEnums();
    }

    public ExercisesdbContext(DbContextOptions<ExercisesdbContext> options)
        : base(options)
    {
        MapEnums();
    }

    public static void MapEnums()
    {
        NpgsqlConnection.GlobalTypeMapper.MapEnum<ExerciseCategory>("catagorytype");
        NpgsqlConnection.GlobalTypeMapper.MapEnum<ExerciseEquipment>("equipmenttype");
        NpgsqlConnection.GlobalTypeMapper.MapEnum<ExerciseLevel>("leveltype");
        NpgsqlConnection.GlobalTypeMapper.MapEnum<ExerciseMechanic>("mechanictype");
        NpgsqlConnection.GlobalTypeMapper.MapEnum<ExerciseForce>("forcetype");
        NpgsqlConnection.GlobalTypeMapper.MapEnum<ExerciseMuscle>("muscle");
    }

    public virtual DbSet<Exercise> Exercises { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseNpgsql("Host=localhost:5432;Database=exercisesdb;Username=postgres;Password=password;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder
        //     .HasPostgresEnum("categorytype", new[] { "strength", "stretching", "plyometrics", "strongman", "powerlifting", "cardio", "olympic weightlifting" })
        //     .HasPostgresEnum("equipmenttype", new[] { "body only", "machine", "other", "foam roll", "kettlebells", "dumbbell", "cable", "barbell", "bands", "medicine ball", "exercise ball", "e-z curl bar" })
        //     .HasPostgresEnum("forcetype", new[] { "pull", "push", "static" })
        //     .HasPostgresEnum("leveltype", new[] { "beginner", "intermediate", "expert" })
        //     .HasPostgresEnum("mechanictype", new[] { "compound", "isolation" })
        //     .HasPostgresEnum("muscle", new[] { "abdominals", "hamstrings", "adductors", "quadriceps", "biceps", "shoulders", "chest", "middle back", "calves", "glutes", "lower back", "lats", "triceps", "traps", "forearms", "neck", "abductors" });
        modelBuilder
            .HasPostgresEnum<ExerciseCategory>()
            .HasPostgresEnum<ExerciseEquipment>()
            .HasPostgresEnum<ExerciseForce>()
            .HasPostgresEnum<ExerciseLevel>()
            .HasPostgresEnum<ExerciseMechanic>()
            .HasPostgresEnum<ExerciseMuscle>();


        modelBuilder.Entity<Exercise>(entity =>
        {
            entity.ToTable("exercises");
            entity.HasIndex(e => e.Name, "exercises_name_key").IsUnique();
            entity.Property(e => e.Id).ValueGeneratedNever().HasColumnName("id");
            entity.Property(e => e.Aliases).HasColumnName("aliases");
            entity.Property(e => e.DateCreated).HasColumnName("date_created").HasDefaultValueSql("now()");
            entity.Property(e => e.DateUpdated).HasColumnName("date_updated") 
                .HasDefaultValueSql("statement_timestamp()");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Force).HasColumnName("force");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Mechanic).HasColumnName("mechanic");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Equipment).HasColumnName("equipment");
            entity.Property(e => e.PrimaryMuscles).HasColumnName("primary_muscles");
            entity.Property(e => e.SecondaryMuscles).HasColumnName("secondary_muscles");
            entity.Property(e => e.Instructions).HasColumnName("instructions");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Tips).HasColumnName("tips");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
