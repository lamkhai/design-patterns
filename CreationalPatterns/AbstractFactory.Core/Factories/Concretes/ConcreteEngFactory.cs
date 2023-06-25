using AbstractFactory.Core.Factories.Abstracts;
using AbstractFactory.Core.Models.Abstracts;
using AbstractFactory.Core.Models.Concretes;

namespace AbstractFactory.Core.Factories.Concretes;

public class ConcreteEngFactory : AbstractCultureFactory
{
    public override AbstractCountryModel CreateCountry()
    {
        return new ConcreteEnglandModel();
    }

    public override AbstractLanguageModel CreateLanguage()
    {
        return new ConcreteEnglishModel();
    }
}