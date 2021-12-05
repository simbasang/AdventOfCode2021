var input = File.ReadAllText("./input.txt");
PartOne(input);

static void PartOne(string input)
{
    var bingoRow = input.Split("\n")[0].Split(',').Select(x => int.Parse(x));
    var boards = input.Replace(input.Split("\n")[0], "").TrimStart().Split("\r\n");


    foreach (var item in bingoRow)
    {


    }
}
