using Puzzle = AdventOfCSharp.Puzzles.Year23.Day15.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year23.Day15;

public class Tests
{
    private readonly IBasicPuzzle _puzzle;

    public Tests()
    {
        _puzzle = new Puzzle();
    }

    private const string TestData
        = """
          rn=1,cm-,qp=3,cm=2,qp-,pc=4,ot=9,ab=5,pc-,pc=6,ot=7
          """;

    [Fact]
    public void Loads_Data()
    {
        var items = Puzzle.LoadData(TestData);
        
        Assert.Equal(52, Puzzle.GetHash("HASH"));
        Assert.Equal(30, Puzzle.GetHash(items[0]));
    }

    [Fact]
    public void Gets_HashMap()
    {
        var items = Puzzle.LoadData(TestData);

        var hashMap = Puzzle.SetupLens(items);
    } 

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("1320", _puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("145", _puzzle.PartTwo(TestData)[0]);
        
    [Fact]
    public void TestPartOne() => Assert.Equal("506869", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("271384", _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}