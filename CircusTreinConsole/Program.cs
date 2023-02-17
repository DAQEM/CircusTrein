using CircusTreinLib;
using CircusTreinLib.Algorithms;
using CircusTreinLib.Animals;

while (true)
{
    Console.WriteLine("\nHow big carnivores?");
    int bigCarnivoreAmount = GetNumberFromConsole();
    
    Console.WriteLine("\nHow medium carnivores?");
    int mediumCarnivoreAmount = GetNumberFromConsole();
    
    Console.WriteLine("\nHow small carnivores?");
    int smallCarnivoreAmount = GetNumberFromConsole();
    
    Console.WriteLine("\nHow big herbivores?");
    int bigHerbivoreAmount = GetNumberFromConsole();
    
    Console.WriteLine("\nHow medium herbivores?");
    int mediumHerbivoreAmount = GetNumberFromConsole();
    
    Console.WriteLine("\nHow small herbivores?");
    int smallHerbivoreAmount = GetNumberFromConsole();

    Train train = new(
        bigCarnivoreAmount, mediumCarnivoreAmount, smallCarnivoreAmount,
        bigHerbivoreAmount, mediumHerbivoreAmount, smallHerbivoreAmount);

    List<Wagon> wagons = train.Solve();
    
    foreach (Wagon wagon in wagons)
    {
        Console.WriteLine($"=== {wagon.Size} ===");
        foreach (Animal animal in wagon.Animals)
        {
            Console.WriteLine($"{animal.Size} {animal.Name}");
        }
    }

    Console.WriteLine($"=== Total Wagons: {wagons.Count} ===");
}

int GetNumberFromConsole()
{
    int animalsAmount = -1;
    while (animalsAmount == -1)
    {
        string? readLine = Console.ReadLine();
        if (readLine != null)
        {
            try
            {
                animalsAmount = int.Parse(readLine);
            }
            catch (FormatException ignored)
            {
                WriteError();
            }
        }
        else
        {
            WriteError();
        }
    }

    return animalsAmount;
}

void WriteError()
{
    Console.WriteLine("Please enter a number.");
}