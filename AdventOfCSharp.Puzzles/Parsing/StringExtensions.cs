namespace AdventOfCSharp.Puzzles.Parsing
{
    public static class StringExtensions
    {
        public static string[]? ParseStringArray(this string input)
        {
            if (string.IsNullOrEmpty(input)) return null;

            return input
                .Split(Environment.NewLine)
                .Select(l => l.Replace("\r", "").Trim())
                .ToArray();
        }
    }
}
