using CircusTreinLib.Animals;

namespace CircusTreinLib;

public class Wagon
{
    private const int MaxSize = 10;
    private readonly List<Animal> _animals = new();
    private int _size = 0;

    public List<Animal> Animals => _animals;
    public int Size => _size;
    private bool IsFull => _size >= MaxSize;

    public bool TryAddAnimal(Animal animal)
    {
        if (CanAddAnimal(animal))
        {
            _animals.Add(animal);
            _size += animal.Size;
            return true;
        }

        return false;
    }
    
    private bool CanAddAnimal(Animal animal)
    {
        if (IsFull || _size + animal.Size > MaxSize) return false;

        foreach (Animal wagonAnimal in _animals)
        {
            if (animal.CanEat(wagonAnimal) || wagonAnimal.CanEat(animal)) return false;
        }
        return true;
    }
    
    public static Wagon WithAnimal(Animal animal)
    {
        Wagon wagon = new();
        wagon.TryAddAnimal(animal);
        return wagon;
    }
}