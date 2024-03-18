using System.Xml;
using cw2.Containers;
using cw2.Exceptions;

namespace apbd3.Ships;

public class Ship
{
    private List<Container> _containers { get; set; } = new List<Container>();
    private double _maxSpeed { get; set; }
    private double _maxContainers { get; set;}
    private double _maxWeight { get; set;}

    public Ship( double maxSpeed, double maxContainers, double maxWeight)
    {
        _maxSpeed = maxSpeed;
        _maxContainers = maxContainers;
        _maxWeight = maxWeight;
    }

    public void UnloadContainers(Container container)
    {
        if (_containers.Contains(container))
        {
            Console.WriteLine("Rmoved container");
            _containers.Remove(container);
        }
        else
        {
            Console.WriteLine("No container");
        }
    }

    public void LoadContainer(Container container)
    {
        double _weightNow = 0;
        int counts = 0;
        for (int i = 0; i < _containers.Count; i++)
        {
            if (_weightNow > _maxWeight || counts > _maxContainers)
            {
                throw new OverfillException();
            }
            _weightNow += _containers[i].GetWeight();
            counts++;
        }
        Console.WriteLine("Add container");
        _containers.Add(container);
    }
    
    public void ChangeContainerWithNumber(Container container_old, Container container_new)
    {
        int index = _containers.FindIndex(c => c.Equals(container_old));
        if (index >= 0)
            _containers[index] = container_new;
    }

    public void changeContainer(Ship ship1, Container container)
    {
        this._containers.Remove(container);
        ship1._containers.Add(container);
        Console.WriteLine("Changed containers to another ship");
    }

    public void InfoShip()
    {
        Console.WriteLine("Max Speed: " + _maxSpeed + " Max Weight: " + _maxWeight + " Max Containers: " + _maxContainers);
        for (int i = 0; i < _containers.Count; i++)
        {
            _containers[i].InfoContainer();
        }
    }
}