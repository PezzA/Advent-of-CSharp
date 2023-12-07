using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year23.Day07;

[PuzzleData(Year = 2023, Day = 7, Title = "Camel Cards", Stars = 1, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public enum HandType
    {
        Nothing,
        OnePair,
        TwoPair,
        ThreeKind,
        FullHouse,
        FourKind,
        FiveKind
    }

    public record Hand(string Cards, int Bid)
    {
        public HandType GetHandType()
        {
            if (Cards.Length != 5)
            {
                throw new InvalidDataException("Invalid Hand Size");
            }

            var charDict = new Dictionary<char, int>();

            foreach (var handChar in Cards)
            {
                charDict.TryAdd(handChar, 0);
                charDict[handChar] += 1;
            }

            switch (charDict.Count)
            {
                case 5:
                    return HandType.Nothing;
                case 4:
                    return HandType.OnePair;
                case 1:
                    return HandType.FiveKind;
                case 2:
                {
                    var firstCard = charDict.First();

                    switch (firstCard.Value)
                    {
                        case 1 or 4:
                            return HandType.FourKind;
                        case 2 or 3:
                            return HandType.FullHouse;
                    }

                    break;
                }
                case 3:
                {
                    return charDict.Any(e => e.Value == 3)
                        ? HandType.ThreeKind
                        : HandType.TwoPair;
                }
            }

            throw new Exception("Could not determine hand type");
        }
    }

    public class PartOneHandSorter : IComparer<Hand>
    {
        private static int GetCardValue(char card) => card switch
        {
            '2' => 1,
            '3' => 2,
            '4' => 3,
            '5' => 4,
            '6' => 5,
            '7' => 6,
            '8' => 7,
            '9' => 8,
            'T' => 9,
            'J' => 10,
            'Q' => 11,
            'K' => 12,
            'A' => 13,
            _ => throw new Exception("Invalid Card Value")
        };

        public int Compare(Hand? x, Hand? y)
        {
            if (x == null && y == null) return 0;
            if (x == null && y != null) return -1;
            if (x != null && y == null) return 1;

            if (string.IsNullOrEmpty(x.Cards) && string.IsNullOrEmpty(y.Cards)) return 0;

            if (x.Cards.Length != 5 || y.Cards.Length != 5)
            {
                throw new ArgumentException("comparing a hand size that is not of length 5");
            }

            if (x.Cards == y.Cards) return 0;

            for (int i = 0; i < x.Cards.Length; i++)
            {
                if (x.Cards[i] == y.Cards[i]) continue;

                return GetCardValue(x.Cards[i]) > GetCardValue(y.Cards[i])
                    ? 1
                    : -1;
            }

            return 0;
        }
    }

    public class PartTwoHandSorter : IComparer<Hand>
    {
        private static int GetCardValue(char card) => card switch
        {
            'J' => 1,
            '2' => 2,
            '3' => 3,
            '4' => 4,
            '5' => 5,
            '6' => 6,
            '7' => 7,
            '8' => 8,
            '9' => 9,
            'T' => 10,
            'Q' => 11,
            'K' => 12,
            'A' => 13,
            _ => throw new Exception("Invalid Card Value")
        };

        public int Compare(Hand? x, Hand? y)
        {
            if (x == null && y == null) return 0;
            if (x == null && y != null) return -1;
            if (x != null && y == null) return 1;

            if (string.IsNullOrEmpty(x.Cards) && string.IsNullOrEmpty(y.Cards)) return 0;

            if (x.Cards.Length != 5 || y.Cards.Length != 5)
            {
                throw new ArgumentException("comparing a hand size that is not of length 5");
            }

            if (x.Cards == y.Cards) return 0;

            for (int i = 0; i < x.Cards.Length; i++)
            {
                if (x.Cards[i] == y.Cards[i]) continue;

                return GetCardValue(x.Cards[i]) > GetCardValue(y.Cards[i])
                    ? 1
                    : -1;
            }

            return 0;
        }
    }

    public static Hand[] LoadData(string input)
    {
        var lines = input.ParseStringArray() ?? throw new Exception("cannot parse input");

        var hands = new List<Hand>();

        foreach (var line in lines)
        {
            var bits = line.Split(' ');

            hands.Add(new Hand(bits[0], int.Parse(bits[1])));
        }

        return hands.ToArray();
    }


    public string[] PartOne(string input)
    {
        var hands = LoadData(input);

        var sortedHands = hands
            .OrderBy(x => x.GetHandType())
            .ThenBy(x => x, new PartOneHandSorter())
            .ToList();

        var total = 0;

        foreach (var (value, i) in sortedHands.Select((value, i) => (value, i)))
        {
            total += (i + 1) * value.Bid;
        }

        return new[] { total.ToString() };
    }

    public string[] PartTwo(string input)
    {
        return new[] { Constants.NOT_YET_IMPLEMENTED };
    }
}