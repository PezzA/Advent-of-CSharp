using System.Runtime.InteropServices;
using AdventOfCSharp.Puzzles.Geometery;
using Puzzle = AdventOfCSharp.Puzzles.Year23.Day10.Puzzle;
using static AdventOfCSharp.Puzzles.Year23.Day10.Puzzle;
namespace AdventOfCSharp.Puzzles.Tests.Year23.Day10;

public class Tests
{
    private readonly Puzzle _puzzle = new();

    private const string TestData
        = """
          .....
          .S-7.
          .|.|.
          .L-J.
          .....
          """;

    private const string TestData2
        = """
          ..F7.
          .FJ|.
          SJ.L7
          |F--J
          LJ...
          """;
    [Fact]
    public void Loads_Data()
    {
        var grid = LoadData(TestData);
        
        Assert.Equivalent(new Point2D(1, 1), GetStart(grid));
    }

    [Fact]
    public void Determine_Type()
    {
        
        var grid = LoadData(TestData);
        var start = GetStart(grid);
        
        Assert.Equal('F', DetermineType(start, grid));
    }

    [Theory]
    [InlineData(TestData, 4)]
    [InlineData(TestData2, 8)]
    public void Walks_Pipes(string input, int expected)
    {
        var grid = LoadData(input);
        var points = WalkPipes(grid);
        
        Assert.Equal(expected, points.Max(p => p.Value));
    }


    [Fact]
   public void TestPartOne_TestData() => Assert.Equal("8", _puzzle.PartOne(TestData2)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, _puzzle.PartTwo(TestData)[0]);
        
    [Fact]
    public void TestPartOne() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}