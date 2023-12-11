using AdventOfCSharp.Puzzles.Geometery;
using static AdventOfCSharp.Puzzles.Geometery.OrdinalExtensions;
using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year23.Day10;

[PuzzleData(Year = 2023, Day = 10, Title = "Pipe Maze", Stars = 0, ImplementedElsewhere = false, HasHTML5Visualisation = true, ShowTheLove = "My first visualisation of 2023!  Also, my first use of a sprite sheet.")]
public partial class Puzzle : IBasicPuzzle
{
    private static readonly Dictionary<char, Ordinal[]> Pipes = new Dictionary<char, Ordinal[]>()
    {
        { '|', new[] { Ordinal.North, Ordinal.South } },
        { '-', new[] { Ordinal.East, Ordinal.West } },
        { 'L', new[] { Ordinal.North, Ordinal.East } },
        { 'J', new[] { Ordinal.North, Ordinal.West } },
        { 'F', new[] { Ordinal.South, Ordinal.East } },
        { '7', new[] { Ordinal.South, Ordinal.West } },
    };

    public static char[][] LoadData(string input)
    {
        var lines = input.ParseStringArray() ?? throw new Exception("could not parse input");
        return lines.Select(s => s.ToCharArray()).ToArray();
    }

    public static char? GetCell(Point2D position, char[][] grid) =>
        position.X < 0 || position.Y < 0 || position.Y >= grid.Length || position.X >= grid[position.Y].Length
            ? null
            : grid[position.Y][position.X];

    public static Point2D GetStart(char[][] input)
    {
        for (var y = 0; y < input.Length; y++)
        {
            for (var x = 0; x < input[y].Length; x++)
            {
                if (input[y][x] == 'S')
                {
                    return new Point2D(x, y);
                }
            }
        }

        throw new Exception("could not find start point");
    }

    public static bool IsConnected(Point2D point, char[][] grid)
    {
        if (grid[point.Y][point.X] == '|')
        {
            if (GetCell(point.TermNorth(), grid) is '-' or 'J' or 'L' or null ||
                GetCell(point.TermSouth(), grid) is '-' or '7' or 'F' or null)
            {
                return false;
            }
        }

        if (grid[point.Y][point.X] == '-')
        {
            if (GetCell(point.TermEast(), grid) is '|' or 'F' or 'L' or null ||
                GetCell(point.TermWest(), grid) is '|' or '7' or 'J' or null)
            {
                return false;
            }
        }

        return true;
    }

    public static char? DetermineType(Point2D start, char[][] grid)
    {
        var north = GetCell(start.Add(OrdinalDirection[Ordinal.North]), grid);
        var connectedNorth = north is '|' or 'F' or '7';

        var south = GetCell(start.Add(OrdinalDirection[Ordinal.South]), grid);
        var connectedSouth = south is '|' or 'L' or 'J';

        var east = GetCell(start.Add(OrdinalDirection[Ordinal.East]), grid);
        var connectedEast = east is '-' or 'J' or '7';

        var west = GetCell(start.Add(OrdinalDirection[Ordinal.West]), grid);
        var connectedWest = west is '-' or 'L' or 'F';

        if (connectedNorth && connectedSouth) return '|';
        if (connectedEast && connectedWest) return '-';
        if (connectedNorth && connectedWest) return 'J';
        if (connectedNorth && connectedEast) return 'L';
        if (connectedSouth && connectedEast) return 'F';
        if (connectedSouth && connectedWest) return '7';

        return null;
    }

    public Dictionary<Point2D, int> Points = new();
    public Queue<Point2D> Queue = new();

    public bool NextLoop(char[][] grid)
    {
        var currentPos = Queue.Dequeue();

        foreach (var dir in Pipes[grid[currentPos.Y][currentPos.X]])
        {
            var nextPos = currentPos.Add(OrdinalDirection[dir]);

            if (Points.ContainsKey(nextPos)) continue;

            Queue.Enqueue(nextPos);
            Points[nextPos] = Points[currentPos] + 1;
        }

        return Queue.Count == 0;
    }

    public void Init(char[][] grid)
    {
        var start = GetStart(grid);
        var type = DetermineType(start, grid) ?? throw new Exception("could not determine start type");

        Points = new Dictionary<Point2D, int>
        {
            [start] = 0
        };

        Queue = new Queue<Point2D>();
        foreach (var dir in Pipes[type])
        {
            var nextPos = start.Add(OrdinalDirection[dir]);

            Queue.Enqueue(nextPos);
            Points[nextPos] = 1;
        }
    }

    public string[] PartOne(string input)
    {
        var grid = LoadData(input);
        Init(grid);

        while (!NextLoop(grid))
        {
            //not much to do here really.
        }

        return new[] { Points.Max(p => p.Value).ToString() };
    }

    public string[] PartTwo(string input)
    {
        return new[] { Constants.NOT_YET_IMPLEMENTED };
    }
}