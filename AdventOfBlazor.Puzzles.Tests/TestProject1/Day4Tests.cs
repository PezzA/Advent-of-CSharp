using AdventOfBlazor.Puzzles.Twenty22;

namespace AdventOfBlazor.Puzzles.Tests
{
    public class Day4Tests
    {
        readonly Day4 puzzle;

        public Day4Tests()
        {
            puzzle = new Day4();
        }

        [Fact]
        public void Test_LoadData() {
            var data = puzzle.LoadData(puzzle.PuzzleInput());

            Assert.Equivalent(new Day4.Range { Lower = 54, Upper = 59 }, data[0].First);
            Assert.Equivalent(new Day4.Range { Lower = 17, Upper = 62 }, data[0].Second);
            Assert.Equivalent(new Day4.Range { Lower = 87, Upper = 90 }, data[^1].First);
            Assert.Equivalent(new Day4.Range { Lower = 89, Upper = 90 }, data[^1].Second);
        }

        [Fact]
        public void TestPartOne()
        {
            var result = puzzle.PartOne(puzzle.PuzzleInput());
            Assert.Equal("657", result[0]);
        }

        [Fact]
        public void TestPartTwo()
        {
            var result = puzzle.PartTwo(puzzle.PuzzleInput());
            Assert.Equal("938", result[0]);
        }
    }
}