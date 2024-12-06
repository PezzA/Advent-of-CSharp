using Puzzle = AdventOfCSharp.Puzzles.Year24.Day02.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year24.Day02;

public class Tests
{
    private readonly IBasicPuzzle _puzzle;

    private const string TestData
        = """
          7 6 4 2 1
          1 2 7 8 9
          9 7 6 2 1
          1 3 2 4 5
          8 6 4 4 1
          1 3 6 7 9
          """;

    public Tests()
    {
        _puzzle = new Puzzle();
    }

    [Fact]
    public void Loads_Data()
    {
        var lists = Puzzle.LoadData(TestData);
        Assert.NotNull(lists);
        Assert.Equivalent(new int[] { 7, 6, 4, 2, 1 }, lists.First());
        Assert.Equivalent(new int[] { 1, 3, 6, 7, 9 }, lists.Last());
    }

    [Fact]
    public void TestPartOne_TestData()
    {
        var lists = Puzzle.LoadData(TestData);

        Assert.True(Puzzle.IsSafe(lists[0]));
        Assert.False(Puzzle.IsSafe(lists[1]));
        Assert.False(Puzzle.IsSafe(lists[2]));
        Assert.False(Puzzle.IsSafe(lists[3]));
        Assert.False(Puzzle.IsSafe(lists[4]));
        Assert.True(Puzzle.IsSafe(lists[5]));
    }

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("4", _puzzle.PartTwo(TestData)[0]);

    [Fact]
    public void TestPartOne() => Assert.Equal("371", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("426", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}