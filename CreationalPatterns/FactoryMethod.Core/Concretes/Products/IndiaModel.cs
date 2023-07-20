using FactoryMethod.Core.Abstracts.Products;

namespace FactoryMethod.Core.Concretes.Products;

public class IndiaModel : CountryModel
{
    public override string Name => "India";
}