using AbstractFactory.Core.Factories.Abstracts;
using AbstractFactory.Core.Factories.Concretes;
using AbstractFactory.Core.Models.Abstracts;
using AbstractFactory.Core.Services;

namespace AbstractFactory.Infratructure.Services;

public class AbstractFactoryService : IAbstractFactoryService
{
    private AbstractCountryModel _country;
    private AbstractLanguageModel _language;

    public void Run(AbstractCultureFactory cultureFactory)
    {
        _country = cultureFactory.CreateCountry();
        _language = cultureFactory.CreateLanguage();

        _language.Interact(_country);
    }
}