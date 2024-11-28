using AdventOfCSharp.Puzzles.Year15.Day01;

namespace AdventOfCSharp.Puzzles.Tests.Year15.Day01;

public class Tests
{
    private readonly IBasicPuzzle _puzzle;

    public Tests()
    {
        _puzzle = new Puzzle();
    }

    [Fact]
    public void TestPartOne() => Assert.Equal("138", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("1771", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}