using Builder.Core.Models.Abstracts;
using LK.Shared.Constants;
using LK.Shared.Enums;

namespace Builder.Core.Models.Concretes;

/// <summary>
/// The 'ConcreteBuilder' class
/// </summary>
public class ConcreteViVNBuilderModel : AbstractCultureBuilderModel
{
    public ConcreteViVNBuilderModel()
    {
        culture = new CultureProductModel(CultureEnum.viVN);
    }

    public override void BuildCapital()
    {
        culture[CapitalConstants.Capital] = CapitalConstants.Hanoi;
    }

    public override void BuildCountry()
    {
        culture[CountryConstants.Country] = CountryConstants.Vietnam;
    }

    public override void BuildCurrency()
    {
        culture[CurrencyConstants.Currency] = CurrencyConstants.VND;
    }

    public override void BuildLanguage()
    {
        culture[LanguageConstants.Language] = LanguageConstants.Vietnamese;
    }
}