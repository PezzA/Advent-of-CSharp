using AdventOfCSharp.Puzzles.Year15.Day01;

namespace AdventOfCSharp.Puzzles.Tests.Year15.Day01;

public class Tests
{
    private readonly Puzzle puzzle;

    public Tests()
    {
        puzzle = new Puzzle();
    }

    [Fact]
    public void TestPartOne() => Assert.Equal("138", puzzle.PartOne(puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("1771", puzzle.PartTwo(puzzle.PuzzleInput())[0]);
}