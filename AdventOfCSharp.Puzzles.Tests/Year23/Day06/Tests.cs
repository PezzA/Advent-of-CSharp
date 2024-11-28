using Puzzle = AdventOfCSharp.Puzzles.Year23.Day06.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year23.Day06;

public class Test
{
    private readonly IBasicPuzzle _puzzle = new Puzzle();

    private const string TestData
        = """
          Time:      7  15   30
          Distance:  9  40  200
          """;

    [Fact]
    public void Loads_Data()
    {
        var races = Puzzle.LoadData(TestData);
        
        Assert.Equivalent(new Puzzle.Race[]{ new (7, 9), new (15, 40), new (30,200)}, races);
    }

    [Theory]
    [InlineData(7, 9, 4)]
    [InlineData(15, 40, 8)]
    [InlineData(30, 200, 9)]
    public void Calculates_Distance(int time, int distance, int expected)
    {
        var race = new Puzzle.Race(time, distance);
        Assert.Equal(expected, Puzzle.GetWinCount(race));
    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("288", _puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("71503", _puzzle.PartTwo(TestData)[0]);
        
    [Fact]
    public void TestPartOne() => Assert.Equal("625968", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("43663323", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}