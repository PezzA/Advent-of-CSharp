using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year23.Day13;

[PuzzleData(Year = 2023, Day = 13, Title = "Point of Incidence", Stars = 0, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public enum ReflectionType
    {
        None,
        Horizontal,
        Vertical
    }

    public record ReflectAnalysis(ReflectionType Type, int Index);

    public static bool[][][] LoadData(string input)
    {
        var lines = input.ParseStringArray() ?? throw new Exception("Could not parse input");

        var patterns = new List<bool[][]>();
        var pattern = new List<bool[]>();

        foreach (var line in lines)
        {
            if (string.IsNullOrEmpty(line))
            {
                patterns.Add(pattern.ToArray());
                pattern = new List<bool[]>();
                continue;
            }

            pattern.Add(line.Select(x => x == '#').ToArray());
        }

        patterns.Add(pattern.ToArray());
        return patterns.ToArray();
    }

    public bool DoesHorizontallyReflect(int index, bool[][] pattern)
    {
        var reflectIndex = 0;

        while (true)
        {
            if (index + reflectIndex + 1 >= pattern.Length ||
                index - reflectIndex < 0)
            {
                break;
            }

            if (!pattern[index - reflectIndex].SequenceEqual(pattern[index + reflectIndex + 1]))
            {
                return false;
            }

            reflectIndex += 1;
        }

        return true;
    }

    public ReflectAnalysis? ScanHorizontal(bool[][] input)
    {
        for (var row = 1; row < input.Length; row++)
        {
            if (input[row].SequenceEqual(input[row - 1]))
            {
                if (DoesHorizontallyReflect(row - 1, input))
                {
                    return new ReflectAnalysis(ReflectionType.Horizontal, row);
                }
            }
        }

        return null;
    }

    public bool ColumnsEqual(int firstIndex, int secondIndex, bool[][] pattern)
    {
        for (var row = 0; row < pattern.Length; row++)
        {
            if (pattern[row][firstIndex] != pattern[row][secondIndex])
            {
                return false;
            }
        }

        return true;
    }

    public bool DoesVerticallyReflect(int index, bool[][] pattern)
    {
        var reflectIndex = 0;

        while (true)
        {
            if (index + reflectIndex + 1 >= pattern[0].Length ||
                index - reflectIndex < 0)
            {
                break;
            }

            if (!ColumnsEqual(index - reflectIndex, index + reflectIndex + 1, pattern))
            {
                return false;
            }

            reflectIndex += 1;
        }

        return true;
    }

    public ReflectAnalysis? ScanVertical(bool[][] input)
    {
        for (var col = 1; col < input[0].Length; col++)
        {
            if (ColumnsEqual(col, col - 1, input))
            {
                if (DoesVerticallyReflect(col-1 , input))
                {
                    return new ReflectAnalysis(ReflectionType.Vertical, col);
                }
            }
        }

        return null;
    }

    public ReflectAnalysis? Analyse(bool[][] input)
    {
        var horizontalMatch = ScanHorizontal(input);

        return horizontalMatch ?? ScanVertical(input);
    }

    public string[] PartOne(string input)
    {
        var patterns = LoadData(input);

        var horizontalTotal = 0;
        var verticalTotal = 0;

        foreach (var pattern in patterns)
        {
            var result = Analyse(pattern);

            if (result.Type == ReflectionType.Horizontal)
            {
                horizontalTotal += result.Index;
            }
            else
            {
                verticalTotal += result.Index;
            }
        }

        return new[] { (verticalTotal + (100 * horizontalTotal)).ToString() };
    }

    public string[] PartTwo(string input)
    {
        return new[] { Constants.NOT_YET_IMPLEMENTED };
    }
}