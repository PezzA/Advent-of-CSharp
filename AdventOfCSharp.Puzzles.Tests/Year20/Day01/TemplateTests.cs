using AdventOfCSharp.Puzzles.Year20.Day01;

namespace AdventOfCSharp.Puzzles.Tests.Year20.Day01;

public class Tests
{
    private readonly Puzzle _puzzle = new();
    
    [Fact]
    public void TestPartOne() => Assert.Equal("870331", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("283025088", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}