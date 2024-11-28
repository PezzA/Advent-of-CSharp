using AdventOfCSharp.Puzzles.Year23.Day08;
using static AdventOfCSharp.Puzzles.Year23.Day08.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year23.Day08;

public class Tests
{
    private readonly IBasicPuzzle _puzzle;

    public Tests()
    {
        _puzzle = new Puzzle();
    }

    private const string TestData
        = """
          RL
          
          AAA = (BBB, CCC)
          BBB = (DDD, EEE)
          CCC = (ZZZ, GGG)
          DDD = (DDD, DDD)
          EEE = (EEE, EEE)
          GGG = (GGG, GGG)
          ZZZ = (ZZZ, ZZZ)
          """;

    private const string TestData2
        = """
          LLR

          AAA = (BBB, BBB)
          BBB = (AAA, ZZZ)
          ZZZ = (ZZZ, ZZZ)
          """;

    private const string TestData3
        = """
          LR
          
          11A = (11B, XXX)
          11B = (XXX, 11Z)
          11Z = (11B, XXX)
          22A = (22B, XXX)
          22B = (22C, 22C)
          22C = (22Z, 22Z)
          22Z = (22B, 22B)
          XXX = (XXX, XXX)
          """;
    
    [Fact]
    public void Loads_Data()
    {
        var map = LoadData(TestData);
        
        Assert.Equal(new[] {'R','L'}, map.Directions);
        Assert.Equal(new Instruction("BBB", "CCC"), map.Instructions["AAA"]);
        Assert.Equal(new Instruction("ZZZ", "ZZZ"), map.Instructions["ZZZ"]);
    }

    [Theory]
    [InlineData("2", TestData)]
    [InlineData("6", TestData2)]
    public void TestPartOne_TestData(string expected, string input) => Assert.Equal(expected, _puzzle.PartOne(input)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("6", _puzzle.PartTwo(TestData3)[0]);
        
    [Fact]
    public void TestPartOne() => Assert.Equal("16579", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    // not 1358335545
    [Fact]
    public void TestPartTwo() => Assert.Equal("12927600769609", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}