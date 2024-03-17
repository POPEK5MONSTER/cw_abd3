using cw2.Interfaces;

namespace cw2.Containers;

public class GasConteiner : Container, IHazardNotifier
{
    private static int _index { get; set; }
    private Enum _substance { get; set; }
    private double _pressure { get; set; }

    public GasConteiner(double cargoWeight, double cargoHeight, double conteinerWeight, double depth, double maxLoad, PossibleProducts substance, double pressure) : base(cargoWeight, cargoHeight, conteinerWeight, depth, maxLoad)
    {
        SeriesNumber = ("KON-G-" + _index++);
        _substance = substance;
        _pressure = pressure;
    }

    public override void Unload()
    {
        CargoWeight *= 0.05;
    }


    public void DangerousSituation()
    {
        Console.WriteLine("Dangerous Situation: " + SeriesNumber);
    }
}