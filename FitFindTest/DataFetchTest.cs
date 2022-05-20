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
        using var context = new ExercisesdbContext();
        _exercises = context.Exercises.ToList();
    }

    [Test]
    public void DataFetchSanityCheck()
    {
        Assert.True(_exercises.Count is not 0);
    }
    
}