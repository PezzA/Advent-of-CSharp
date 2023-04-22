using AdventOfBlazor.Puzzles.Twenty22;

namespace AdventOfBlazor.Puzzles.Tests.Twenty22
{
    public class Day2Tests
    {
        readonly Day2 puzzle;

        public Day2Tests()
        {
            puzzle = new Day2();
        }

        [Fact]
        public void TestLoadData()
        {
            var data = puzzle.LoadData(puzzle.PuzzleInput());

            Assert.NotNull(data);
            Assert.Equivalent(new Day2.Instruction { OpponentPlay = "A", MyPlay = "Y" }, data[0]);
            Assert.Equivalent(new Day2.Instruction { OpponentPlay = "A", MyPlay = "Y" }, data[^1]);
        }

        [Fact]
        public void TestPartOne()
        {
            var result = puzzle.PartOne(puzzle.PuzzleInput());
            Assert.Equal("15632", result[0]);
        }

        [Fact]
        public void TestPartTwo()
        {
            var result = puzzle.PartTwo(puzzle.PuzzleInput());
            Assert.Equal("14416", result[0]);
        }
    }
}