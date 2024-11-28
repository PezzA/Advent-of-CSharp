using Puzzle = AdventOfCSharp.Puzzles.Year23.Day19.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year23.Day19;

public class Tests
{
    private readonly IBasicPuzzle _puzzle = new Puzzle();

    private const string TestData
        = """
          px{a<2006:qkq,m>2090:A,rfg}
          pv{a>1716:R,A}
          lnx{m>1548:A,A}
          rfg{s<537:gd,x>2440:R,A}
          qs{s>3448:A,lnx}
          qkq{x<1416:A,crn}
          crn{x>2662:A,R}
          in{s<1351:px,qqz}
          qqz{s>2770:qs,m<1801:hdj,R}
          gd{a>3333:R,R}
          hdj{m>838:A,pv}

          {x=787,m=2655,a=1222,s=2876}
          {x=1679,m=44,a=2067,s=496}
          {x=2036,m=264,a=79,s=2244}
          {x=2461,m=1339,a=466,s=291}
          {x=2127,m=1623,a=2188,s=1013}
          """;

    [Fact]
    public void Loads_Data()
    {
        var (processes, items) = Puzzle.LoadData(TestData);

        Assert.Equal(5, items.Length);
        Assert.Equal(11, processes.Count);
    }

    [Fact]
    public void Detects_Acceptance()
    {
        var (processes, items) = Puzzle.LoadData(TestData);

        Assert.True(Puzzle.IsAccepted(items[0], processes));
        Assert.False(Puzzle.IsAccepted(items[1], processes));
        Assert.True(Puzzle.IsAccepted(items[2], processes));
        Assert.False(Puzzle.IsAccepted(items[3], processes));
        Assert.True(Puzzle.IsAccepted(items[4], processes));
    }


    [Fact]
    public void Can_Hit_Max()
    {
        Assert.Equal(256000000000000L, 4000L * 4000L * 4000L * 4000L);

        Assert.Equal(86400000000000L, 1350L * 4000L * 4000L * 4000L);
        Assert.Equal(169600000000000L, 2650L * 4000L * 4000L * 4000L);
    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("19114", _puzzle.PartOne(TestData)[0]);

    [Fact(Skip =  "not yet implemented")]
    public void TestPartTwo_TestData() => Assert.Equal("25600000000000", _puzzle.PartTwo(TestData)[0]);

    [Fact]
    public void TestPartOne() => Assert.Equal("382440", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact(Skip =  "not yet implemented")]
    public void TestPartTwo() => Assert.Equal("25600000000000", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}