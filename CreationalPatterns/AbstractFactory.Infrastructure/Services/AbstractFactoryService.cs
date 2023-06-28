using AbstractFactory.Core.Factories.Abstracts;
using AbstractFactory.Core.Models;
using AbstractFactory.Core.Services;

namespace AbstractFactory.Infrastructure.Services;

public class AbstractFactoryService : IAbstractFactoryService
{
    public LanguageCountryModel GetLanguageCountry(AbstractCultureFactory cultureFactory)
    {
        var country = cultureFactory.CreateCountry();
        var language = cultureFactory.CreateLanguage();

        return language.Interact(country);
    }
}