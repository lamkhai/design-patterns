using FactoryMethod.Core.Abstracts.Creators;
using FactoryMethod.Core.Concretes.Products;

namespace FactoryMethod.Core.Concretes.Creators;

public class AsiaModel : ContinentModel
{
    public override void CreateCountries()
    {
        Countries.Add(new IndiaModel());
        Countries.Add(new VietnamModel());
    }
}