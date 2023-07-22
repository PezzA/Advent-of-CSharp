
namespace AdventOfCSharp.Puzzles.Year15.Day01;

[PuzzleData(Year = 2015, Day = 1, Title = "Not Quite Lisp", Stars = 2, HasVisualisation = true)]
public partial class Puzzle : IBasicPuzzle
{
    public static int GoClimbing(string input, bool finishAtBasement) { 
        var chars = input.ToCharArray();
        var floor = 0;

        for(int index = 0; index < chars.Length; index++)
        {
            floor = chars[index] switch
            {
                '(' => floor+=1,
                ')' => floor-=1,
                _ => throw new ArgumentException($"Input string contains unrecognised value: '{chars[index]}'")
            };

            if (floor == -1 && finishAtBasement) {
                return index + 1; // zero based index fix
            }
        }
        return floor;
    }

    public string[] PartOne(string input) => new string[] { GoClimbing(input, false).ToString() };
    
    public string[] PartTwo(string input) => new string[] { GoClimbing(input, true).ToString() };
}