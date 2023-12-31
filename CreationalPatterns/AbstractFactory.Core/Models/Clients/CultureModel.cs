﻿using AbstractFactory.Core.Models.FactoryAbstracts;
using AbstractFactory.Core.Models.ProductAbstracts;
using AbstractFactory.Core.Models.Responses;

namespace AbstractFactory.Core.Models.Clients;

public class CultureModel
{
    private readonly Country _country;
    private readonly Language _language;
    
    public CultureModel(CultureFactory cultureFactory)
    {
        _country = cultureFactory.CreateCountry();
        _language = cultureFactory.CreateLanguage();
    }

    public CultureResponse GetCulture()
    {
        return _country.Has(_language);
    }
}