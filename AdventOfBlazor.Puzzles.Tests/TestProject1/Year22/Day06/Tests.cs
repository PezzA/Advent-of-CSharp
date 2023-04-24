using AdventOfBlazor.Puzzles.Year22.Day06;

namespace AdventOfBlazor.Puzzles.Tests.Year22.Day06
{
    public class Tests
    {
        readonly Puzzle puzzle;

        public Tests()
        {
            puzzle = new Puzzle();
        }

        [Fact]
        public void TestPartOne() => Assert.Equal("1850", puzzle.PartOne(puzzle.PuzzleInput())[0]);

        [Fact]
        public void TestPartTwo() => Assert.Equal("2823", puzzle.PartTwo(puzzle.PuzzleInput())[0]);
    }
}