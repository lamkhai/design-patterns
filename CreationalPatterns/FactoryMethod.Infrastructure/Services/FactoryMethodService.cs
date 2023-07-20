using FactoryMethod.Core.Abstracts.Creators;
using FactoryMethod.Core.Abstracts.Products;
using FactoryMethod.Core.Concretes.Creators;
using FactoryMethod.Core.Services;
using LK.Shared.Enums;

namespace FactoryMethod.Infrastructure.Services;

public class FactoryMethodService : IFactoryMethodService
{
    public List<CountryModel> GetCountries(ContinentEnum continentType)
    {
        var continents = new List<ContinentModel>();

        switch (continentType)
        {
            case ContinentEnum.Asia:
                continents.Add(new AsiaModel());
                break;
            case ContinentEnum.Europe:
                continents.Add(new EuropeModel());
                break;
            default:
                continents.Add(new AsiaModel());
                continents.Add(new EuropeModel());
                break;
        }

        return continents.SelectMany(x => x.Countries).ToList();
    }

    public List<DefaultAbstractProduct> GetDefault()
    {
        var creators = new DefaultAbstractCreator[2];
        creators[0] = new DefaultConcreteCreatorA();
        creators[1] = new DefaultConcreteCreatorB();

        return creators.Select(x => x.FactoryMethod()).ToList();
    }
}