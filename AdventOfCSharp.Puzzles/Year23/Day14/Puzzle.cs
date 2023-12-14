using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year23.Day14;

[PuzzleData(Year = 2024, Day = 14, Title = "Parabolic Reflector Dish", Stars = 0)]
public partial class Puzzle : IBasicPuzzle
{
    public record Segment(int Start, int End);

    public enum Contents
    {
        Empty,
        Rounded,
        Cube
    }

    public Contents[][] LoadData(string input)
    {
        var lines = input.ParseStringArray() ?? throw new Exception("Could not parse array");

        var contents = new List<Contents[]>();

        foreach (var line in lines)
        {
            contents.Add(line.Select(x => x switch
            {
                'O' => Contents.Rounded,
                '#' => Contents.Cube,
                '.' => Contents.Empty,
                _ => throw new ArgumentOutOfRangeException(nameof(x), x, null)
            }).ToArray());
        }

        return contents.ToArray();
    }

    public Segment[] GetSegments(Contents[] input)
    {
        var segments = new List<Segment>();

        var segmentStart = 0;

        for (var index = 0; index < input.Length; index++)
        {
            if (input[index] == Contents.Cube)
            {
                segments.Add(new Segment(segmentStart, index - 1));
                segmentStart = index + 1;
            }
        }

        segments.Add(new Segment(segmentStart, input.Length - 1));
        return segments.Where(s => s.Start <= s.End).ToArray();
    }

    public Segment[] GetVerticalSegments(int index, Contents[][] grid)
    {
        var contentLine = new Contents[grid.Length];

        for (var y = 0; y < grid.Length; y++)
        {
            contentLine[y] = grid[y][index];
        }

        return GetSegments(contentLine);
    }

    public Contents[][] SlideVertical(Contents[][] grid, bool north = true)
    {
        for (var x = 0; x < grid.Length; x++)
        {
            var segments = GetVerticalSegments(x, grid);

            foreach (var segment in segments)
            {
                var subSegment = new Contents[(segment.End - segment.Start) + 1];
                
                for (var segIndex = segment.Start; segIndex <= segment.End; segIndex++)
                {
                    subSegment[segIndex - segment.Start] = grid[segIndex][x];
                }

                var sortedSegments = north
                    ? subSegment.OrderDescending().ToArray()
                    : subSegment.Order().ToArray();
                
                for (var segIndex = segment.Start; segIndex <= segment.End; segIndex++)
                {
                    grid[segIndex][x] = sortedSegments[segIndex- segment.Start];
                }
            }
        }

        return grid;
    }

    public int GetLoad(Contents[][] grid)
    {
        var total = 0;
        for (var index = 0; index < grid.Length; index++)
        {
            foreach (var content in grid[index])
            {
                if (content == Contents.Rounded)
                {
                    total += grid.Length - index;
                }
            }
        }

        return total;
    }

    public string[] PartOne(string input)
    {
        var data = LoadData(input);

        var tiltedData = SlideVertical(data);
        return new[] { GetLoad(data).ToString()};
    }

    public string[] PartTwo(string input)
    {
        return new[] { Constants.NOT_YET_IMPLEMENTED };
    }
}