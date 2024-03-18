using cw2.Exceptions;
using cw2.Interfaces;

namespace cw2.Containers;

public abstract class Container : IContainer
{
    /*
    private double _cargoWeight;

    public double GetCargoWeight()
    {
        return _cargoWeight;
    }

    public void SetCargoWeight(double value)
    {
        _cargoWeight = value;
    }
    */
    protected double _cargoWeight { get; set; }
    protected double _cargoHeight { get; set; }
    protected double _conteinerWeight { get; set; }
    protected double _depth { get; set; }
    protected string _seriesNumber { get; set; }
    protected double _maxLoad { get; set; }

    protected Container(double cargoWeight, double cargoHeight, double conteinerWeight, double depth, double maxLoad)
    {
        _cargoWeight = cargoWeight;
        _cargoHeight = cargoHeight;
        _conteinerWeight = conteinerWeight;
        _depth = depth;
        _maxLoad = maxLoad;
    }

    public virtual void Unload()
    {
        Console.WriteLine("Unload");
        _cargoWeight = 0;
    }

    public double GetWeight()
    {
        return _cargoWeight; 
    }
    public virtual void Load(double cargoWeight)
    {
        if ((_cargoWeight + cargoWeight) > _maxLoad)
        {
            Console.WriteLine("To much");
            throw new OverfillException();
        }
        else
        {
            Console.WriteLine("Load: " + cargoWeight);
            _cargoWeight += cargoWeight;
            Console.WriteLine("Container: " + _cargoWeight);
        }

    }

       
    public virtual void InfoContainer()
    {
        Console.WriteLine("Weight: " + _cargoHeight + " Height: " + _cargoHeight + " Max Load: " + _maxLoad +
        " Container Weight: " + _conteinerWeight + " Depth: " + _depth);
    }
}