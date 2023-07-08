using AbstractFactory.Core.Models.FactoryAbstracts;
using AbstractFactory.Core.Models.ProductAbstracts;
using AbstractFactory.Core.Models.Responses;

namespace AbstractFactory.Core.Models.Clients;

public class Culture
{
    private readonly CountryModel _country;
    private readonly LanguageModel _language;
    
    public Culture(CultureFactory cultureFactory)
    {
        _country = cultureFactory.CreateCountry();
        _language = cultureFactory.CreateLanguage();
    }

    public CultureResponse GetCulture()
    {
        return _country.Has(_language);
    }
}