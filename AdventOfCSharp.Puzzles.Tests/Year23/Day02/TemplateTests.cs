using AdventOfCSharp.Puzzles.Year23.Day02;
using static AdventOfCSharp.Puzzles.Year23.Day02.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year23.Day02;

public class Tests
{
    private readonly IBasicPuzzle _puzzle;

    public Tests()
    {
        _puzzle = new Puzzle();
    }

    private const string TestData
        = """
          Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
          Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue
          Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red
          Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red
          Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green
          """;

    [Fact]
    public void Loads_Data()
    {
        var games = LoadData(_puzzle.PuzzleInput());
        
        Assert.Equivalent(new Game(1, new Draw[]
        {
            new (4,4,16),
            new (0,5,14),
            new (1,3,5)
        } ), games[0]);
        
        Assert.Equivalent(new Game(100, new Draw[]
        {
            new (3,3,6),
            new (16,7,2),
            new (9,9,14),
            new (9,8,10),
            new (6,11,0)
        } ), games[^1]);
    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("8", _puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("2286", _puzzle.PartTwo(TestData)[0]);
        
    [Fact]
    public void TestPartOne() => Assert.Equal("2156", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("66909", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}