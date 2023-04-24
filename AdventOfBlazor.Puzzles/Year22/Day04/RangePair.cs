namespace AdventOfBlazor.Puzzles.Year22.Day04;

public class RangePair
{
    public Range? First { get; set; }
    public Range? Second { get; set; }

    public bool WhollyOverLapped()
    {
        if (First == null || Second == null) return false;

        if (First.Lower <= Second.Lower && First.Upper >= Second.Upper ||
            Second.Lower <= First.Lower && Second.Upper >= First.Upper)
        {

            return true;
        }

        return false;
    }

    public bool PartiallyOverLapped()
    {
        if (First == null || Second == null) return false;

        if (First.Lower <= Second.Lower && First.Upper >= Second.Lower ||
            Second.Lower <= First.Lower && Second.Upper >= First.Lower)
        {
            return true;
        }

        return false;
    }
}
