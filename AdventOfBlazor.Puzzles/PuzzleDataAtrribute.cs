namespace AdventOfBlazor.Puzzles
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class PuzzleDataAttribute : Attribute
    {
        public int Year { get; set; }
        public int Day { get; set; }
        public string Title { get; set; } = string.Empty;
        public PuzzleStatus Status { get; set; } = PuzzleStatus.NotYetImplemented;
        public bool TakesAges { get; set; }
    }
}
