using AdventOfCSharp.Puzzles.Year22.Day02;
using static AdventOfCSharp.Puzzles.Year22.Day02.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year22.Day02;

public class Tests
{
    private readonly IBasicPuzzle puzzle;

    public Tests()
    {
        puzzle = new Puzzle();
    }
    [Fact]
    public void TestLoadData()
    {
        var data = LoadData(puzzle.PuzzleInput());

        Assert.NotNull(data);
        Assert.Equivalent(new Instruction { OpponentPlay = "A", MyPlay = "Y" }, data[0]);
        Assert.Equivalent(new Instruction { OpponentPlay = "A", MyPlay = "Y" }, data[^1]);
    }

    [Fact]
    public void TestPartOne() => Assert.Equal("15632", puzzle.PartOne(puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("14416", puzzle.PartTwo(puzzle.PuzzleInput())[0]);
}