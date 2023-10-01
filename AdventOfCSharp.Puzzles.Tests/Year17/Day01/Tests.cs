using AdventOfCSharp.Puzzles.Year17.Day01;

namespace AdventOfCSharp.Puzzles.Tests.Year17.Day01;

public class Tests
{
    private readonly Puzzle _puzzle;

    public Tests()
    {
        _puzzle = new();
    }
    
    [Theory]
    [InlineData("1122", 3)]
    [InlineData("1111", 4)]
    [InlineData("1234", 0)]
    [InlineData("91212129", 9)]
    public void Test_PartOne_TestData(string testCase, int expected)
    {
        Assert.Equal(_puzzle.PartOne(testCase)[0],expected.ToString());
    }

    [Theory]
    [InlineData("1212", 6)]
    [InlineData("1221", 0)]
    [InlineData("123425", 4)]
    [InlineData("123123", 12)]
    [InlineData("12131415", 4)]
    public void Test_PartTwo_TestData(string testCase, int expected)
    {
        Assert.Equal(_puzzle.PartTwo(testCase)[0],expected.ToString());
    }
    
    [Fact]
    public void TestPartOne() => Assert.Equal("1044", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("1054", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}