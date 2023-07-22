using AdventOfCSharp.Puzzles.Year0.Day0;

namespace AdventOfCSharp.Puzzles.Tests;

public class Tests
{
    private readonly Puzzle puzzle;

    public Tests()
    {
        puzzle = new Puzzle();
    }

    [Fact]
    public void TestPartOne() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, puzzle.PartOne(puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, puzzle.PartTwo(puzzle.PuzzleInput())[0]);
}