using CircusTreinLib.Animals.Utils;

namespace CircusTreinLib.Animals;

public class Herbivore : Animal
{
    public Herbivore(AnimalSize size) : base("Herbivore", size) {}

    public override bool CanEat(Animal toEatAnimal)
    {
        return false;
    }
}