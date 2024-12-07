using AdventOfCSharp.Puzzles.Geometery;
using Puzzle = AdventOfCSharp.Puzzles.Year24.Day06.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year24.Day06;

public class Tests
{
    private readonly IBasicPuzzle _puzzle;

    private const string TestData = """
          ....#.....
          .........#
          ..........
          ..#.......
          .......#..
          ..........
          .#..^.....
          ........#.
          #.........
          ......#...
          """;

    public Tests()
    {
        _puzzle = new Puzzle();
    }

    [Fact]
    public void Loads_Data()
    {
        (Point2D start, Dictionary<Point2D, Puzzle.CellType> grid) = Puzzle.LoadData(TestData);

        Assert.Equal(new Point2D(4, 6), start);

        Assert.Equal(Puzzle.CellType.Space, grid[new Point2D(3, 0)]);
        Assert.Equal(Puzzle.CellType.Tank, grid[new Point2D(4, 0)]);
        Assert.Equal(Puzzle.CellType.Space, grid[new Point2D(5, 0)]);
    }

    [Fact]
    public void Detects_Bounds()
    {
        (_, Dictionary<Point2D, Puzzle.CellType> grid) = Puzzle.LoadData(TestData);

        var (topLeft, bottomRight) = Puzzle.GetBounds(grid);

        Assert.Equal(new Point2D(0, 0), topLeft);
        Assert.Equal(new Point2D(9, 9), bottomRight);
    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("41", _puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("6", _puzzle.PartTwo(TestData)[0]);

    [Fact]
    public void TestPartOne() => Assert.Equal("5531", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact(Skip = "Takes a long time ~53 seconds")]
    public void TestPartTwo() => Assert.Equal("2165", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}