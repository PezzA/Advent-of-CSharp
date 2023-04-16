using AdventOfBlazor.Puzzles.Twenty22;

namespace AdventOfBlazor.Puzzles.Tests
{
    public class Day6Tests
    {
        readonly Day6 puzzle;

        public Day6Tests()
        {
            puzzle = new Day6();
        }

        [Fact]
        public void TestPartOne()
        {
            var result = puzzle.PartOne(puzzle.PuzzleInput());
            Assert.Equal("1850", result[0]);
        }

        [Fact]
        public void TestPartTwo()
        {
            var result = puzzle.PartTwo(puzzle.PuzzleInput());
            Assert.Equal("2823", result[0]);
        }
    }
}