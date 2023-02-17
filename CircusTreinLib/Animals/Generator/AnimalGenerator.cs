using CircusTreinLib.Animals.Utils;

namespace CircusTreinLib.Animals.Generator;

public class AnimalGenerator
{
    private readonly List<Animal> _animals = new();

    public List<Animal> Animals => _animals;

    public AnimalGenerator(
        int bigCarnivoreAmount, int mediumCarnivoreAmount, int smallCarnivoreAmount, 
        int bigHerbivoreAmount, int mediumHerbivoreAmount, int smallHerbivoreAmount)
    {
        CreateAnimals(bigCarnivoreAmount, new Carnivore(AnimalSize.Big));
        CreateAnimals(mediumCarnivoreAmount, new Carnivore(AnimalSize.Medium));
        CreateAnimals(smallCarnivoreAmount, new Carnivore(AnimalSize.Small));
        CreateAnimals(bigHerbivoreAmount, new Herbivore(AnimalSize.Big));
        CreateAnimals(mediumHerbivoreAmount, new Herbivore(AnimalSize.Medium));
        CreateAnimals(smallHerbivoreAmount, new Herbivore(AnimalSize.Small));
    }

    private void CreateAnimals(int amount, Animal animal)
    {
        Enumerable.Range(0, amount).ToList().ForEach(_ => _animals.Add(animal));
    }
}