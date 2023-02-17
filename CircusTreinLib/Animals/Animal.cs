using CircusTreinLib.Animals.Utils;

namespace CircusTreinLib.Animals;

public abstract class Animal
{
    private readonly string _name;
    private readonly AnimalSize _size;

    public string Name => _name;
    public int Size => (int) _size;

    protected Animal(string name, AnimalSize size)
    {
        _name = name;
        _size = size;
    }

    public abstract bool CanEat(Animal toEatAnimal);
}