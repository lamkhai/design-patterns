using AbstractFactory.Core.Models.FactoryAbstracts;
using AbstractFactory.Core.Models.ProductAbstracts;
using AbstractFactory.Core.Models.Products;

namespace AbstractFactory.Core.Models.Factories;

public class VietFactoryModel : CultureFactory
{
    public override Country CreateCountry()
    {
        return new VietnamModel();
    }

    public override Language CreateLanguage()
    {
        return new VietnameseModel();
    }
}