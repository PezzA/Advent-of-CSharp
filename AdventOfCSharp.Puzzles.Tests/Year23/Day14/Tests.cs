using Puzzle = AdventOfCSharp.Puzzles.Year23.Day14.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year23.Day14;

public class Tests
{
    private readonly Puzzle _puzzle = new();

    private const string TestData
        = """
          O....#....
          O.OO#....#
          .....##...
          OO.#O....O
          .O.....O#.
          O.#..O.#.#
          ..O..#O..O
          .......O..
          #....###..
          #OO..#....
          """;

    [Fact]
    public void Loads_Data()
    {
        var data = _puzzle.LoadData(TestData);

        var segments = _puzzle.GetSegments(data[5]);
        
        Assert.Equal(3, segments.Length);

        segments = _puzzle.GetSegments(data[8]);
        
        Assert.Equal(2, segments.Length);

        segments = _puzzle.GetVerticalSegments(0, data);
        
        Assert.Single(segments);

    }

    [Fact]
    public void Tilts_North()
    {
        var data = _puzzle.LoadData(TestData);

        var tiltedData = _puzzle.SlideVertical(data);
        
        Assert.Equal(data.Length, tiltedData.Length); 
    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("136", _puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, _puzzle.PartTwo(TestData)[0]);
        
    [Fact]
    public void TestPartOne() => Assert.Equal("106648", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}