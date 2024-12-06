namespace AdventOfCSharp.Puzzles.Year24.Day04;

using AdventOfCSharp.Puzzles.Geometery;
using AdventOfCSharp.Puzzles.Parsing;
using Grid = Dictionary<Geometery.Point2D, char>;

[PuzzleData(Year = 2024, Day = 4, Title = "Ceres Search", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{

    public static List<Point2D> Checks =
        [
            new Point2D( 0, -1),
            new Point2D( 1, -1),
            new Point2D( 1,  0),
            new Point2D( 1,  1),
            new Point2D( 0,  1),
            new Point2D(-1,  1),
            new Point2D(-1,  0),
            new Point2D(-1, -1),
        ];

    public static Grid LoadData(string input)
    {
        var lines = input.ParseStringArray() ?? throw new Exception("Could not parse data");

        var grid = new Grid();

        for (int y = 0; y < lines.Length; y++)
        {
            for (int x = 0; x < lines[y].Length; x++)
            {
                grid[new Geometery.Point2D(x, y)] = lines[y][x];
            }
        }
        return grid;
    }

    public static bool MatchGridCell(Grid grid, Point2D point, char compare)
    {
        if (!grid.ContainsKey(point)) return false;

        return grid[point] == compare;
    }


    public static string GetGridCell(Grid grid, Point2D point)
    {
        if (!grid.ContainsKey(point)) return string.Empty;

        return grid[point].ToString();
    }

    public static int XmasHits(Grid grid, Point2D point)
    {
        var sum = 0;

        foreach (var checkPoint in Checks)
        {
            if (MatchGridCell(grid, point + checkPoint, 'M') &&
                MatchGridCell(grid, point + (checkPoint * 2), 'A') &&
                MatchGridCell(grid, point + (checkPoint * 3), 'S'))
            {
                sum++;
            }
        }

        return sum;
    }


    public string[] PartOne(string input)
    {
        var grid = LoadData(input);

        var sum = 0;

        foreach (var gridCell in grid)
        {
            if (gridCell.Value == 'X')
            {
                sum += XmasHits(grid, gridCell.Key);
            }
        }
        return [sum.ToString()];
    }

    public string[] PartTwo(string input)
    {
        var grid = LoadData(input);

        var sum = 0;

        foreach (var (point, value) in grid)
        {
            if (value == 'A')
            {
                var corners =
                    GetGridCell(grid, point + new Point2D(-1, -1)) +
                    GetGridCell(grid, point + new Point2D(1, -1)) +
                    GetGridCell(grid, point + new Point2D(1, 1)) +
                    GetGridCell(grid, point + new Point2D(-1, 1));

                if (corners == "MSSM" || corners == "MMSS" || corners == "SMMS" || corners == "SSMM")
                {
                    sum++;
                }
            }
        }
        return [sum.ToString()];
    }
}