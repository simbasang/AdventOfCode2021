var input = File.ReadAllLines("./input.txt").ToList();
PartTwo(input);


static void PartOne(List<string> input)
{
    var gammaRate = "";
    var epsilonRate = "";

    for (int i = 0; i < input.First().Count(); i++)
    {
        if ((input.Count() / 2) > input.Where(x => x[i] == '1').Count())
        {
            gammaRate += "0";
            epsilonRate += "1";
        }
        else
        {
            gammaRate += "1";
            epsilonRate += "0";
        }
    }
    Console.WriteLine(Convert.ToInt32(gammaRate, 2) * Convert.ToInt32(epsilonRate, 2));
    Console.ReadLine();
}

static void PartTwo(List<string> input)
{
    var CO2ScrubberRating = input;
    var oxygenGeneratorRating = input;

    for (int i = 0; i < input.First().Count(); i++)
    {
        if ((oxygenGeneratorRating.Count() / 2) >= oxygenGeneratorRating.Where(x => x[i] == '0').Count() && oxygenGeneratorRating.Count > 1)
            oxygenGeneratorRating = oxygenGeneratorRating.Where(x => x[i] == '1').ToList();
        else if (oxygenGeneratorRating.Count > 1)
            oxygenGeneratorRating = oxygenGeneratorRating.Where(x => x[i] == '0').ToList();

        if ((CO2ScrubberRating.Count() / 2) >= CO2ScrubberRating.Where(x => x[i] == '0').Count() && CO2ScrubberRating.Count > 1)
            CO2ScrubberRating = CO2ScrubberRating.Where(x => x[i] == '0').ToList();
        else if (CO2ScrubberRating.Count > 1)
            CO2ScrubberRating = CO2ScrubberRating.Where(x => x[i] == '1').ToList();


        if (CO2ScrubberRating.Count == 1 && oxygenGeneratorRating.Count == 1)
            break;
    }

    Console.WriteLine(Convert.ToInt32(CO2ScrubberRating.First(), 2) * Convert.ToInt32(oxygenGeneratorRating.First(), 2));
    Console.ReadLine();
}
