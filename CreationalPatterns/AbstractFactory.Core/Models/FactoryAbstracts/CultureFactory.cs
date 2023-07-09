using AbstractFactory.Core.Models.ProductAbstracts;

namespace AbstractFactory.Core.Models.FactoryAbstracts;

public abstract class CultureFactory
{
    public abstract Country CreateCountry();

    public abstract Language CreateLanguage();
}