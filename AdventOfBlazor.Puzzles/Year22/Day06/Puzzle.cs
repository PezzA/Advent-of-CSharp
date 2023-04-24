namespace AdventOfBlazor.Puzzles.Year22.Day06;

[PuzzleData(Year = 2022, Day = 6, Title = "Tuning Trouble", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    /// <summary>
    /// Returns the index of the first substring in input, that has all unique characters.  the length of the substring is given by markerSize.
    /// If there is series of unique characters that match the marker size it will return -1.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="markerSize"></param>
    /// <returns></returns>
    public int GetMarkerPosition(string input, int markerSize)
    {
        for (int i = 0; i < input.Length - markerSize; i++)
        {
            if (AllUniqueChars(input.Substring(i, markerSize)))
            {
                return i + markerSize;
            }
        }
        return -1;
    }


    /// <summary>
    /// Returns true if all characters in a string are unique, else it returns false.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool AllUniqueChars(string input)
    {
        var dict = new Dictionary<char, int>();

        foreach (var testChar in input)
        {
            if (!dict.ContainsKey(testChar))
            {
                dict[testChar] = 0;
            }

            dict[testChar]++;
        }

        foreach (var (_, v) in dict)
        {
            if (v > 1)
            {
                return false;
            }
        }

        return true;
    }

    public string[] PartOne(string input)
    {
        return new string[] { GetMarkerPosition(input, 4).ToString() };
    }

    public string[] PartTwo(string input)
    {
        return new string[] { GetMarkerPosition(input, 14).ToString() };
    }
}