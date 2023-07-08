using AbstractFactory.Core.Models.ProductAbstracts;

namespace AbstractFactory.Core.Models.FactoryAbstracts;

public abstract class CultureFactory
{
    public abstract CountryModel CreateCountry();

    public abstract LanguageModel CreateLanguage();
}