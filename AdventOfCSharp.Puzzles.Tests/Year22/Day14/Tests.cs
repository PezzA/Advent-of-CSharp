using AdventOfCSharp.Puzzles.Geometery;
using AdventOfCSharp.Puzzles.Year22.Day14;

namespace AdventOfCSharp.Puzzles.Tests.Year22.Day14;

public class Tests
{
    private readonly IBasicPuzzle puzzle;

    public Tests()
    {
        puzzle = new Puzzle();
    }

    public const string TestData = """
        498,4 -> 498,6 -> 496,6
        503,4 -> 502,4 -> 502,9 -> 494,9
        """;

    [Fact]
    public void LoadsDate()
    {
        var paths = Puzzle.LoadData(TestData);

        Assert.Equal(2, paths.Count());
        Assert.Equal(3, paths[0].Count());

        Assert.Equal(new Point2D(498, 4), paths[0][0]);
        Assert.Equal(new Point2D(498, 6), paths[0][1]);
        Assert.Equal(new Point2D(496, 6), paths[0][2]);
    }

    [Fact]
    public void TestPartOne() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, puzzle.PartOne(puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, puzzle.PartTwo(puzzle.PuzzleInput())[0]);
}
