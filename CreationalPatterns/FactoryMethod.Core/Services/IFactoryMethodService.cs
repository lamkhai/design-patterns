using FactoryMethod.Core.Abstracts.Products;
using LK.Shared.Enums;

namespace FactoryMethod.Core.Services;

public interface IFactoryMethodService
{
    List<CountryModel> GetCountries(ContinentEnum continentType);

    List<DefaultAbstractProduct> GetDefault();
}