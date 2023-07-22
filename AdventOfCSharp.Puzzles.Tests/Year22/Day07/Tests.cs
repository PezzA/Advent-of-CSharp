using AdventOfCSharp.Puzzles.Year22.Day07;

namespace AdventOfCSharp.Puzzles.Tests.Year22.Day07;

public class Tests
{
    private readonly Puzzle puzzle;

    public Tests()
    {
        puzzle = new Puzzle();
    }

    private const string TEST_DATA = """
        $ cd /
        $ ls
        dir a
        14848514 b.txt
        8504156 c.dat
        dir d
        $ cd a
        $ ls
        dir e
        29116 f
        2557 g
        62596 h.lst
        $ cd e
        $ ls
        584 i
        $ cd ..
        $ cd ..
        $ cd d
        $ ls
        4060174 j
        8033020 d.log
        5626152 d.ext
        7214296 k
        """;

    [Fact]
    public void Loads_Data() {
        var directoryStructure = Puzzle.LoadData(TEST_DATA);

        Assert.NotNull(directoryStructure);
    }

    [Fact]
    public void TestPartOne() => Assert.Equal("1648397", puzzle.PartOne(puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal("1815525", puzzle.PartTwo(puzzle.PuzzleInput())[0]);
}