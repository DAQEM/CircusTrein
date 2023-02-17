using CircusTreinLib.Algorithms;
using CircusTreinLib.Animals.Generator;

namespace CircusTreinLib;

public sealed class Train
{
    private readonly AnimalGenerator _animalGenerator;
    
    public Train(
        int bigCarnivoreAmount, int mediumCarnivoreAmount, int smallCarnivoreAmount, 
        int bigHerbivoreAmount, int mediumHerbivoreAmount, int smallHerbivoreAmount)
    {
        _animalGenerator = new AnimalGenerator(
            bigCarnivoreAmount, mediumCarnivoreAmount, smallCarnivoreAmount,
            bigHerbivoreAmount, mediumHerbivoreAmount, smallHerbivoreAmount);
    }

    public List<Wagon> Solve()
    {
        AnimalAlgorithm animalAlgorithm = new(_animalGenerator.Animals);
        return animalAlgorithm.Solve();
    }
}