using FactoryMethod.Core.Models.Abstracts;
using FactoryMethod.Core.Models.Concretes;
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
}