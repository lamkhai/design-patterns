using FactoryMethod.Core.Abstracts.Products;

namespace FactoryMethod.Core.Concretes.Products;

public class SpainModel : CountryModel
{
    public override string Name => "Spain";
}