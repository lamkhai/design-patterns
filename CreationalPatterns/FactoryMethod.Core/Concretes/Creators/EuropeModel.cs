using FactoryMethod.Core.Abstracts.Creators;
using FactoryMethod.Core.Concretes.Products;

namespace FactoryMethod.Core.Concretes.Creators;

public class EuropeModel : ContinentModel
{
    public override void CreateCountries()
    {
        Countries.Add(new GermanyModel());
        Countries.Add(new RussiaModel());
        Countries.Add(new SpainModel());
    }
}