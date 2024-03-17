using cw2.Interfaces;

namespace cw2.Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    private static int _index { get; set; }
    private Enum _substance { get; set; }
    private bool _isDangerous;
    public LiquidContainer(double cargoWeight, double cargoHeight, double conteinerWeight, double depth, string seriesNumber, double maxLoad, PossibleProducts substance, bool isDangerous) : base(cargoWeight, cargoHeight, conteinerWeight, depth, seriesNumber, maxLoad)
    {
        SeriesNumber = ("KON-L-" + _index++);
        _substance = substance;
        _isDangerous = isDangerous;
    }

    public void DangerousSituation()
    {
        Console.WriteLine("Dangerous Situation: " + SeriesNumber);
    }
    

    public override void Load(double cargoWeight)
    {
        if (_isDangerous && (CargoWeight + cargoWeight) < MaxLoad / 2)
        {
            CargoWeight += cargoWeight;
        }
        else if(!_isDangerous && (CargoWeight + cargoWeight) < MaxLoad * 0.9)
        {
            CargoWeight += cargoWeight;
        } 
        else
        {
            Console.WriteLine("Danger Load! Aborted");
        }
    }
}