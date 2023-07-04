using FactoryMethod.Core.Models.Abstracts;

namespace FactoryMethod.Core.Models.Concretes;

/// <summary>
/// A 'ConcreteCreator' class
/// </summary>
public class AsiaModel : ContinentModel
{
    public override void CreateCountries()
    {
        Countries.Add(new IndiaModel());
        Countries.Add(new VietnamModel());
    }
}