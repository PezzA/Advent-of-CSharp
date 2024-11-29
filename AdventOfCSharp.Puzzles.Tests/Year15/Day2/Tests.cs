using static AdventOfCSharp.Puzzles.Year15.Day02.Puzzle;
using Puzzle = AdventOfCSharp.Puzzles.Year15.Day02.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year15.Day02;

public class Tests
{
    private readonly IBasicPuzzle _puzzle;

    private const string TestData
        = """
          2x3x4
          """;

    public Tests() 
    {
        _puzzle = new Puzzle();
    }


    [Theory]
    [InlineData(52, 2, 3, 4)]
    [InlineData(42, 1, 1, 10)]
    public void Box_Calculates_Surface_Area(int expectedResult, int length, int width, int height)
    {
        var box = new Box(length, width, height);

        Assert.Equal(expectedResult, box.SurfaceArea);
    }

    [Fact]
    public void Loads_Data()
    {
        
    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("58", _puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("34", _puzzle.PartTwo(TestData)[0]);
        
    [Fact]
    public void TestPartOne() => Assert.Equal("1588178", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("3783758", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}