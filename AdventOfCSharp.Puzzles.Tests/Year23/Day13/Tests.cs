using Puzzle = AdventOfCSharp.Puzzles.Year23.Day13.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year23.Day13;

public class Tests
{
    private readonly IBasicPuzzle _puzzle;

    public Tests()
    {
        _puzzle = new Puzzle();
    }

    private const string TestData
        = """
          #.##..##.
          ..#.##.#.
          ##......#
          ##......#
          ..#.##.#.
          ..##..##.
          #.#.##.#.
          
          #...##..#
          #....#..#
          ..##..###
          #####.##.
          #####.##.
          ..##..###
          #....#..#
          """;

    [Fact]
    public void Loads_Data()
    {
        var patterns = Puzzle.LoadData(TestData);
        
        Assert.Equal(2, patterns.Length);

        Assert.Equal(7, patterns[0].Length);
        Assert.Equivalent(new []{true, false, true, true, false, false, true, false}, patterns[0][0]);
    }

    [Fact]
    public void Can_Find_Reflection()
    {
        var patterns = Puzzle.LoadData(TestData);
        
        Assert.Equal(new Puzzle.ReflectAnalysis(Puzzle.ReflectionType.Vertical, 5), Puzzle.Analyse(patterns[0]));
        Assert.Equal(new Puzzle.ReflectAnalysis(Puzzle.ReflectionType.Horizontal, 4), Puzzle.Analyse(patterns[^1]));
    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("405", _puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("400", _puzzle.PartTwo(TestData)[0]);
        
    [Fact]
    public void TestPartOne() => Assert.Equal("36041", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("35915", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}