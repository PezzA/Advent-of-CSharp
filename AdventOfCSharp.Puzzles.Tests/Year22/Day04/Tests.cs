using AdventOfCSharp.Puzzles.Year22.Day04;
using Range = AdventOfCSharp.Puzzles.Year22.Day04.Range;

namespace AdventOfCSharp.Puzzles.Tests.Year22.Day04;

public class Tests
{
    readonly Puzzle puzzle;

    public Tests()
    {
        puzzle = new Puzzle();
    }

    [Fact]
    public void Test_LoadData()
    {
        var data = puzzle.LoadData(puzzle.PuzzleInput());

        Assert.Equal(new Range(54, 59), data[0].First);
        Assert.Equal(new Range(17, 62), data[0].Second);
        Assert.Equal(new Range(87,90) , data[^1].First);
        Assert.Equal(new Range(89,90) , data[^1].Second);
    }

    [Fact]
    public void TestPartOne() => Assert.Equal("657", puzzle.PartOne(puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("938", puzzle.PartTwo(puzzle.PuzzleInput())[0]);
}