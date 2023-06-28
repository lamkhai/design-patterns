using Builder.Core.Models.Abstracts;
using LK.Shared.Constants;
using LK.Shared.Enums;

namespace Builder.Core.Models.Concretes;

/// <summary>
/// The 'ConcreteBuilder' class
/// </summary>
public class ConcreteEnGBBuilderModel : AbstractCultureBuilderModel
{
    public ConcreteEnGBBuilderModel()
    {
        culture = new CultureProductModel(CultureEnum.enGB);
    }

    public override void BuildCapital()
    {
        culture[CapitalConstants.Capital] = CapitalConstants.London;
    }

    public override void BuildCountry()
    {
        culture[CountryConstants.Country] = CountryConstants.England;
    }

    public override void BuildCurrency()
    {
        culture[CurrencyConstants.Currency] = CurrencyConstants.GBP;
    }

    public override void BuildLanguage()
    {
        culture[LanguageConstants.Language] = LanguageConstants.English;
    }
}