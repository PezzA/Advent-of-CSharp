using Puzzle = AdventOfCSharp.Puzzles.Year23.Day07.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year0.Day0;

public class Tests
{
    private readonly Puzzle _puzzle = new();

    private static readonly string TestData = string.Empty;

    [Fact]
    public void Loads_Data()
    {
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