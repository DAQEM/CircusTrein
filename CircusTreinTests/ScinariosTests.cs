using CircusTreinLib;

namespace CircusTreinTests;

public class Tests
{
    [Test]
    public void Scenario1()
    {
        Train train = new(0, 0, 1, 2, 3, 0);
        List<Wagon> wagons = train.Solve();
        Assert.That(wagons, Has.Count.EqualTo(2));
    }
    
    [Test]
    public void Scenario2()
    {
        Train train = new(0, 0, 1, 1, 2, 5);
        List<Wagon> wagons = train.Solve();
        Assert.That(wagons, Has.Count.EqualTo(2));
    }
    
    [Test]
    public void Scenario3()
    {
        Train train = new(1, 1, 1, 1, 1, 1);
        List<Wagon> wagons = train.Solve();
        Assert.That(wagons, Has.Count.EqualTo(4));
    }
    
    [Test]
    public void Scenario4()
    {
        Train train = new(2, 1, 1, 1, 5, 1);
        List<Wagon> wagons = train.Solve();
        Assert.That(wagons, Has.Count.EqualTo(5));
    }
    
    [Test]
    public void Scenario5()
    {
        Train train = new(0, 0, 1, 2, 1, 1);
        List<Wagon> wagons = train.Solve();
        Assert.That(wagons, Has.Count.EqualTo(2));
    }
    
    [Test]
    public void Scenario6()
    {
        Train train = new(0, 0, 3, 3, 2, 0);
        List<Wagon> wagons = train.Solve();
        Assert.That(wagons, Has.Count.EqualTo(3));
    }
    
    [Test]
    public void Scenario7()
    {
        Train train = new(3, 3, 7, 6, 5, 0);
        List<Wagon> wagons = train.Solve();
        Assert.That(wagons, Has.Count.EqualTo(13));
    }
}