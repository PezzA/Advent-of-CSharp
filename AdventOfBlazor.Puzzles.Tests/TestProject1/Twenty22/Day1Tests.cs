using AdventOfBlazor.Puzzles.Twenty22;

namespace AdventOfBlazor.Puzzles.Tests.Twenty22
{
    public class Day1Tests
    {



        [Fact]
        public void TestPartOne()
        {
            IBasicPuzzle puzz = new Day1();

            var result = puzz.PartOne(puzz.PuzzleInput());

            Assert.Equal("72017", result[0]);
        }

        [Fact]
        public void TestPartTwo()
        {
            IBasicPuzzle puzz = new Day1();

            var result = puzz.PartTwo(puzz.PuzzleInput());

            Assert.Equal("212520", result[0]);
        }
    }
}