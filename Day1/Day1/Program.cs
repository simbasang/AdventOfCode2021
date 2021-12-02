var input = File.ReadAllLines("./input.txt").Select(x => int.Parse(x)).ToList();

Part2(input);


static void part1(IEnumerable<int> input)
{

    var beforNr = input.First();
    var counter = 0;

    foreach (var item in input)
    {
        if (item > beforNr)
            counter++;

        beforNr = item;
    }

    Console.WriteLine(counter);
    Console.ReadLine();

}

static void Part2(List<int> input)
{
    var counter = 0;

    for (int i = 0; i + 2 < input.Count; i++)
    {

        if (input.GetRange(i, 3).Sum() > input.GetRange(i == 0 ? i : i - 1, 3).Sum())
            counter++;

    }

    Console.WriteLine(counter);
    Console.ReadLine();

}
