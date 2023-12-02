using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year23.Day02;

[PuzzleData(Year = 2023, Day = 02, Title = "Cube Conundrum", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public record Draw(int Blue, int Red, int Green)
    {
        public int Power() => Blue * Red * Green;
    }

    public record Game(int Id, Draw[] Draws)
    {
        public bool IsPossible(int maxRed, int maxGreen, int maxBlue) =>
            Draws.All(draw => draw.Red <= maxRed && draw.Green <= maxGreen && draw.Blue <= maxBlue);

        public Draw MinDraw() => 
            new (Draws.Max(d => d.Blue), Draws.Max(d => d.Red), Draws.Max(d => d.Green));        
    }

    // As ever, parsing the puzzle input assumes valid input.
    public static Game[] LoadData(string input)
    {
        var lines = input.ParseStringArray() ?? throw new Exception("Could not parse string data");

        var games = new List<Game>();

        foreach (var line in lines)
        {
            var bits = line.Split(':');
            var id = int.Parse(bits[0].Split(' ')[1]);

            var draws = bits[1]
                .Split(';')
                .Select(StringToDraw)
                .ToArray();

            games.Add(new Game(id, draws));
        }

        return games.ToArray();
    }

    private static Draw StringToDraw(string input)
    {
        var bits = input.Split(',');
        int blue = 0, red = 0, green = 0;

        foreach (var bit in bits)
        {
            var parts = bit.Trim().Split(' ');

            switch (parts[1])
            {
                case "blue":
                    blue = int.Parse(parts[0]);
                    break;
                case "green":
                    green = int.Parse(parts[0]);
                    break;
                case "red":
                    red = int.Parse(parts[0]);
                    break;
                default:
                    throw new Exception("unknown colour in draw");
            }
        }

        return new Draw(blue, red, green);
    }

    public string[] PartOne(string input)
    {
        var games = LoadData(input);

        return new[] { games.Sum(game => game.IsPossible(12,13,14) ? game.Id : 0).ToString()};
    }

    public string[] PartTwo(string input)
    {
        var games = LoadData(input);

        return new[] { games.Sum(game => game.MinDraw().Power()).ToString()};
    }
}