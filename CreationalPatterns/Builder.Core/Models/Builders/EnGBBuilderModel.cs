using Builder.Core.Models.BuilderAbstracts;
using Builder.Core.Models.Products;
using LK.Shared.Constants;
using LK.Shared.Enums;

namespace Builder.Core.Models.Builders;

public class EnGBBuilderModel : CultureBuilder
{
    public EnGBBuilderModel()
    {
        culture = new CultureModel(CultureEnum.enGB);
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