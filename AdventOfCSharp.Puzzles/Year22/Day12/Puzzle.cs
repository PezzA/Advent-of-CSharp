using AdventOfCSharp.Puzzles.Geometery;

namespace AdventOfCSharp.Puzzles.Year22.Day12;

[PuzzleData(Year = 2022, Day = 12, Title = "Hill Climbing Algorithm", Stars = 2, HasHtml5Visualisation = true, ShowTheLove ="My first HTML5 visualisation using blazor!")]
public partial class Puzzle : IBasicPuzzle
{
    public static Point2D GetStart(Dictionary<Point2D, char> points)
    {
        foreach (var point in points)
        {
            if (point.Value == 'S')
            {
                return point.Key;
            }
        }
        throw new InvalidDataException("No Start Found");
    }

    public static Point2D GetEnd(Dictionary<Point2D, char> points)
    {
        foreach (var point in points)
        {
            if (point.Value == 'E')
            {
                return point.Key;
            }
        }
        throw new InvalidDataException("No End Found");
    }

    public static Dictionary<Point2D, char> LoadData(string input)
    {
        var lines = input
            .Split(Environment.NewLine)
            .Select(l => l.Replace("\r", "").Trim())
            .ToArray();

        var map = new Dictionary<Point2D, char>();

        for (int y = 0; y < lines.Length; y++)
        {
            for (int x = 0; x < lines[y].Length; x++)
            {
                map.Add(new Point2D(x, y), lines[y][x]);
            }
        }

        return map;
    }

    public static char GetElevation(char c)
    {
        if (c == 'S') return 'a';
        if (c == 'E') return 'z';
        return c;
    }

    public static void RunQueue(Dictionary<Point2D, char> map, Dictionary<Point2D, int> distances, Queue<Point2D> queue) {
        // get the next item we are looking at
        var nextPoint = queue.Dequeue();

        // get it's current value
        var currentDistance = distances[nextPoint];
        var currentHeight = GetElevation(map[nextPoint]);

        foreach (var ordinalPoint in OrdinalExtensions.OrdinalPoints)
        {
            var testPoint = nextPoint.Add(ordinalPoint);

            //ignore off map or start
            if (!map.ContainsKey(testPoint) || map[testPoint] == 'S')
            {
                continue;
            }

            var mapHeight = GetElevation(map[testPoint]);

            if (!distances.ContainsKey(testPoint))
            {
                distances[testPoint] = int.MaxValue;
            }

            var mapDistance = distances[testPoint];
            // ignore if too high (cannot be too low)
            if (mapHeight - currentHeight > 1)
            {
                continue;
            }

            if ((currentDistance + 1) < mapDistance)
            {
                distances[testPoint] = currentDistance + 1;
                queue.Enqueue(testPoint);
            }
        }
    }

    public static Dictionary<Point2D, int> WalkMap(Dictionary<Point2D, char> map, Point2D start)
    {
        var queue = new Queue<Point2D>();
        queue.Enqueue(start);
        var distances = new Dictionary<Point2D, int>();
        distances[start] = 0;

        while (queue.Count > 0)
        {
            RunQueue(map, distances, queue);
        }

        return distances;
    }

    public string[] PartOne(string input)
    {
        var map = LoadData(input);
        var start = GetStart(map);
        var end = GetEnd(map);
        var distances = WalkMap(map, start);
        var shortestDistance = distances[end];
        return new string[] { shortestDistance.ToString() };
    }

    public string[] PartTwo(string input)
    {
        var map = LoadData(input);
        var end = GetEnd(map);

        var min = int.MaxValue;

        foreach (var entry in map)
        {
            if (GetElevation(entry.Value) != 'a')
            {
                continue;
            }

            var distances = WalkMap(map, entry.Key);

            // not every starting point can make it.
            if (!distances.ContainsKey(end))
            {
                continue;
            }

            var shortestDistance = distances[end];

            if (shortestDistance < min)
            {
                min = shortestDistance;
            }
        }

        return new string[] { min.ToString() };
    }
}