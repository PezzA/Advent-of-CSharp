using AdventOfCSharp.Puzzles.Year21.Day01;

namespace AdventOfCSharp.Puzzles.Tests.Year21.Day01;

public class Tests
{
    private readonly IBasicPuzzle _puzzle = new Puzzle();

    private static readonly string TestData = string.Empty;
    
    [Fact]
    public void TestPartOne() => Assert.Equal("1532", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("1571", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}