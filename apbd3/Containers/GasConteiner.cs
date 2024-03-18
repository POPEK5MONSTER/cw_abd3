using cw2.Interfaces;

namespace cw2.Containers;

public class GasConteiner : Container, IHazardNotifier
{
    private static int _index { get; set; }
    private Enum _substance { get; set; }
    private double _pressure { get; set; }

    public GasConteiner(double cargoWeight, double cargoHeight, double conteinerWeight, double depth, double maxLoad, PossibleProducts substance, double pressure) : base(cargoWeight, cargoHeight, conteinerWeight, depth, maxLoad)
    {
        _seriesNumber = ("KON-G-" + _index++);
        _substance = substance;
        _pressure = pressure;
    }

    public override void Unload()
    {
        _cargoWeight *= 0.05;
        Console.WriteLine("Unload");
    }

    public string GetNumber()
    {
        return _seriesNumber;
    }
    public void DangerousSituation()
    {
        Console.WriteLine("Dangerous Situation: " + _seriesNumber);
    }

    public override void InfoContainer()
    {
        Console.WriteLine("Number: " + _seriesNumber + " " + _substance + " pressure: " + _pressure);
        base.InfoContainer();
    }
}