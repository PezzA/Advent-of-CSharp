using Puzzle = AdventOfCSharp.Puzzles.Year23.Day04.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year23.Day04;

public class Tests
{
    private readonly IBasicPuzzle _puzzle;

    public Tests()
    {
        _puzzle = new Puzzle();
    }


    private const string TestData
        = """
          Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53
          Card 2: 13 32 20 16 61 | 61 30 68 82 17 32 24 19
          Card 3:  1 21 53 59 44 | 69 82 63 72 16 21 14  1
          Card 4: 41 92 73 84 69 | 59 84 76 51 58  5 54 83
          Card 5: 87 83 26 28 32 | 88 30 70 12 93 22 82 36
          Card 6: 31 18 13 56 72 | 74 77 10 23 35 67 36 11
          """;

    [Fact]
    public void Loads_Data()
    {
        var cards = Puzzle.LoadData(TestData);

        Assert.Equivalent(cards[0], new Puzzle.Card(
            1,
            new[] { 41, 48, 83, 86, 17 },
            new[] { 83, 86, 6, 31, 17, 9, 48, 53 }));
    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("13", _puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("30", _puzzle.PartTwo(TestData)[0]);

    [Fact]
    public void TestPartOne() => Assert.Equal("15205", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("6189740", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}