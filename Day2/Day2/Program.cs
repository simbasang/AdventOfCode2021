var input = File.ReadAllLines("./input.txt").ToList();
PartTwo(input);

static void PartOne(List<string> input)
{
    var horizontalPosition = input.Where(x => x.Contains("forward")).Select(x => int.Parse(x.Replace("forward ", ""))).Sum();
    var dept = input.Where(x => x.Contains("down")).Select(x => int.Parse(x.Replace("down ", ""))).Sum();
    var up = input.Where(x => x.Contains("up")).Select(x => int.Parse(x.Replace("up ", ""))).Sum();

    Console.WriteLine((dept - up) * horizontalPosition);
    Console.ReadLine();
}

static void PartTwo(List<string> input)
{
    var aim = 0;
    var horizontalPosition = 0;
    var dept = 0;
    foreach (var item in input)
    {
        if (item.Contains("forward"))
        {
            horizontalPosition += int.Parse(item.Replace("forward ", ""));
            dept += (aim * int.Parse(item.Replace("forward ", "")));
        }
        else if (item.Contains("down"))
            aim += int.Parse(item.Replace("down ", ""));
        else if (item.Contains("up"))
            aim -= int.Parse(item.Replace("up ", ""));

    }
    Console.WriteLine(dept * horizontalPosition);
    Console.ReadLine();
}

