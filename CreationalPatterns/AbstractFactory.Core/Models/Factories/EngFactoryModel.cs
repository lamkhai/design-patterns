using AbstractFactory.Core.Models.FactoryAbstracts;
using AbstractFactory.Core.Models.ProductAbstracts;
using AbstractFactory.Core.Models.Products;

namespace AbstractFactory.Core.Models.Factories;

public class EngFactoryModel : CultureFactory
{
    public override Country CreateCountry()
    {
        return new EnglandModel();
    }

    public override Language CreateLanguage()
    {
        return new EnglishModel();
    }
}