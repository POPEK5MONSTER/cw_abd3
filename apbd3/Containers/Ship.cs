using cw2.Containers;

namespace apbd3.Ships;

public class Ship
{
    private List<Container> _containers { get; set; }
    private double _maxSpeed { get; set; }
    private double _maxContainers { get; set;}
    private double _maxWeight { get; set;}

    public Ship(List<Container> containers, double maxSpeed, double maxContainers, double maxWeight)
    {
        _containers = containers;
        _maxSpeed = maxSpeed;
        _maxContainers = maxContainers;
        _maxWeight = maxWeight;
    }

    public void UnloadContainers(Container container)
    {
        if (_containers.Contains(container))
        {
            _containers.Remove(container);
        }
        else
        {
            Console.WriteLine("No container");
        }
    }
}