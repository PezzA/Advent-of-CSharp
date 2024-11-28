using System.Diagnostics.CodeAnalysis;
using AdventOfCSharp.Puzzles.Year22.Day13;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Xunit.Abstractions;
using static AdventOfCSharp.Puzzles.Year22.Day13.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year22.Day13;

public class Tests
{
    private readonly IBasicPuzzle puzzle;

    public Tests(ITestOutputHelper testOutputHelper)
    {
        puzzle = new Puzzle();
        this.testOutputHelper = testOutputHelper;
    }

    private readonly ITestOutputHelper testOutputHelper;
    const string TestData = """
        [1,1,3,1,1]
        [1,1,5,1,1]

        [[1],[2,3,4]]
        [[1],4]

        [9]
        [[8,7,6]]

        [[4,4],4,4]
        [[4,4],4,4,4]

        [7,7,7,7]
        [7,7,7]

        []
        [3]

        [[[]]]
        [[]]

        [1,[2,[3,[4,[5,6,7]]]],8,9]
        [1,[2,[3,[4,[5,6,0]]]],8,9]
        """;

    [Theory]
    [InlineData("[1,1,3,1,1]", "[1,1,5,1,1]", OrderResult.InOrder)]
    [InlineData("[[1],[2,3,4]]", "[[1],4]", OrderResult.InOrder)]
    [InlineData("[[4,4],4,4]", "[[4,4],4,4,4]", OrderResult.InOrder)]
    [InlineData("[[4,4],4,4,4]", "[[4,4],4,4]", OrderResult.OutOfOrder)]
    [InlineData("[7,7,7,7]", "[7,7,7]", OrderResult.OutOfOrder)]
    [InlineData("[9]", "[[8,7,6]]", OrderResult.OutOfOrder)]
    [InlineData("[]", "[3]", OrderResult.InOrder)]
    [InlineData("[[[]]]", "[[]]", OrderResult.OutOfOrder)]
    [InlineData("[1,[2,[3,[4,[5,6,7]]]],8,9]", "[1,[2,[3,[4,[5,6,0]]]],8,9]", OrderResult.OutOfOrder)]
    public void IsPairInOrder_Succeeds(string left, string right, OrderResult expected)
    {
        var leftData = JsonConvert.DeserializeObject<JArray>(left);
        var rightData = JsonConvert.DeserializeObject<JArray>(right);

        Assert.NotNull(leftData);
        Assert.NotNull(rightData);
        Assert.Equal(expected, Puzzle.IsPairInOrder(leftData, rightData));
    }

    [Theory]
    [InlineData("[1,1,3,1,1]", 1)]
    [InlineData("[]", -1)]
    [InlineData("[[[]]]", -1)]
    [InlineData("[[4,4],4,4]", 4)]
    public void GetIndex_Succeeds(string data, int expected)
    {
        var parsedData = JsonConvert.DeserializeObject<JArray>(data);
        Assert.NotNull(parsedData);
        Assert.Equal(expected, GetIndex(parsedData));
    }




    [Fact]
    public void Parses()
    {
        var result = JsonConvert.DeserializeObject<JArray>("[[[0],[[10,9,5,1],[],[5,1,10,3,0]],[0,[8,4,2,6],[7,8,1,5,0],[0,6,4]]],[[[4,5,2,10,1],[3,5],[9,4]]],[],[[9,1,1,[10,7,4,8,10],2],7,[6,0,[8,10,10],2,6],[[10,2,3],[9,6,6],8]],[[],[3,6,[9,2]],[[10],[10,4,4],[],6,[2,8,2]],[[],[]]]]");
        Output(result, 0);
    }

    private void Output(JArray? array, int depth)
    {
        var prefix = string.Join("", Enumerable.Repeat(" ", depth * 2));
        testOutputHelper.WriteLine(prefix + "-");
        
        if(array is null)
        {
            throw new Exception("input array null");
        }

        foreach (var item in array)
        {
            if (item is JValue)
            {
                testOutputHelper.WriteLine(prefix + item.Value<int>().ToString());
                continue;
            }

            Output((JArray)item, depth + 1);
        }
    }

    [Fact]
    [SuppressMessage("Assertions", "xUnit2013:Do not use equality check to check for collection size.")]
    public void LoadsData()
    {
        var pairs = LoadData(TestData);

        if(pairs[0].Left == null){
            Assert.Fail("null value");
        }
       
        Assert.Equal(8, pairs.Count);
        Assert.Equal(5, pairs[0].Left?.Count);
        Assert.Equal(0, pairs[5].Left?.Count);
    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("13", puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("140", puzzle.PartTwo(TestData)[0]);

    [Fact]
    public void TestPartOne() => Assert.Equal("5605", puzzle.PartOne(puzzle.PuzzleInput())[0]);


    //  15642 (too low), not 31236 (too high)
    [Fact]
    public void TestPartTwo() => Assert.Equal("24969", puzzle.PartTwo(puzzle.PuzzleInput())[0]);
}