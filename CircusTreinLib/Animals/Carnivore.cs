using CircusTreinLib.Animals.Utils;

namespace CircusTreinLib.Animals;

public class Carnivore : Animal
{
    public Carnivore(AnimalSize size) : base("Carnivore", size) {}

    public override bool CanEat(Animal toEatAnimal)
    {
        return toEatAnimal.Size <= Size;
    }
}