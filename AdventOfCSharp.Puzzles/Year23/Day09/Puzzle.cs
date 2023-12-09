using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year23.Day09;

[PuzzleData(Year = 2023, Day = 9, Title = "Mirage Maintenance", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public static int[][] LoadData(string input)
    {
        var lines = input.ParseStringArray() ?? throw new Exception("could not parse input");

        var histories = new int[lines.Length][];

        foreach (var (line, index) in lines.Select((value, i) => (value, i)))
        {
            histories[index] = line
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
        }

        return histories;
    }

    public static int[] GetSequence(int[] input)
    {
        var newSequence = new int[input.Length - 1];

        for (var index = 1; index < input.Length; index++)
        {
            newSequence[index - 1] = input[index] - input[index - 1];
        }

        return newSequence;
    }

    public static int[][] GenerateStepList(int[] input)
    {
        var stepList = new List<int[]>();
        stepList.Add(input);
        while (input.Any(x => x != 0))
        {
            input = GetSequence(input);
            stepList.Add(input);
        }

        return stepList.ToArray();
    }

    public static int[][] ExtrapolateNextValue(int[][] input)
    {
        for (var index = input.Length - 1; index >= 0; index--)
        {
            input[index] = input[index].Append(0).ToArray();

            if (index == input.Length - 1) continue;

            input[index][^1] = input[index][^2] + input[index + 1][^1];
        }

        return input;
    }

    private static int[][] ExtrapolatePreviousValue(int[][] input)
    {
        for (var index = input.Length - 1; index >= 0; index--)
        {
            input[index] = input[index].Prepend(0).ToArray();

            if (index == input.Length - 1) continue;

            input[index][0] = input[index][1] - input[index + 1][0];
        }

        return input;
    }
    public string[] PartOne(string input)
    {
        var data = LoadData(input);

        var total = 0;

        foreach (var history in data)
        {
            var steps = GenerateStepList(history);
            var extrapolated = ExtrapolateNextValue(steps);
            
            total += extrapolated[0][^1];
        }

        return new[] { total.ToString()};
    }

    public string[] PartTwo(string input)
    {
        var data = LoadData(input);

        var total = 0;

        foreach (var history in data)
        {
            var steps = GenerateStepList(history);
            var extrapolated = ExtrapolatePreviousValue(steps);
            
            total += extrapolated[0][0];
        }

        return new[] { total.ToString()};
    }
}