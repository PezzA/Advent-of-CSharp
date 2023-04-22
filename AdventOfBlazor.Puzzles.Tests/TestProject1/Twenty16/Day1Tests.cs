using AdventOfBlazor.Puzzles.Twenty16;

namespace AdventOfBlazor.Puzzles.Tests.Twenty16
{
    public class Day1Tests
    {
        [Theory]
        [InlineData("R5, L5, R5, R3", "12")]
        [InlineData("R2, R2, R2","2")]
        [InlineData("R2, L3", "5")]
        public void PartOneTestCases(string input, string expectedResult)
        {
            IBasicPuzzle puzz = new Day1();

            var result = puzz.PartOne(input);

            Assert.Equal(expectedResult, result[0]);
        }

        [Fact]
        public void TestPartOne()
        {
            IBasicPuzzle puzz = new Day1();

            var result = puzz.PartOne(puzz.PuzzleInput());

            Assert.Equal("241", result[0]);
        }

        [Fact]
        public void TestPartTwo()
        {
            IBasicPuzzle puzz = new Day1();

            var result = puzz.PartTwo(puzz.PuzzleInput());

            Assert.Equal("116", result[0]);
        }
    }
}