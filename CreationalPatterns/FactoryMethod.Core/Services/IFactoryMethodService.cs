using FactoryMethod.Core.Abstracts;
using FactoryMethod.Core.Models.Abstracts;
using LK.Shared.Enums;

namespace FactoryMethod.Core.Services;

public interface IFactoryMethodService
{
    List<CountryModel> GetCountries(ContinentEnum continentType);

    List<DefaultAbstractProduct> GetDefault();
}