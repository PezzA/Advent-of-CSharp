namespace AdventOfBlazor.Puzzles.Year16.Day11;

public class Floor
{
    public List<Device> Devices { get; set; } = new List<Device>();

    // non sequence dependent hash
    public override int GetHashCode()
    {
        var hashCode = 0;

        if (!Devices.Any())
        {
            return 0;
        }
        foreach (var device in Devices)
        {
            hashCode += device.GetHashCode();
        }

        return hashCode;
    }

    /// <summary>
    /// NOTE: Equals does not check for sequence equality, just the same items
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        if (obj is not Floor testFloor || !this.GetType().Equals(testFloor.GetType()))
            return false;


        if (Devices.Count != testFloor.Devices.Count)
            return false;

        foreach (var device in Devices)
        {
            if (!testFloor.Devices.Contains(device))
                return false;
        }

        return true;
    }
}