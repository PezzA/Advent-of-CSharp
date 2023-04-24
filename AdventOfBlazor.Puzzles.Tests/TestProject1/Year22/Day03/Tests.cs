using AdventOfBlazor.Puzzles.Year22.Day03;

namespace AdventOfBlazor.Puzzles.Tests.Year22.Day03;

public class Tests
{
    private readonly Puzzle puzzle;

    public Tests()
    {
        puzzle = new Puzzle();
    }

    [Theory]
    [InlineData("abcdef", "abc", "def")]
    public void Test_SplitCompartment(string input, string firstActual, string secondActual)
    {
        var (first, second) = puzzle.SplitCompartments(input);

        Assert.Equal(firstActual, first);
        Assert.Equal(secondActual, second);
    }

    [Theory]
    [InlineData("abc", "def", ' ')]
    [InlineData("abc", "dec", 'c')]
    public void Test_GetSharedItem(string first, string second, char match)
    {
        var testMatch = puzzle.GetSharedItem(first, second);

        Assert.Equal(match, testMatch);
    }

    [Theory]
    [InlineData('a', 1)]
    [InlineData('z', 26)]
    [InlineData('A', 27)]
    [InlineData('Z', 52)]
    public void Test_GetItemValue(char input, int expected)
    {
        var result = puzzle.GetItemValue(input);

        Assert.Equal(expected, result);

    }

    [Fact]
    public void TestPartOne() => Assert.Equal("8243", puzzle.PartOne(puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("2631", puzzle.PartTwo(puzzle.PuzzleInput())[0]);
}