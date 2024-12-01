using Puzzle = AdventOfCSharp.Puzzles.Year24.Day01.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year24.Day01;

public class Tests
{
    private readonly IBasicPuzzle _puzzle;

    private const string TestData
        = """
          3   4
          4   3
          2   5
          1   3
          3   9
          3   3
          """;

    public Tests() 
    {
        _puzzle = new Puzzle();
    }

    [Fact]
    public void Loads_Data()
    {
        var (fl, sl) = Puzzle.LoadData(TestData);

        Assert.Equal(3, fl[0]);
        Assert.Equal(4, sl[0]);
    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("11", _puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("31", _puzzle.PartTwo(TestData)[0]);
        
    [Fact]
    public void TestPartOne() => Assert.Equal("2756096", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("23117829", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}