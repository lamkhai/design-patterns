using AbstractFactory.Core.Models.Abstracts;

namespace AbstractFactory.Core.Factories.Abstracts;

public abstract class AbstractCultureFactory
{
    public abstract AbstractCountryModel CreateCountry();
    public abstract AbstractLanguageModel CreateLanguage();
}