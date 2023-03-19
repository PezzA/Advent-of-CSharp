
namespace AdventOfBlazor.Puzzles.Twenty22
{
    [PuzzleData(Year = 2022, Day = 1, Title = "Calorie Counting", Stars = 1, ImplementedElsewhere = false)]

    public partial class Day1 : IBasicPuzzle
    {
        public string[] PartTwo(string input)
        {
            throw new NotImplementedException();
        }

        public string[] PartOne(string input)
        {
            var items = input.Split('\n');

            var count = 0;

            var maxCount = 0;

            foreach (var item in items)
            {
                if (item.Trim() == string.Empty)
                {

                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                    count = 0;
                    continue;
                }

                count += Convert.ToInt32(item);
            }

            return new string[] { maxCount.ToString() };
        }
    }
}