namespace Builder.Core.Models.Abstracts;

/// <summary>
/// The abstract 'Builder'
/// </summary>
public abstract class AbstractCultureBuilderModel
{
    protected CultureProductModel culture;
    
    public CultureProductModel Culture
    {
        get { return culture; }
    }

    public abstract void BuildCapital();

    public abstract void BuildCountry();

    public abstract void BuildCurrency();

    public abstract void BuildLanguage();
}