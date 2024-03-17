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
    public double CargoWeight { get; set; }
    protected Container(double cargoWeight)
    {
        CargoWeight = cargoWeight;
    }

    public void Unload()
    {
        throw new NotImplementedException();
    }

    public virtual void Load(double cargoWeight)
    {
        if (cargoWeight > 100)
        {
            throw new OverfillException();
        }
        throw new NotImplementedException();
    }
}