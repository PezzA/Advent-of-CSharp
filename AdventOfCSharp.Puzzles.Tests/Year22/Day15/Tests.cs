using AdventOfCSharp.Puzzles.Geometery;
using Puzzle = AdventOfCSharp.Puzzles.Year22.Day15.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year22.Day15;

public class Tests
{
    private readonly Puzzle _puzzle = new();

    private static readonly string TestData = string.Empty;

    [Fact]
    public void LoadsData()
    {
        var sensors = Puzzle.LoadData(_puzzle.PuzzleInput());
        Assert.NotNull(sensors);
        Assert.Equal(33, sensors.Count);

        var first = sensors.First();
        Assert.Equal(new Puzzle.Sensor(new Point2D(X: 2302110,Y: 2237242), new Point2D(2348729,1239977)), first);

        var last = sensors.Last();
        Assert.Equal(new Puzzle.Sensor(new Point2D(X: 1054910,Y: 811769), new Point2D(2348729,1239977)), last );
    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, _puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, _puzzle.PartTwo(TestData)[0]);
        
    [Fact]
    public void TestPartOne() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}