using AdventOfCSharp.Puzzles.Geometery;
using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year22.Day14;


[PuzzleData(Year = 2022, Day = 14, Title = "Regolith Reservoir", Stars =2, HasHTML5Visualisation = true, ShowTheLove ="This was the first puzzle where I got the solution from the visualisation, before solving via the CLI.")]

public partial class Puzzle : IBasicPuzzle
{

    public enum CellContents
    {
        Air,
        Rock,
        Sand
    }

    public List<List<Point2D>> LoadData(string input)
    {
        var lines = input.ParseStringArray() ?? throw new ArgumentNullException(nameof(input));

        var paths = new List<List<Point2D>>();

        foreach (var line in lines)
        {
            paths.Add(line.Split(" -> ").Select(ParseSegment).ToList());
        }

        return paths;
    }

    public Point2D GetTopLeft(Dictionary<Point2D, CellContents> cells)
    {

        var x = int.MaxValue;
        var y = int.MaxValue;

        foreach (var cell in cells)
        {
            if (cell.Key.X < x) x = cell.Key.X;
            if (cell.Key.Y < y) y = cell.Key.Y;
        }

        return new Point2D(x, y);

    }

    public Point2D GetBottomRight(Dictionary<Point2D, CellContents> cells)
    {
        var x = 0;
        var y = 0;

        foreach (var cell in cells.Where(c => c.Value == CellContents.Rock))

        {
            if (cell.Key.X > x) x = cell.Key.X;
            if (cell.Key.Y > y) y = cell.Key.Y;
        }

        return new Point2D(x, y);
    }

    public Dictionary<Point2D, CellContents> CreateLayout(List<List<Point2D>> paths)
    {
        var caves = new Dictionary<Point2D, CellContents>();

        foreach (var path in paths)
        {
            for (var i = 1; i < path.Count; i++)
            {
                var start = path[i - 1];
                var end = path[i];

                var x = start.X;
                var y = start.Y;
                caves[new Point2D(x, y)] = CellContents.Rock;

                while (true)
                {
                    x += TravelIncrement(x, end.X);
                    y += TravelIncrement(y, end.Y);

                    caves[new Point2D(x, y)] = CellContents.Rock;

                    if (x == end.X && y == end.Y)
                    {
                        break;
                    }
                }
            }
        }

        return caves;
    }

    public Point2D DropSand(Dictionary<Point2D, CellContents> cells, Point2D start, Point2D br, bool hasFloor = false)
    {
        var position = start;

        while (true)
        {
            if (!hasFloor && position.Y > br.Y)

            {
                return new Point2D(0, 0);
            }


            if (hasFloor && position.Y == br.Y + 1) {
                return position;
            }


            var testDown = position.Add(new Point2D(0, 1));
            if (!cells.ContainsKey(testDown))
            {
                position = testDown;
                continue;
            }

            var testLeft = position.Add(new Point2D(-1, 1));
            if (!cells.ContainsKey(testLeft))
            {
                position = testLeft;
                continue;
            }

            var testRight = position.Add(new Point2D(1, 1));
            if (!cells.ContainsKey(testRight))
            {
                position = testRight;
                continue;
            }

            break;
        }

        return position;
    }

    private int TravelIncrement(int first, int second)
    {
        return first == second
            ? 0
            : first < second
                ? 1
                : -1;
    }

    private Point2D ParseSegment(string rawSegment)
    {
        var bits = rawSegment.Split(',');

        return new Point2D(int.Parse(bits[0]), int.Parse(bits[1]));
    }

    public string[] PartOne(string input)
    {
        return new string[] { Constants.NOT_YET_IMPLEMENTED };
    }

    public string[] PartTwo(string input)
    {
        return new string[] { Constants.NOT_YET_IMPLEMENTED };
    }
}