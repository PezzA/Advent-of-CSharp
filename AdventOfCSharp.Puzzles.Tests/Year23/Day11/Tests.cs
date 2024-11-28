using Puzzle = AdventOfCSharp.Puzzles.Year23.Day11.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year23.Day11;

public class Tests
{
    private readonly IBasicPuzzle _puzzle;

    public Tests()
    {
        _puzzle = new Puzzle();
    }

    private const string TestData
        = """
          ...#......
          .......#..
          #.........
          ..........
          ......#...
          .#........
          .........#
          ..........
          .......#..
          #...#.....
          """;


    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("374", _puzzle.PartOne(TestData)[0]);

    [Fact(Skip = "not ready yet")]   
    public void TestPartTwo_TestData() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, _puzzle.PartTwo(TestData)[0]);
        
    [Fact]
    public void TestPartOne() => Assert.Equal("9403026", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Theory(Skip = "not ready yet")]
    [InlineData(1, 374)]
    [InlineData(10, 1030)]
    [InlineData(100, 8410)]
    public void Solves_Part_Two(int ageFactor, long expected)
    {
        Assert.Equal(expected, Puzzle.SolvePartTwo(TestData, ageFactor));
    }


    [Fact(Skip = "not ready yet")]
    public void TestPartTwo() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}