using FactoryMethod.Core.Abstracts.Products;

namespace FactoryMethod.Core.Concretes.Products;

public class GermanyModel : CountryModel
{
    public override string Name => "Germany";
}