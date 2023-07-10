using Builder.Core.Models.BuilderAbstracts;
using Builder.Core.Models.Products;
using LK.Shared.Constants;
using LK.Shared.Enums;

namespace Builder.Core.Models.Builders;

public class ViVNBuilderModel : CultureBuilder
{
    public ViVNBuilderModel()
    {
        culture = new CultureModel(CultureEnum.viVN);
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