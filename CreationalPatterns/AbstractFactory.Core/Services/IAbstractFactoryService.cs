using AbstractFactory.Core.Factories.Abstracts;
using AbstractFactory.Core.Models;

namespace AbstractFactory.Core.Services;

public interface IAbstractFactoryService
{
    LanguageCountryModel GetLanguageCountry(AbstractCultureFactory cultureFactory);
}