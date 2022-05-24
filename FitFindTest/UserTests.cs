using FitFind.Data;
using FitFind.Models;
using NUnit.Framework;

namespace FitFindTest;

[TestFixture]
public class UserTests
{
    private List<Exercise> _exercises;
    private User _user;

    public class User
    {
        private List<Exercise> _likedExercieses;

        public User()
        {
            _likedExercieses = new();
        }

        public List<Exercise> LikedExercises { get => new(_likedExercieses); }

        public void AddToLikedExercies(Exercise Exerise)
        {
            _likedExercieses.Add(Exerise);
        }
        
    }

    
    [SetUp]
    public void Setup()
    {
        using var context = new ExercisesDbContext();
        _exercises = context.Exercises.ToList();
        _user = new User();
    }

    [Test]
    public void TestAddExerciseToUserLikedExercises()
    {
        _user.AddToLikedExercies(_exercises.First());
        Assert.That(_user.LikedExercises.First().Name, Is.EqualTo("3/4 Sit-Up"));
        Assert.That(_user.LikedExercises.First().PrimaryMuscles.First(), Is.EqualTo(ExerciseMuscle.Abdominals));
    }
    
}