namespace AdventOfCSharp.Puzzles.Year17.Day01;

[PuzzleData(Year = 2017, Day = 1, Title = "Inverse Captcha", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public string[] PartOne(string input)
    {
        var count = 0;
        for (var i = 1; i < input.Length; i++)
        {
            if (input[i] == input[i - 1])
            {
                count+= int.Parse(input[i].ToString());
            }
        }

        if (input[0] == input[^1])
        {
            count += int.Parse(input[0].ToString());
        }

        return new string[] { count.ToString()};
    }

    private int GetWrappedIndex(int length, int divisor, int currPos)
    {
        return (currPos + length / divisor) % length;
    }

    public string[] PartTwo(string input)
    {
        var count = 0;
        for (var i = 0; i < input.Length; i++)
        {
            if (input[i] == input[GetWrappedIndex(input.Length, 2, i)])
            {
                count+= int.Parse(input[i].ToString());
            }
        }
        return new string[] { count.ToString() };
    }
}