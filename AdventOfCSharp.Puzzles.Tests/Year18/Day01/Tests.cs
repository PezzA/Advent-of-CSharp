using AdventOfCSharp.Puzzles.Year18.Day01;

namespace AdventOfCSharp.Puzzles.Tests.Year18.Day01;

public class Tests()
{
    private readonly IBasicPuzzle _puzzle = new Puzzle();

    [Fact]
    public void TestPartOne() => Assert.Equal("493", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("413", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}