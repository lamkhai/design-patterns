using AbstractFactory.Core.Models.FactoryAbstracts;
using AbstractFactory.Core.Models.ProductAbstracts;
using AbstractFactory.Core.Models.Products;

namespace AbstractFactory.Core.Models.Factories;

public class EngFactory : CultureFactory
{
    public override CountryModel CreateCountry()
    {
        return new EnglandModel();
    }

    public override LanguageModel CreateLanguage()
    {
        return new EnglishModel();
    }
}