
using static AdventOfCSharp.Puzzles.Year24.Day03.Puzzle;
using Puzzle = AdventOfCSharp.Puzzles.Year24.Day03.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year24.Day3;

public class Tests
{
    private readonly IBasicPuzzle _puzzle;

    private const string TestData
        = """
          xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))
          """;


    private const string TestDataPart2
        = """
          xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))
          """;

    public Tests() 
    {
        _puzzle = new Puzzle();
    }

    [Fact]
    public void Loads_Data()
    {
        var instructions = Puzzle.LoadData(TestData);

        Assert.Equal(4, instructions.Count);

        Assert.Equal(new Instruction(InstructionType.Mul, 2, 4), instructions[0]);
        Assert.Equal(new Instruction(InstructionType.Mul, 8, 5), instructions[3]);
    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("161", _puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("48", _puzzle.PartTwo(TestDataPart2)[0]);
        
    [Fact]
    public void TestPartOne() => Assert.Equal("187194524", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}