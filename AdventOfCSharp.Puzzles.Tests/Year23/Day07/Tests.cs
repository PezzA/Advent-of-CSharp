using AdventOfCSharp.Puzzles.Year23.Day07;
using static AdventOfCSharp.Puzzles.Year23.Day07.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year23.Day07;

public class Tests
{
    private readonly IBasicPuzzle _puzzle;

    public Tests()
    {
        _puzzle = new Puzzle();
    }

    private const string TestData
        = """
          32T3K 765
          T55J5 684
          KK677 28
          KTJJT 220
          QQQJA 483
          """;

    [Fact]
    public void Loads_Data()
    {
        var hands = LoadData(TestData);

        Assert.Equivalent(new Puzzle.Hand("32T3K", 765), hands[0]);
        Assert.Equivalent(new Puzzle.Hand("QQQJA", 483), hands[^1]);
    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("6440", _puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("5905", _puzzle.PartTwo(TestData)[0]);

    // not 247968095
    [Fact]
    public void TestPartOne() => Assert.Equal("248396258", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("246436046", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}