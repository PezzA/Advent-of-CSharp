using AdventOfCSharp.Puzzles.Geometery;
using AdventOfCSharp.Puzzles.Year22.Day12;

namespace AdventOfCSharp.Puzzles.Tests.Year22.Day12;

public class Tests
{
    private readonly IBasicPuzzle puzzle;

    const string TestData = """
        Sabqponm
        abcryxxl
        accszExk
        acctuvwj
        abdefghi
        """;

    public Tests()
    {
        puzzle = new Puzzle();
    }

    [Fact]
    public void LoadsData()
    {
        var map = Puzzle.LoadData(TestData);
        Assert.Equal(40, map.Count);

        Assert.Equal(Puzzle.GetStart(map), new Point2D(0, 0));
        Assert.Equal(Puzzle.GetEnd(map), new Point2D(5, 2));
    }


    [Fact]
    public void Walks()
    {
        var map = Puzzle.LoadData(TestData);
        var distances = Puzzle.WalkMap(map, Puzzle.GetStart(map));

        Assert.Equal(31, distances[Puzzle.GetEnd(map)]);
    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("31", puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("29", puzzle.PartTwo(TestData)[0]);

    [Fact]
    public void TestPartOne() => Assert.Equal("380", puzzle.PartOne(puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("375", puzzle.PartTwo(puzzle.PuzzleInput())[0]);
}