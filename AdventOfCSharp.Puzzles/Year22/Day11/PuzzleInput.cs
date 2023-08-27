﻿namespace AdventOfCSharp.Puzzles.Year22.Day11;

public partial class Puzzle
{
    public string TestData => """
        Monkey 0:
          Starting items: 79, 98
          Operation: new = old * 19
          Test: divisible by 23
            If true: throw to monkey 2
            If false: throw to monkey 3

        Monkey 1:
          Starting items: 54, 65, 75, 74
          Operation: new = old + 6
          Test: divisible by 19
            If true: throw to monkey 2
            If false: throw to monkey 0

        Monkey 2:
          Starting items: 79, 60, 97
          Operation: new = old * old
          Test: divisible by 13
            If true: throw to monkey 1
            If false: throw to monkey 3

        Monkey 3:
          Starting items: 74
          Operation: new = old + 3
          Test: divisible by 17
            If true: throw to monkey 0
            If false: throw to monkey 1
        """;


    public string PuzzleInput()
    {
        return """
            Monkey 0:
              Starting items: 62, 92, 50, 63, 62, 93, 73, 50
              Operation: new = old * 7
              Test: divisible by 2
                If true: throw to monkey 7
                If false: throw to monkey 1

            Monkey 1:
              Starting items: 51, 97, 74, 84, 99
              Operation: new = old + 3
              Test: divisible by 7
                If true: throw to monkey 2
                If false: throw to monkey 4

            Monkey 2:
              Starting items: 98, 86, 62, 76, 51, 81, 95
              Operation: new = old + 4
              Test: divisible by 13
                If true: throw to monkey 5
                If false: throw to monkey 4

            Monkey 3:
              Starting items: 53, 95, 50, 85, 83, 72
              Operation: new = old + 5
              Test: divisible by 19
                If true: throw to monkey 6
                If false: throw to monkey 0

            Monkey 4:
              Starting items: 59, 60, 63, 71
              Operation: new = old * 5
              Test: divisible by 11
                If true: throw to monkey 5
                If false: throw to monkey 3

            Monkey 5:
              Starting items: 92, 65
              Operation: new = old * old
              Test: divisible by 5
                If true: throw to monkey 6
                If false: throw to monkey 3

            Monkey 6:
              Starting items: 78
              Operation: new = old + 8
              Test: divisible by 3
                If true: throw to monkey 0
                If false: throw to monkey 7

            Monkey 7:
              Starting items: 84, 93, 54
              Operation: new = old + 1
              Test: divisible by 17
                If true: throw to monkey 2
                If false: throw to monkey 1
            """;
    }
}
