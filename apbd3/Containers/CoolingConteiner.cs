namespace cw2.Containers;

public class CoolingConteiner : Container
{
    private static int _index { get; set; }
    private Enum _substance { get; set; }
    private double _temerature { get; set; }

    private Dictionary<PossibleProducts, double> _productsList;
    public CoolingConteiner(double cargoWeight, double cargoHeight, double conteinerWeight, double depth, double maxLoad, PossibleProducts substance, double temerature ) : base(cargoWeight, cargoHeight, conteinerWeight, depth, maxLoad)
    {
        
        _productsList = new Dictionary<PossibleProducts, double>();
        if (_productsList.Count == 0)
        {
            _productsList.Add(PossibleProducts.Apple, 3);
            _productsList.Add(PossibleProducts.Banana, 1);
            _productsList.Add(PossibleProducts.Meat, -8);
        }

        if (_productsList.GetValueOrDefault(substance) > temerature)
        {
            double tmp = _productsList.GetValueOrDefault(substance);
            Console.WriteLine("To low temperature:" + tmp);
        }
        SeriesNumber = ("KON-C-" + _index++);
        _substance = substance;
        _temerature = temerature;
    }
    
}