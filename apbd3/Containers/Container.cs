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
    protected double CargoWeight { get; set; }
    protected double CargoHeight { get; set; }
    protected double ConteinerWeight { get; set; }
    protected double Depth { get; set; }
    protected string SeriesNumber { get; set; }
    protected double MaxLoad { get; set; }

    protected Container(double cargoWeight, double cargoHeight, double conteinerWeight, double depth, double maxLoad)
    {
        CargoWeight = cargoWeight;
        CargoHeight = cargoHeight;
        ConteinerWeight = conteinerWeight;
        Depth = depth;
        MaxLoad = maxLoad;
    }

    public virtual void Unload()
    {
        CargoWeight = 0;
    }

    public virtual void Load(double cargoWeight)
    {
        if ((CargoWeight + cargoWeight) > MaxLoad)
        {
            throw new OverfillException();
        }
        else
        {
            CargoWeight += cargoWeight;
        }
        
    }

}