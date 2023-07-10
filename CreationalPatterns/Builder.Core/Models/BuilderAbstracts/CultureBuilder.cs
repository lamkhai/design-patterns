using Builder.Core.Models.Products;

#nullable disable
namespace Builder.Core.Models.BuilderAbstracts;

public abstract class CultureBuilder
{
    protected CultureModel culture;

    public CultureModel Culture
    {
        get { return culture; }
    }

    public abstract void BuildCapital();

    public abstract void BuildCountry();

    public abstract void BuildCurrency();

    public abstract void BuildLanguage();
}