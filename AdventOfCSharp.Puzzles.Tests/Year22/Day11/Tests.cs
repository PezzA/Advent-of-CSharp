using AdventOfCSharp.Puzzles.Year22.Day11;
using System.Numerics;
using Xunit.Abstractions;
using static AdventOfCSharp.Puzzles.Year22.Day11.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year22.Day11;

public class Tests
{
    private readonly IBasicPuzzle puzzle;
    private readonly ITestOutputHelper _output;
    private const string TestData = $$"""
        Monkey 0:
          Starting items: 79, 98
          Operation: new = old * 19
          Test: divisible by 23
            If true: throw to monkey 2
            If false: throw to monkey 3
        Monkey 1:
          Starting items: 54, 65, 75, 74
          Operation: new = old + 6
          Test: divisible by 19
            If true: throw to monkey 2
            If false: throw to monkey 0

        Monkey 2:
          Starting items: 79, 60, 97
          Operation: new = old * old
          Test: divisible by 13
            If true: throw to monkey 1
            If false: throw to monkey 3

        Monkey 3:
          Starting items: 74
          Operation: new = old + 3
          Test: divisible by 17
            If true: throw to monkey 0
            If false: throw to monkey 1
        """;
    public Tests(ITestOutputHelper output)
    {
        puzzle = new Puzzle();
        _output = output;
    }

    [Fact]
    public void LoadsData()
    {
        var monkeys = Puzzle.LoadData(puzzle.PuzzleInput());
        Assert.NotNull(monkeys);
        Assert.True(monkeys.Count == 8);

        Assert.Equal(8, monkeys.First().Items.Count);
        Assert.Equal(WorryOperation.Multiply, monkeys.First().Operation);

        Assert.Equal(2, monkeys[5].Items.Count);
        Assert.Equal(WorryOperation.Multiply, monkeys[4].Operation);
        Assert.Equal(-1, monkeys[5].OperationValue);
    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("10605", puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartOne() => Assert.Equal("90882", puzzle.PartOne(puzzle.PuzzleInput())[0]);

    [Fact(Skip = "Too long running")]
    public void TestPartTwo_TestData()
    {
        var monkeys = LoadData(TestData);

        for (int i = 0; i < 1000; i++)
        {
            monkeys = RunRound(monkeys, 0);
            Console.WriteLine(i);
            _output.WriteLine(i.ToString());
        }

        var items = monkeys.Select(x => new BigInteger(x.Inspections))
            .OrderDescending()
            .Take(2)
            .ToList();

        Assert.Equal("2713310158", (items[0] * items[1]).ToString());
    }

    [Fact(Skip = "Too long running")]
    public void TestPartTwo() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, puzzle.PartTwo(puzzle.PuzzleInput())[0]);
}