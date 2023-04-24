namespace AdventOfBlazor.Puzzles.Twenty16.Day11;

[PuzzleData(Year = 2016, Day = 11, Title = "Radioisotope Thermoelectric Generators", Stars = 0, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public static Facility LoadData(string input)
    {
        var lines = input.Split("\r\n");
        var floors = new List<Floor>();

        foreach (var line in lines)
        {
            var words = line.Split(' ');
            var devices = new List<Device>();

            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i]
                    .Replace(".", "")
                    .Replace(",", "")
                    .ToLower();

                var device = word switch
                {
                    "generator" => new Device(words[i - 1], DeviceType.Generator),
                    "microchip" => new Device(words[i - 1].Replace("-compatible", ""), DeviceType.Microchip),
                    _ => null
                };

                if (device != null)
                {
                    devices.Add(device);
                }
            }

            floors.Add(new Floor() { Devices = devices });
        }

        return new Facility() {
            Floors = floors
        };
    }


    public int MinimumSteps(Facility facility)
    {

        return 0;
    }

    public string[] PartOne(string input)
    {
        var fac = LoadData(input);
        return new string[] { Constants.NOT_YET_IMPLEMENTED };
    }

    public string[] PartTwo(string input)
    {
        return new string[] { Constants.NOT_YET_IMPLEMENTED };
    }
}