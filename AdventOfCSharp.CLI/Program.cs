using AdventOfCSharp.Puzzles.Encryption;

if (args.Length < 2 ||
    !int.TryParse(args[0], out var inputYear) ||
    !int.TryParse(args[1], out var inputDay))
{
    Console.WriteLine("ERROR: Invalid arguments.");
    Console.WriteLine("Usage: <year> <day> <file>");
    Console.WriteLine("");
    Console.WriteLine("    Both year and day should be valid integers");
    Console.WriteLine("    file is optional and it the path to the file to use for input");
    return;
}

var data = AdventOfCSharp.Puzzles.PuzzleManager.GetPuzzleMetaData(inputYear, inputDay);
var puzzle = AdventOfCSharp.Puzzles.PuzzleManager.GetPuzzle(inputYear, inputDay);

if (puzzle == null || data == null)
{
    Console.WriteLine("Puzzle Not Found or implemented");
    return;
}

var encrypt = args.Any(a => a == "--encrypt");
var decrypt = args.Any(a => a == "--decrypt");
if (encrypt && decrypt) decrypt = false;
var key = Environment.GetEnvironmentVariable("ADVENT_OF_CODE_KEY");

if (encrypt)
{
    Console.WriteLine($"raw: ##{puzzle.PuzzleInput()}##");
    
    var encryptedData = Crypto.EncryptString(key, puzzle.PuzzleInput());
    Console.WriteLine($"encrypted: ##{encryptedData}##");
   
    var decryptedData = Crypto.DecryptString(key, encryptedData);
    Console.WriteLine($"decrypted: ##{decryptedData}##");
    
    return;
}

if (decrypt)
{
    var decryptedData = Crypto.DecryptString(key, puzzle.PuzzleInput());
    Console.WriteLine($"[{decryptedData}]");
    return;
}

var puzzleInput = puzzle.PuzzleInput();

if (args.Length > 2 && !string.IsNullOrEmpty(args[2]))
{
    try
    {
        puzzleInput = File.ReadAllText(args[2]);
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine($"Problem reading file: {ex.Message}");
        return;
    }
}

Console.WriteLine($"-- {data.Title} --");
Console.WriteLine($"Part one: {puzzle.PartOne(puzzleInput)[0]}");
Console.WriteLine($"Part Two: {puzzle.PartTwo(puzzleInput)[0]}");

