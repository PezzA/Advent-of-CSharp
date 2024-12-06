using Puzzle = AdventOfCSharp.Puzzles.Year24.Day04.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year24.Day04;

public class Tests
{
    private readonly IBasicPuzzle _puzzle;

    private const string TestData
        = """
          MMMSXXMASM
          MSAMXMSMSA
          AMXSXMAAMM
          MSAMASMSMX
          XMASAMXAMM
          XXAMMXXAMA
          SMSMSASXSS
          SAXAMASAAA
          MAMMMXMMMM
          MXMXAXMASX
          """;

    public Tests() 
    {
        _puzzle = new Puzzle();
    }

    [Fact]
    public void Loads_Data()
    {
        var grid = Puzzle.LoadData(TestData);

        Assert.Equal('M', grid[new Geometery.Point2D(0, 0)]);
        Assert.Equal('M', grid[new Geometery.Point2D(0, 1)]);
        Assert.Equal('A', grid[new Geometery.Point2D(0, 2)]);
        Assert.Equal('M', grid[new Geometery.Point2D(0, 3)]);
    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("18", _puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("9", _puzzle.PartTwo(TestData)[0]);
        
    [Fact]
    public void TestPartOne() => Assert.Equal("2554", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("1916", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}