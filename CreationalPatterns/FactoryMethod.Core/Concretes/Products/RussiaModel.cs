using FactoryMethod.Core.Abstracts.Products;

namespace FactoryMethod.Core.Concretes.Products;

public class RussiaModel : CountryModel
{
    public override string Name => "Russia";
}