namespace AdventOfCSharp.Puzzles.Year16.Day11;

public class Facility
{
    public int ElevatorLevel { get; set; }

    public List<Floor> Floors { get; set; } = new List<Floor>();

    /// <summary>
    /// NOTE: Equals does not check for sequence equality, just the same items
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        if (obj is not Facility testFacility || !this.GetType().Equals(testFacility.GetType()))
            return false;

        if (ElevatorLevel != testFacility.ElevatorLevel)
            return false;

        foreach (var floor in Floors)
        {
            if (!testFacility.Floors.Contains(floor))
                return false;
        }

        return true;
    }
    public override int GetHashCode()
    {
        var hashCode = 0;

        hashCode += ElevatorLevel;

        foreach (var floor in Floors)
        {
            hashCode += floor.GetHashCode();

        }
        return hashCode;
    }
}