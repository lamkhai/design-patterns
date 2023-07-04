using FactoryMethod.Core.Models.Abstracts;
using LK.Shared.Enums;

namespace FactoryMethod.Core.Services;

public interface IFactoryMethodService
{
    List<CountryModel> GetCountries(ContinentEnum continentType);
}