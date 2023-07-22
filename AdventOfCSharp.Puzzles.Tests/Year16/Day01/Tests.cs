using AdventOfCSharp.Puzzles.Year16.Day01;

namespace AdventOfCSharp.Puzzles.Tests.Year16.Day01;

public class Tests
{
    private readonly Puzzle puzzle;

    public Tests()
    {
        puzzle = new Puzzle();
    }

    [Theory]
    [InlineData("R5, L5, R5, R3", "12")]
    [InlineData("R2, R2, R2", "2")]
    [InlineData("R2, L3", "5")]
    public void PartOneTestCases(string input, string expectedResult) => Assert.Equal(expectedResult, puzzle.PartOne(input)[0]);
   
    [Fact]
    public void TestPartOne() => Assert.Equal("241", puzzle.PartOne(puzzle.PuzzleInput())[0]);
    
    [Fact]
    public void TestPartTwo() => Assert.Equal("116", puzzle.PartTwo(puzzle.PuzzleInput())[0]);
}