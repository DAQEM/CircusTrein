using CircusTreinLib.Animals;

namespace CircusTreinLib.Algorithms;

public class AnimalAlgorithm
{
    private readonly List<Animal> _animals;
    
    public AnimalAlgorithm(List<Animal> animals)
    {
        _animals = animals;
    }
    
    public List<Wagon> Solve()
    { 
        List<Wagon> wagons = new();
        
        List<Carnivore> carnivores = _animals.Where(a => a is Carnivore).Cast<Carnivore>().ToList();
        carnivores.ForEach(carnivore => wagons.Add(Wagon.WithAnimal(carnivore)));

        List<Herbivore> herbivores = _animals.Where(a => a is Herbivore).Cast<Herbivore>().ToList();
        
        wagons.ForEach(wagon =>
        {
            for (int i = herbivores.Count - 1; i >= 0; i--)
            {
                if (wagon.TryAddAnimal(herbivores[i]))
                {
                    herbivores.RemoveAt(i);
                    break;
                }
            }
        });
        
        herbivores.OrderBy(a => a.Size).ToList().ForEach(herbivore =>
        {
            bool added = false;
            foreach (Wagon wagon in wagons)
            {
                if (wagon.TryAddAnimal(herbivore))
                {
                    added = true;
                    break;
                }
            }
            if (!added) wagons.Add(Wagon.WithAnimal(herbivore));
        });
        return wagons;
    }
}