using AbstractFactory.Core.Factories.Abstracts;
using AbstractFactory.Core.Models.Abstracts;
using AbstractFactory.Core.Models.Concretes;

namespace AbstractFactory.Core.Factories.Concretes;

public class ConcreteVietFactory : AbstractCultureFactory
{
    public override AbstractCountryModel CreateCountry()
    {
        return new ConcreteVietnamModel();
    }

    public override AbstractLanguageModel CreateLanguage()
    {
        return new ConcreteVietnameseModel();
    }
}