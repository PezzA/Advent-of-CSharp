using AdventOfCSharp.Puzzles.Geometery;
using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year24.Day06;

[PuzzleData(Year = 2024, Day = 6, Title = "Guard Gallivant", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public enum CellType
    {
        Space,
        Tank
    }

    public static (Point2D start, Dictionary<Point2D, CellType> grid) LoadData(string input)
    {
        var start = Point2D.Origin;
        var lines = input.ParseStringArray() ?? throw new Exception("Could not parse input");
        var grid = new Dictionary<Point2D, CellType>();

        for (int y = 0; y < lines.Length; y++)
        {
            for (int x = 0; x < lines[y].Length; x++)
            {
                switch (lines[y][x])
                {
                    case '.':
                        grid[new Point2D(x, y)] = CellType.Space;
                        break;
                    case '#':
                        grid[new Point2D(x, y)] = CellType.Tank;
                        break;
                    case '^':
                        grid[new Point2D(x, y)] = CellType.Space;
                        start = new Point2D(x, y);
                        break;
                    default:
                        throw new ArgumentException("Did not recognise cell type");
                }
            }
        }

        return (start, grid);
    }

    public (bool detectedLoop, Dictionary<Point2D, int>) Walk(Point2D start, Dictionary<Point2D, CellType> grid)
    {
        var position = start;
        var bearing = Point2D.BearingNorth;

        var visits = new Dictionary<Point2D, int>();

        visits[start] = 1;

        var rightTurns = new List<(Point2D, Point2D)>();

        while (grid.ContainsKey(position + bearing))
        {
            if (grid[position + bearing] == CellType.Tank)
            {
                if (rightTurns.Contains((position, bearing)))
                {
                    return (true, visits);
                }
                rightTurns.Add((position, bearing));

                bearing = Point2D.TurnRight(bearing);
                continue;
            }

            position += bearing;

            if (visits.ContainsKey(position))
            {
                visits[position]++;
            }
            else
            {
                visits[position] = 1;
            }

        }

        return (false, visits);
    }


    public Dictionary<Point2D, CellType> DeepCopy(Dictionary<Point2D, CellType> map)
    {
        var newMap = new Dictionary<Point2D, CellType>();

        foreach (var (k, v) in map)
        {
            newMap[k] = v;
        }

        return newMap;
    }


    public static (Point2D topLeft, Point2D bottomRight) GetBounds(Dictionary<Point2D, CellType> map)
    {
        var topLeft = Point2D.Origin;
        var bottomRight = Point2D.Origin;

        foreach (var (k, v) in map)
        {
            if (v == CellType.Tank)
            {
                if (k.X < topLeft.X)
                {
                    topLeft = topLeft with { X = k.X };
                }

                if (k.X > bottomRight.X)
                {
                    bottomRight = bottomRight with { X = k.X };
                }

                if (k.Y < topLeft.Y)
                {
                    topLeft = topLeft with { Y = k.Y };
                }

                if (k.Y > bottomRight.Y)
                {
                    bottomRight = bottomRight with { Y = k.Y };
                }
            }
        }

        return (topLeft, bottomRight);
    }

    public string[] PartOne(string input)
    {
        var (start, grid) = LoadData(input);

        var (_, visits) = Walk(start, grid);

        return [visits.Count.ToString()];
    }

    public string[] PartTwo(string input)
    {
        var (start, grid) = LoadData(input);

        var (_, visits) = Walk(start, grid);

        var (topLeft, bottomRight) = GetBounds(grid);

        var sum = 0;
        for (int x = topLeft.X; x <= bottomRight.X; x++)
        {
            for (int y = topLeft.Y; y <= bottomRight.Y; y++)
            {
                var pos = new Point2D(x, y);
                if (grid[pos] == CellType.Tank || pos == start)
                {
                    continue;
                }

                var newGrid = DeepCopy(grid);

                newGrid[pos] = CellType.Tank;

                var (looped, _) = Walk(start, newGrid);

                if (looped)
                {
                    sum++;
                }
            }
        }

        return [sum.ToString()];
    }
}