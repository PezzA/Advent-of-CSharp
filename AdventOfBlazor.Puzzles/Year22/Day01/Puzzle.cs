namespace AdventOfBlazor.Puzzles.Year22.Day01;

[PuzzleData(Year = 2022, Day = 1, Title = "Calorie Counting", Stars = 2, ImplementedElsewhere = false, PuzzleRoute = "calorie-counting")]
public partial class Puzzle : IBasicPuzzle
{
    public string[] PartOne(string input)
    {
        var items = input.Split(Environment.NewLine);
        var count = 0;
        var maxCount = 0;

        foreach (var item in items)
        {
            if (item.Trim() == string.Empty)
            {
                if (count > maxCount)
                {
                    maxCount = count;
                }
                count = 0;
                continue;
            }

            count += Convert.ToInt32(item);
        }

        return new string[] { maxCount.ToString() };
    }

    public string[] PartTwo(string input)
    {
        var items = input.Split('\n');
        var count = 0;
        var weights = new List<int>();

        foreach (var item in items)
        {
            if (item.Trim() == string.Empty)
            {
                weights.Add(count);
                count = 0;
                continue;
            }

            count += Convert.ToInt32(item);
        }

        var total = weights
            .OrderByDescending(p => p)
            .Take(3)
            .Sum();

        return new string[] { total.ToString() };
    }
}