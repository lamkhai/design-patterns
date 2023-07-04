using FactoryMethod.Core.Models.Abstracts;

namespace FactoryMethod.Core.Models.Concretes;

/// <summary>
/// A 'ConcreteCreator' class
/// </summary>
public class EuropeModel : ContinentModel
{
    public override void CreateCountries()
    {
        Countries.Add(new GermanyModel());
        Countries.Add(new RussiaModel());
        Countries.Add(new SpainModel());
    }
}