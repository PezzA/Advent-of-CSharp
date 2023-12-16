using AdventOfCSharp.Puzzles.Parsing;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AdventOfCSharp.Puzzles.Year22.Day13;

[PuzzleData(Year = 2022, Day = 13, Title = "Distress Signal", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public class Pair
    {
        public JArray? Left { get; set; }
        public JArray? Right { get; set; }
    }

    public enum OrderResult
    {
        Equal,
        InOrder,
        OutOfOrder,
    }

    public static List<Pair> LoadData(string input)
    {
        var lines = input.ParseStringArray() ?? throw new Exception("Invalid input data");
        var pairs = new List<Pair>();

        for (int i = 0; i < lines.Length; i++)
        {
            // assume first line has content
            pairs.Add(new Pair()
            {
                Left = JsonConvert.DeserializeObject<JArray>(lines[i]),
                Right = JsonConvert.DeserializeObject<JArray>(lines[i + 1]),
            });
            i += 2;
        }

        return pairs;
    }

    public static List<JArray?> FlattenPairs(List<Pair> pairs)
    {
        var flattenedList = new List<JArray?>();

        foreach (var pair in pairs)
        {
            if (pair.Left != null) flattenedList.Add(pair.Left);
            if (pair.Right != null) flattenedList.Add(pair.Right);
        }

        return flattenedList;
    }


    public static int GetIndex(JArray array)
    {

        for (int i = 0; i < array.Count; i++)
        {
            if (array[i] is JValue)
            {
                return array[i].Value<int>();
            }

            var result =  GetIndex((JArray)array[i]);

            if (result != -1) return result;
        }

        return -1;
    }


    public static OrderResult IsPairInOrder(JArray left, JArray right)
    {
        for (int i = 0; i < left.Count && i < right.Count; i++)
        {
            var result = OrderResult.Equal;
            if (left[i] is JValue && right[i] is JValue)
            {
                var leftInt = left[i].Value<int>();
                var rightInt = right[i].Value<int>();

                if (leftInt == rightInt) continue;

                return leftInt < rightInt
                      ? OrderResult.InOrder
                      : OrderResult.OutOfOrder;
            }

            if (left[i] is JArray && right[i] is JArray)
            {
                result = IsPairInOrder((JArray)left[i], (JArray)right[i]);
                if (result != 0) return result;
            }

            if (left[i] is JValue)
            {
                result = IsPairInOrder(new JArray { (JValue)left[i] } , (JArray)right[i]);
              
            } else if (right[i] is JValue)
            {
                result = IsPairInOrder((JArray)left[i], new JArray { (JValue)right[i] });
            }

      
            if (result != 0) return result;
        }

        if (left.Count == right.Count)
        {
            return OrderResult.Equal;
        }

        return left.Count < right.Count
            ? OrderResult.InOrder
            : OrderResult.OutOfOrder;
    }


    public static bool IsDecoder(JArray? array)
    {
        var arrayString = array?.ToString().Replace(Environment.NewLine, "").Replace(" ","");

        return arrayString == "[[2]]" || arrayString == "[[6]]";
    }
    private int CompareKeys(JArray? x, JArray? y)
    {
        return y != null && x != null && IsPairInOrder(x, y) == OrderResult.InOrder ? -1: 1;
    }


    public string[] PartOne(string input)
    {
        var total = 0;

        var pairs = LoadData(input);

        for (int i = 0; i < pairs.Count; i++)
        {
            if (pairs[i] == null || pairs[i].Left == null)
            {
                throw new Exception("null data");
            }

            var jArray = pairs[i].Left;
            var right = pairs[i].Right;
            if (right != null && jArray != null && IsPairInOrder(jArray, right) == OrderResult.InOrder)
            {
                total += i + 1;
            }
        }

        return new string[] { total.ToString() };
    }

    public string[] PartTwo(string input)
    {
        var list = FlattenPairs(LoadData(input));

        list.Add(JsonConvert.DeserializeObject<JArray>("[[2]]"));
        list.Add(JsonConvert.DeserializeObject<JArray>("[[6]]"));

        list.Sort(CompareKeys);

        var first = 0;
        var second = 0;
        for (var i = 0; i < list.Count(); i++)
        {
            if (IsDecoder(list[i]))
            {
                if (first == 0) {
                    first = i + 1;
                    continue;
                }

                second = i + 1;
                break;
            }
        }


        return new string[] { (first * second).ToString() };
    }


}