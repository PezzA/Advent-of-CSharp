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

        public static PuzzleDataAttribute? GetPuzzleMetaData(int year, int day)
        {
            var puzzleDataList = new List<PuzzleDataAttribute>();

            foreach (Type mytype in Assembly.GetExecutingAssembly().GetTypes()
                    .Where(mytype => mytype.GetInterfaces().Contains(typeof(IBasicPuzzle))))
            {
                if (Attribute.GetCustomAttribute(mytype, typeof(PuzzleDataAttribute)) is PuzzleDataAttribute dataAttribute)
                {
                    if (dataAttribute.Year == year && dataAttribute.Day == day)
                    {
                        return dataAttribute;
                    }
                }
            }

            return null;
        }

        public static IBasicPuzzle? GetPuzzle(int year, int day)
        {
            var puzzleDataList = new List<PuzzleDataAttribute>();

            foreach (Type mytype in Assembly.GetExecutingAssembly().GetTypes()
                    .Where(mytype => mytype.GetInterfaces().Contains(typeof(IBasicPuzzle))))
            {
                if (Attribute.GetCustomAttribute(mytype, typeof(PuzzleDataAttribute)) is PuzzleDataAttribute dataAttribute)
                {
                    if (dataAttribute.Year == year && dataAttribute.Day == day)
                    {
                        return Activator.CreateInstance(mytype) as IBasicPuzzle;
                    }
                }
            }

            return null;
        }
    }
}
