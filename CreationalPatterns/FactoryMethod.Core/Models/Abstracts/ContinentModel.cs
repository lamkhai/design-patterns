﻿namespace FactoryMethod.Core.Models.Abstracts;

/// <summary>
/// The 'Creator' abstract class
/// </summary>
public abstract class ContinentModel
{
    private List<CountryModel> _countries = new List<CountryModel>();
    
    public ContinentModel()
    {
        CreateCountries();
    }

    public List<CountryModel> Countries
    {
        get { return _countries; }
    }
    
    public abstract void CreateCountries();
}