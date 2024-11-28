using AdventOfCSharp.Puzzles.Year19.Day01;

namespace AdventOfCSharp.Puzzles.Tests.Year19.Day01;

public class Tests
{
    private readonly IBasicPuzzle _puzzle;

    public Tests() 
    {
        _puzzle = new Puzzle();
    }

    private static readonly string TestData = string.Empty;

    [Theory]
    [InlineData(12, 2)]
    [InlineData(14, 2)]
    [InlineData(1969, 654)]
    [InlineData(100756, 33583)]
    public void Test_CalculateRequiredFuel(int mass, int expected)
    {
        Assert.Equal(expected, Puzzle.CalculateFuel(mass));
    }

    [Theory]
    [InlineData(14, 2)]
    [InlineData(1969, 966)]
    [InlineData(100756, 50346)]
    public void Test_CalculateRecursiveRequiredFuel(int mass, int expected)
    {
        Assert.Equal(expected, Puzzle.CalculateRecursiveFuel(mass));
    }
    
    [Fact]
    public void Test_LoadsData()
    {
        var data = Puzzle.LoadData(_puzzle.PuzzleInput());
        
        Assert.Equal(100, data.Count);
        Assert.Equal(141589, data[0]);
        Assert.Equal(111303, data[^1]);
    }
        
    [Fact]
    public void TestPartOne() => Assert.Equal("3420719", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal( "5128195", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}