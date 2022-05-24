using FitFind.Data;
using FitFind.Models;
using Microsoft.EntityFrameworkCore;

namespace FitFindTest;

public class DataFetchTest
{
    private List<Exercise> _exercises;

    [SetUp]
    public void Setup()
    {
        using var context = new ExercisesDbContext();
        _exercises = context.Exercises.ToList();
    }

    [Test]
    public void DataFetchSanityCheck()
    {
        Assert.True(_exercises.Count is not 0);
    }

    [Test]
    public void FirstExerciseInListIsSitup()
    {
        var situp = _exercises.First();
        Assert.That(situp.Name, Is.EqualTo("3/4 Sit-Up"));
        Assert.That(situp.PrimaryMuscles.First(), Is.EqualTo(ExerciseMuscle.Abdominals));
    }
}