using AdventOfCSharp.Puzzles.Year23.Day03;

namespace AdventOfCSharp.Puzzles.Tests.Year23.Day03;

public class Tests
{
    private readonly Puzzle _puzzle = new();

    private static readonly string TestData
        = """
          467..114..
          ...*......
          ..35..633.
          ......#...
          617*......
          .....+.58.
          ..592.....
          ......755.
          ...$.*....
          .664.598..
          """;

    [Fact]
    public void Loads_Data()
    {
    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("4361", _puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("467835", _puzzle.PartTwo(TestData)[0]);
        
    [Fact]
    public void TestPartOne() => Assert.Equal("537732", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("84883664", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}