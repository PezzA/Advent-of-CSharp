namespace AdventOfCSharp.Puzzles
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class PuzzleDataAttribute : Attribute
    {
        public int Year { get; set; }
        public int Day { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Stars { get; set; }
        public bool ImplementedElsewhere { get; set; }
        public bool TakesAges { get; set; }
        public bool HasUnityVisualisation { get; set; }
        public bool HasHTML5Visualisation { get; set; }
        public string ShowTheLove { get; set; }
    }
}
