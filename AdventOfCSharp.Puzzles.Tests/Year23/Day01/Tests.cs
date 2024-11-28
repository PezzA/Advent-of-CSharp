using AdventOfCSharp.Puzzles.Year23.Day01;

namespace AdventOfCSharp.Puzzles.Tests.Year23.Day01;

public class Tests
{
    private readonly IBasicPuzzle _puzzle = new Puzzle();

    private static readonly string TestData
        = """
          1abc2
          pqr3stu8vwx
          a1b2c3d4e5f
          treb7uchet
          """;

    private const string TestDataPart2
        = """
          two1nine
          eightwothree
          abcone2threexyz
          xtwone3four
          4nineeightseven2
          zoneight234
          7pqrstsixteen
          """;

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("142", _puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("281", _puzzle.PartTwo(TestDataPart2)[0]);
        
    [Fact]
    public void TestPartOne() => Assert.Equal("54450", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("54265", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}