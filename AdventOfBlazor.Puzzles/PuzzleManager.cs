using System.Reflection;

namespace AdventOfBlazor.Puzzles
{
    public class PuzzleManager
    {
        public static IEnumerable<PuzzleDataAttribute> GetAllBasicPuzzles()
        {
            var puzzleDataList = new List<PuzzleDataAttribute>();

            foreach (Type mytype in Assembly.GetExecutingAssembly().GetTypes()
                    .Where(mytype => mytype.GetInterfaces().Contains(typeof(IBasicPuzzle))))
            {
                if (Attribute.GetCustomAttribute(mytype, typeof(PuzzleDataAttribute)) is PuzzleDataAttribute dataAttribute)
                {
                    puzzleDataList.Add(dataAttribute);
                }
            }

            return puzzleDataList;
        }
    }
}
