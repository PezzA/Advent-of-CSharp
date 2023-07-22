using AdventOfCSharp.Puzzles.Year22.Day01;
namespace AdventOfCSharp.Puzzles.Tests.Year22.Day01;

public class Tests
{
    private readonly Puzzle puzzle;

    public Tests()
    {
        puzzle = new Puzzle();
    }

    [Fact]
    public void TestPartOne() => Assert.Equal("72017", puzzle.PartOne(puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("212520", puzzle.PartTwo(puzzle.PuzzleInput())[0]);
}