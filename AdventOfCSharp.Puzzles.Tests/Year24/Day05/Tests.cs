using Puzzle = AdventOfCSharp.Puzzles.Year24.Day05.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year24.Day05;

public class Tests
{
    private readonly IBasicPuzzle _puzzle;

    private const string TestData
        = """
          47|53
          97|13
          97|61
          97|47
          75|29
          61|13
          75|53
          29|13
          97|29
          53|29
          61|53
          97|53
          61|29
          47|13
          75|47
          97|75
          47|61
          75|61
          47|29
          75|13
          53|13

          75,47,61,53,29
          97,61,53,29,13
          75,29,13
          75,97,47,61,53
          61,13,29
          97,13,75,29,47
          """;

    public Tests()
    {
        _puzzle = new Puzzle();
    }

    [Fact]
    public void Loads_Data()
    {
        var (insList, pageList) = Puzzle.LoadData(TestData);

        Assert.Equal(new Puzzle.Instruction(47, 53), insList.First());
        Assert.Equal(new Puzzle.Instruction(53, 13), insList.Last());

        Assert.Equal(new List<int>() { 75, 47, 61, 53, 29 }, pageList.First());
        Assert.Equal(new List<int>() { 97, 13, 75, 29, 47 }, pageList.Last());
    }


    [Fact]
    public void CanDetectOrder()
    {
        var (insList, pageList) = Puzzle.LoadData(TestData);

        Assert.True(Puzzle.IsPageListInOrder(pageList[0], insList));
        Assert.True(Puzzle.IsPageListInOrder(pageList[1], insList));
        Assert.True(Puzzle.IsPageListInOrder(pageList[2], insList));
        Assert.False(Puzzle.IsPageListInOrder(pageList[3], insList));
        Assert.False(Puzzle.IsPageListInOrder(pageList[4], insList));
        Assert.False(Puzzle.IsPageListInOrder(pageList[5], insList));


    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("143", _puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("123", _puzzle.PartTwo(TestData)[0]);

    [Fact]
    public void TestPartOne() => Assert.Equal("5762", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("4130", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}