using System.ComponentModel.DataAnnotations;
using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year23.Day04;

[PuzzleData(Year = 2023, Day = 4, Title = "Scratchcards", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public record Card(int Id, int[] WinningNumbers, int[] CardNumbers)
    {
        public int Score()
        {
            var winCount = CardNumbers.Count(number => WinningNumbers.Contains(number));

            return winCount > 0 ? Doubler(winCount) : 0;
        }

        public int[] Wins() => CardNumbers.Where(number => WinningNumbers.Contains(number)).ToArray();
    }

    private static int Doubler(int iterations, int startValue = 1)
    {
        for (var i = 0; i < iterations - 1; i++)
        {
            startValue *= 2;
        }

        return startValue;
    }

    // As ever, LoadData dosen't concern itself about invalid data
    public static Card[] LoadData(string input)
    {
        var lines = input.ParseStringArray() ?? throw new Exception("could not parse input");

        var cardList = new List<Card>();

        foreach (var line in lines)
        {
            var parts = line.Split(':');
            var id = int.Parse(parts[0].Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries)[1].Trim());
            var lists = parts[1].Trim().Split('|');

            var winningNumbers = lists[0].Trim()
                .Split(' ')
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(int.Parse)
                .ToArray();

            var cardNumbers = lists[1].Trim()
                .Split(' ')
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(int.Parse)
                .ToArray();

            cardList.Add(new Card(id, winningNumbers, cardNumbers));
        }

        return cardList.ToArray();
    }

    public string[] PartOne(string input)
    {
        var cards = LoadData(input);

        var total = 0;
        foreach (var card in cards)
        {
            total += card.Score();
        }

        return new[] { total.ToString() };
    }

    private void Score(Card card, Dictionary<int, int> counts)
    {
        for(var i =1; i <= card.Wins().Length; i++)
        {
            counts[card.Id+i] += 1;
        }
    }

    public string[] PartTwo(string input)
    {
        var cards = LoadData(input);

        Dictionary<int, int> counts = new();
            
        foreach (var card in cards)
        {
            counts[card.Id] = 0;
        }
        
        foreach (var card in cards)
        {
            counts[card.Id] += 1;

            for (var i = 0; i < counts[card.Id]; i++)
            {
                Score(card, counts);
            }
        }

        var total = counts.Sum(x => x.Value);
        
        return new[] { total.ToString() };
    }
}