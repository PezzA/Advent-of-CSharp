using AdventOfBlazor.Puzzles.Geometery;

namespace AdventOfBlazor.Puzzles.Year22.Day08;

[PuzzleData(Year = 2022, Day = 8, Title = "Treetop Tree House", Stars = 2)]
public partial class Puzzle : IBasicPuzzle
{
    public static int[,] LoadData(string input)
    {
        var lines = input
            .Split(Environment.NewLine)
            .Select(l => l.Replace("\r", "").Trim())
            .ToArray();

        var grid = new int[lines[0].Length, lines.Length];

        for (int x = 0; x < lines[0].Length; x++)
        {
            for (int y = 0; y < lines.Length; y++)
            {
                grid[x, y] = Convert.ToInt32(lines[y][x].ToString());
            }
        }

        return grid;
    }

    public static bool IsTreeVisible(Point2D point, int[,] grid)
    {
        var (visibleFromNorth, _) = CanViewFromNorth(point, grid);
        if (visibleFromNorth) return true;

        var (visibleFromEast, _) = CanViewFromEast(point, grid);
        if (visibleFromEast) return true;

        var (visibleFromSouth, _) = CanViewFromSouth(point, grid);
        if (visibleFromSouth) return true;

        var (visibleFromWest, _) = CanViewFromWest(point, grid);
        if (visibleFromWest) return true;

        return false;
    }

    public static int TreesVisible(Point2D point, int[,] grid)
    {
        var (_, visibleFromNorth) = CanViewFromNorth(point, grid);
        var (_, visibleFromEast) = CanViewFromEast(point, grid);
        var (_, visibleFromSouth) = CanViewFromSouth(point, grid);
        var (_, visibleFromWest) = CanViewFromWest(point, grid);

        return visibleFromNorth * visibleFromSouth * visibleFromEast * visibleFromWest;
    }

    public static (bool CanSeeExternally, int visibleCount) CanViewFromEast(Point2D point, int[,] grid)
    {
        var height = grid[point.X, point.Y];
        var visCount = 0;
        for (var x = point.X - 1; x >= 0; x--)
        {
            visCount++;
            if (grid[x, point.Y] >= height)
            {
                return (false, visCount);
            }
        }
        return (true, visCount);
    }

    public static (bool CanSeeExternally, int visibleCount) CanViewFromWest(Point2D point, int[,] grid)
    {
        var height = grid[point.X, point.Y];
        var visCount = 0;
        for (var x = point.X + 1; x < grid.GetLength(0); x++)
        {
            visCount++;
            if (grid[x, point.Y] >= height)
            {
                return (false, visCount);
            }
        }
        return (true, visCount);
    }

    public static (bool CanSeeExternally, int visibleCount) CanViewFromNorth(Point2D point, int[,] grid)
    {
        var height = grid[point.X, point.Y];
        var visCount = 0;
        for (var y = point.Y - 1; y >= 0; y--)
        {
            visCount++;
            if (grid[point.X, y] >= height)
            {
                return (false, visCount);
            }
        }
        return (true, visCount);
    }

    public static (bool CanSeeExternally, int visibleCount) CanViewFromSouth(Point2D point, int[,] grid)
    {
        var height = grid[point.X, point.Y];
        var visCount = 0;
        for (var y = point.Y + 1; y < grid.GetLength(1); y++)
        {
            visCount++;
            if (grid[point.X, y] >= height)
            {
                return (false, visCount);
            }
        }
        return (true, visCount);
    }

    public static int CountVisibleTrees(int[,] grid)
    {
        var count = 0;

        for (int x = 0; x < grid.GetLength(0); x++)
        {
            for (int y = 0; y < grid.GetLength(1); y++)
            {
                if (IsTreeVisible(new Point2D(x, y), grid))
                {
                    count++;
                }
            }
        }

        return count;
    }

    public static int GetHighestScenicScore(int[,] grid)
    {
        var highest = 0;

        for (int x = 0; x < grid.GetLength(0); x++)
        {
            for (int y = 0; y < grid.GetLength(1); y++)
            {
                var scenicScore = TreesVisible(new Point2D(x, y), grid);

                if (scenicScore > highest) {
                    highest = scenicScore;
                }
            }
        }

        return highest;
    }

    public string[] PartOne(string input) => new string[] { CountVisibleTrees(LoadData(input)).ToString() };

    public string[] PartTwo(string input) => new string[] { GetHighestScenicScore(LoadData(input)).ToString() };
}