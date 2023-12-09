using AdventOfCSharp.Puzzles.Year23.Day09;
using static AdventOfCSharp.Puzzles.Year23.Day09.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year23.Day09;

public class Tests
{
    private readonly Puzzle _puzzle = new();

    private const string TestData
        = """
          0 3 6 9 12 15
          1 3 6 10 15 21
          10 13 16 21 30 45
          """;

    [Fact]
    public void Loads_Data()
    {
        var histories = LoadData(TestData);

        Assert.Equivalent(new[] { 0, 3, 6, 9, 12, 15 }, histories[0]);
        Assert.Equivalent(new[] { 10, 13, 16, 21, 30, 45 }, histories[^1]);
    }

    [Theory]
    [InlineData(new[] { 0, 3, 6, 9, 12, 15 }, new[] { 3, 3, 3, 3, 3 })]
    [InlineData(new[] { 3, 3, 3, 3, 3 }, new[] { 0, 0, 0, 0 })]
    [InlineData(new[] { 10, 13, 16, 21, 30, 45, 68 }, new[] { 3, 3, 5, 9, 15, 23 })]
    [InlineData(new[] { 3, 3, 5, 9, 15, 23 }, new[] { 0, 2, 4, 6, 8 })]
    [InlineData(new[] { 0, -1, -2, -3 }, new[] { -1, -1, -1 })]
    public void Generates_Next_Sequence(int[] test, int[] expected)
    {
        Assert.Equivalent(expected, GetSequence(test));
    }

    [Fact]
    public void Generates_Sequence_Steps()
    {
        var data = LoadData(TestData);
        var history = GenerateStepList(data[0]);
        
        Assert.Equal(3, history.Length);

        var history2 = GenerateStepList(data[^1]);
        
        Assert.Equal(5, history2.Length);
        Assert.Equal(2, history2[^1].Length);
    }

    [Fact]
    public void Extrapolates_Values()
    {
        var testHistory = LoadData(TestData)[0];
        var historySteps = GenerateStepList(testHistory);
        var extrapolatedValues = ExtrapolateNextValue(historySteps);
       
        Assert.Equal(18, extrapolatedValues[0][^1]);
    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("114", _puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("2", _puzzle.PartTwo(TestData)[0]);

    [Fact]
    public void TestPartOne() => Assert.Equal("1762065988", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("1066", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}