using CircusTreinLib;
using CircusTreinLib.Algorithms;
using CircusTreinLib.Animals;

while (true)
{
    Console.WriteLine("\nHow many big carnivores?");
    int bigCarnivoreAmount = GetNumberFromConsole();
    
    Console.WriteLine("\nHow many medium carnivores?");
    int mediumCarnivoreAmount = GetNumberFromConsole();
    
    Console.WriteLine("\nHow many small carnivores?");
    int smallCarnivoreAmount = GetNumberFromConsole();
    
    Console.WriteLine("\nHow many big herbivores?");
    int bigHerbivoreAmount = GetNumberFromConsole();
    
    Console.WriteLine("\nHow many medium herbivores?");
    int mediumHerbivoreAmount = GetNumberFromConsole();
    
    Console.WriteLine("\nHow many small herbivores?");
    int smallHerbivoreAmount = GetNumberFromConsole();

    Train train = new(
        bigCarnivoreAmount, mediumCarnivoreAmount, smallCarnivoreAmount,
        bigHerbivoreAmount, mediumHerbivoreAmount, smallHerbivoreAmount);

    List<Wagon> wagons = train.Solve();
    
    Console.WriteLine("           ^");
    Console.WriteLine("          /^\\");
    Console.WriteLine("         // \\\\");
    Console.WriteLine("        //   \\\\");
    Console.WriteLine("       //     \\\\");
    Console.WriteLine("      //       \\\\");
    Console.WriteLine("    ===============");
    Console.WriteLine("    ||           ||");
    Console.WriteLine("    ||           ||");
    Console.WriteLine("    ||           ||");
    Console.WriteLine("    ||           ||");
    Console.WriteLine("    ||           ||");
    Console.WriteLine("  ===================");
    Console.WriteLine("  ||               ||");
    Console.WriteLine("  ||               ||");
    Console.WriteLine("  ||    Train ;)   ||");
    Console.WriteLine("  ||               ||");
    Console.WriteLine("  ||               ||");
    Console.WriteLine("  ===================");
    Console.WriteLine("           |");
    Console.WriteLine("           |");
    
    foreach (Wagon wagon in wagons)
    {
        Console.WriteLine($"   ======= {wagon.Size} =======");
        Console.WriteLine($"   ||             ||");
        foreach (Animal animal in wagon.Animals)
        {
            Console.Write("   || ");
            Console.Write($"{animal.Size} {animal.Name}");
            Console.WriteLine(" ||");
        }

        Console.WriteLine($"   ||             ||");
        Console.WriteLine("   =================");
        Console.WriteLine("           |");
    }

    Console.WriteLine($"\n    Total Wagons: {wagons.Count}");
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