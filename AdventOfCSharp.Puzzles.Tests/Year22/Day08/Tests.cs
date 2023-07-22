using AdventOfCSharp.Puzzles.Year22.Day08;

namespace AdventOfCSharp.Puzzles.Tests.Year22.Day08;

public class Tests
{
    private readonly Puzzle puzzle;

    public Tests()
    {
        puzzle = new Puzzle();
    }

    private const string TEST_DATA = """
        30373
        25512
        65332
        33549
        35390
        """;

    [Fact]
    public void Loads_Data()
    {
        var grid = Puzzle.LoadData(TEST_DATA);

        Assert.NotNull(grid);
        Assert.Equal(3, grid[0, 0]);
        Assert.Equal(3, grid[4, 0]);
        Assert.Equal(3, grid[0, 4]);
        Assert.Equal(0, grid[4, 4]);
    }

    [Fact]
    public void Runs_Test()
    {
        var grid = Puzzle.LoadData(TEST_DATA);

        Assert.Equal(21, Puzzle.CountVisibleTrees(grid));
        Assert.Equal(8, Puzzle.GetHighestScenicScore(grid));
    }

    [Fact]
    public void TestPartOne() => Assert.Equal("1681", puzzle.PartOne(puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("201684", puzzle.PartTwo(puzzle.PuzzleInput())[0]);
}